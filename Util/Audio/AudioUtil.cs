using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using Util.MyExceptions;

namespace Util {
    public class AudioUtil {
        public enum MonoOutChannels { Both, Right, Left };
        public enum SilenceLocation { Start, End };
        public void DetectSilence() {

        }

        public void RemoveSilences() {

        }

        public void SplitBySilence(string inputFile, string outputFolder, int threshold) {

        }



        /// <summary>
        /// Convert a MP3 file to WAV.
        /// </summary>
        /// <param name="filePath">The path to MP3 file.</param>
        /// <param name="outputFolder">The path to output folder</param>
        /// <param name="outputSampleRate">The sample rate for the output wav file (default: 16kHz)</param>
        /// <returns>The path to created WAV file.</returns>
        public static string Mp3ToWav(string filePath, string outputFolder, int outputSampleRate = 16000) {
            if (Path.GetExtension(filePath).ToLower() != ".mp3") {
                throw new AudioException("The input file must be a MP3 audio file.");
            }
            string outFile = string.Format("{0}/{1}.wav", outputFolder, Path.GetFileNameWithoutExtension(filePath));

            using (Mp3FileReader mp3reader = new Mp3FileReader(filePath)) {
                if (!Directory.Exists(outputFolder)) {
                    Directory.CreateDirectory(outputFolder);
                }
                var outFormat = new WaveFormat(outputSampleRate, mp3reader.WaveFormat.Channels);
                using (var resampler = new MediaFoundationResampler(mp3reader, outFormat)) {
                    WaveFileWriter.CreateWaveFile(outFile, resampler);
                }
            }
            return outFile;

        }

        /// <summary>
        /// Convert a stereo WAV file to mono.
        /// </summary>
        /// <param name="stereoFilePath">The path to stereo wav file.</param>
        /// <param name="channels">The channels of input file to use in mono output (default: Both).</param>
        /// <returns>The path to created mono file</returns>
        public static string StereoToMono(string stereoFilePath, MonoOutChannels channels = MonoOutChannels.Both) {
            if (Path.GetExtension(stereoFilePath).ToLower() != ".wav") {
                throw new AudioException("The input file must be a WAV audio file.");
            }
            using (var inputReader = new AudioFileReader(stereoFilePath)) {
                var mono = new StereoToMonoSampleProvider(inputReader);
                switch (channels) {
                    case MonoOutChannels.Both:
                        mono.LeftVolume = 0.5f;
                        mono.RightVolume = 0.5f;
                        break;
                    case MonoOutChannels.Right:
                        mono.LeftVolume = 0f;
                        mono.RightVolume = 1f;
                        break;
                    case MonoOutChannels.Left:
                        mono.LeftVolume = 1f;
                        mono.RightVolume = 0f;
                        break;
                }
                string monoOutDir = Path.Combine(Path.GetDirectoryName(stereoFilePath), "mono");//string.Format("{0}/mono",Path.GetDirectoryName(stereoFilePath));
                if (!Directory.Exists(monoOutDir)) {
                    Directory.CreateDirectory(monoOutDir);
                }
                string monoFile = string.Format("{0}/{1}.wav", monoOutDir, Path.GetFileNameWithoutExtension(stereoFilePath));
                WaveFileWriter.CreateWaveFile16(monoFile, mono);
                return monoFile;
            }
        }

        private static bool IsSilence(float amplitude, sbyte threshold) {
            double dB = Math.Log10(Math.Abs(amplitude));
            return dB < threshold;
        }

        public static TimeSpan GetSilenceDuration(AudioFileReader reader,
                                              SilenceLocation location,
                                              sbyte silenceThreshold = -20) {
            int counter = 0;
            bool volumeFound = false;
            bool eof = false;
            long oldPosition = reader.Position;

            var buffer = new float[reader.WaveFormat.SampleRate * 4];
            while (!volumeFound && !eof) {
                int samplesRead = reader.Read(buffer, 0, buffer.Length);
                if (samplesRead == 0)
                    eof = true;

                for (int n = 0; n < samplesRead; n++) {
                    if (IsSilence(buffer[n], silenceThreshold)) {
                        counter++;
                    }
                    else {
                        if (location == SilenceLocation.Start) {
                            volumeFound = true;
                            break;
                        }
                        else if (location == SilenceLocation.End) {
                            counter = 0;
                        }
                    }
                }
            }

            // reset position
            reader.Position = oldPosition;

            double silenceSamples = (double)counter / reader.WaveFormat.Channels;
            double silenceDuration = (silenceSamples / reader.WaveFormat.SampleRate) * 1000;
            return TimeSpan.FromMilliseconds(silenceDuration);
        }

    }
}
