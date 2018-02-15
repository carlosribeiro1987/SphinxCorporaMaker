﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;

namespace Util.Audio {
    public class RecordWaveAudio {
        private WaveInEvent waveIn;
        private WaveFileWriter writer;
        private string wavFile;
        public RecordWaveAudio(string outputDir, string filename, int sampleRate = 16000, int channels = 1) {
            waveIn = new WaveInEvent();
            waveIn.DeviceNumber = AudioController.GetInstance().GetDefaultInputDeviceNumber();
            waveIn.WaveFormat = new WaveFormat(sampleRate, channels);
            waveIn.DataAvailable += WaveIn_DataAvailable;
            if (!Directory.Exists(outputDir)) {
                Directory.CreateDirectory(outputDir);
            }
            wavFile = Path.Combine(outputDir, filename + ".wav");
            
        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e) {
            writer.Write(e.Buffer, 0, e.BytesRecorded);
            writer.Flush();
        }

        public void Start() {
            //try {
                writer = new WaveFileWriter(wavFile, waveIn.WaveFormat);
                waveIn.StartRecording();
            //}
            //catch {
            //    return;
            //}
        }

        public void Stop() {
            //try {
                waveIn.StopRecording();
                waveIn.Dispose();
                writer.Dispose();
            //}
            //catch {
                
            //    return;
            //}
        }


    }
}
