using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace Util.Audio {
    class AudioController {
        private static AudioController instance;
        private MMDeviceEnumerator deviceEnum;

        private AudioController() {
            deviceEnum = new MMDeviceEnumerator();
        }

        public static AudioController GetInstance() {
            if(instance == null) {
                instance = new AudioController();
            }
            return instance;
        }

        public int GetDefaultInputDeviceNumber() {
            return GetDefaultDeviceNumber(DataFlow.Capture);
        }

        public int GetDefaultOutputDeviceNumber() {
            return GetDefaultDeviceNumber(DataFlow.Render);
        }

        public int GetDefaultDeviceNumber(DataFlow dataflow) {
            return SearchDeviceNumber(DataFlow.Capture, deviceEnum.GetDefaultAudioEndpoint(dataflow, Role.Multimedia).FriendlyName);
        }

        private int SearchDeviceNumber(DataFlow dataflow, string friendlyName) {
            int result = 0;
            for(int i = 0; i < WaveIn.DeviceCount; i++) {
                if(WaveIn.GetCapabilities(i).ProductName.Equals(friendlyName, StringComparison.OrdinalIgnoreCase)) {
                    result = i;
                }
            }
            return result;
        }
    }
}
