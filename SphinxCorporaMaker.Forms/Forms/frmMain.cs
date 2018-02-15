using SphinxCorporaMaker.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;
using Util.Text;
using Util.Audio;

namespace SphinxCorporaMaker {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }



        private void btnTextFile_Click(object sender, EventArgs e) {
            // MessageBox.Show(Path.GetFileNameWithoutExtension(Application.StartupPath + "/SphinxCorporaMaker.exe"));
            frmRecAudio4Text recAudio = new frmRecAudio4Text();
            recAudio.Show();
        }

        private void btnAudio_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string converted = AudioUtil.Mp3ToWav(openFileDialog1.FileName, Application.StartupPath + "/testeWav");
                MessageBox.Show(Path.GetExtension(converted));

                if (MessageBox.Show("Sucessfully converted MP3 to WAV!\n\nConvert to mono?", "Converted", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                    string mono = AudioUtil.StereoToMono(converted);
                    if (MessageBox.Show("Sucessfully converted stereo to mono!\n\nPlay file?", "Converted", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                        Process.Start(mono);
                    }
                }

            }

        }

        private void button1_Click(object sender, EventArgs e) {
            var audio = new RecordWaveAudio(Application.StartupPath, "TESTE");
            if (button1.Text == "Gravar") {
                button1.Text = "Parar";
                audio.Start();
            }
            else {
                audio.Stop();
                button1.Text = "Gravar";
            }
        }
    }
}

