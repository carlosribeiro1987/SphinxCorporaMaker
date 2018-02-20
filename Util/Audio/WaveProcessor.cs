using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Audio {
    public class WaveProcessor {
        private const short CHANNELS = 1;
        private const short FILTER_FREQ_LOW = -10000;
        private const short FILTER_FREQ_HIGH = 10000;
        private const int SAMPLE_RATE = 8000;
        private const int BITS_PER_SAMPLE = 16;
        private int _length;
        private short _channels;
        private int _sampleRate;
        private int _dataLength;
        private int _bitsSample;
        private ushort _maxLevel;

        private bool WaveHeaderIn(string path) {
            if (string.IsNullOrWhiteSpace(path))
                return false;
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            try {
                _length = (int)stream.Length - 8;
                stream.Position = 22;
                _channels = reader.ReadInt16();
                stream.Position = 24;
                _sampleRate = reader.ReadInt32();
                stream.Position = 34;
                _bitsSample = reader.ReadInt16();
                _dataLength = (int)stream.Length - 44;
                byte[] arrFile = new byte[_dataLength];
                stream.Position = 44;
                stream.Read(arrFile, 0, arrFile.Length);
            }
            catch {
                return false;
            }
            finally {
                reader.Close();
                stream.Close();
            }
            return true;
        }

        private bool WaveHeaderOut(string path) {
            if (string.IsNullOrWhiteSpace(path))
                return false;
            FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream);
            try {
                stream.Position = 0;
                writer.Write(new char[4] { 'R', 'I', 'F', 'F' });
                writer.Write(_length);
                writer.Write(new char[8] { 'W', 'A', 'V', 'E', 'f', 'm', 't', ' ' });
                writer.Write((int)16);
                writer.Write((short)1);
                writer.Write(_channels);
                writer.Write(_sampleRate);
                writer.Write((int)(_sampleRate * ((_bitsSample * _channels) / 8)));
                writer.Write((short)((_bitsSample * _channels) / 8));
                writer.Write(_bitsSample);
                writer.Write(new char[4] { 'd', 'a', 't', 'a' });
                writer.Write(_dataLength);
            }
            catch {
                return false;
            }
            finally {
                writer.Close();
                stream.Close();
            }
            return true;
        }

        public bool Compare(ref WaveProcessor wave1, ref WaveProcessor wave2) {
            return (wave1._channels == wave2._channels) && (wave1._bitsSample == wave2._bitsSample) && (wave1._sampleRate == wave2._sampleRate);
        }


        private short ComplementToSigned(ref byte[] dataArray, int offset) // 2's complement to normal signed value
        {
            short snd = BitConverter.ToInt16(dataArray, offset);
            if (snd != 0)
                snd = Convert.ToInt16((~snd | 1));
            return snd;
        }


        private byte[] SignedToComplement(short value) //Convert to 2's complement and return as byte array of 2 bytes
        {
            byte[] bt = new byte[2];
            value = Convert.ToInt16((~value | 1));
            bt = BitConverter.GetBytes(value);
            return bt;
        }

        private byte[] GetWaveData(string path) {
            try {
                FileStream stream = new FileStream(@path, FileMode.Open, FileAccess.Read);
                byte[] data = new byte[stream.Length - 44];
                stream.Position = 44;
                stream.Read(data, 0, data.Length);
                stream.Close();
                return data;
            }
            catch(IOException ex) {
                throw ex;
            }
        }

        private bool WriteWaveData(string path, ref byte[] data) {
            try {
                FileStream stream = new FileStream(@path, FileMode.Append, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);
                writer.Write(data);
                writer.Close();
                stream.Close();
                return true;
            }
            catch(Exception ex) {
                throw ex;
            }
        }

    }
}
