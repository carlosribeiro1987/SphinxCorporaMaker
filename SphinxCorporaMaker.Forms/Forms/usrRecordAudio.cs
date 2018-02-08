using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util.Text;
using System.IO;

namespace SphinxCorporaMaker.Forms {
    public partial class usrRecordAudio : UserControl {
        public usrRecordAudio() {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            string[] tempArray = TextUtil.SplitSentences(txtRawText.Text);            
            for (int i = 0; i < tempArray.Length; i++) {
                tempArray[i] = TextUtil.RemoveSymbols(tempArray[i]).ToLower();
            }
            string[] sentences = tempArray.Where(str => !string.IsNullOrWhiteSpace(str)&&str.Length>1).ToArray();
            dgvSentences.Rows.Clear();
            for (int i = 0; i < sentences.Length; i++) {
                dgvSentences.Rows.Add((i+1).ToString().PadLeft(6, '0'), sentences[i]);
            }
        }

        private static bool HasAudio(int index) {
            return File.Exists(index.ToString().PadLeft(6, '0') + ".wav");
        }

    }
}
