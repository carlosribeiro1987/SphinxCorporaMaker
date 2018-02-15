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

namespace SphinxCorporaMaker.UserControls {
    public partial class usrRecAudio : UserControl {
        string audioDir = Path.Combine(Application.StartupPath, "CorporaFiles", "audio");
        public usrRecAudio() {
            InitializeComponent();
        }

        public void AddSentences(string text) {
            string[] tempArray = TextUtil.SplitSentences(text);
            for (int i = 0; i < tempArray.Length; i++) {
                tempArray[i] = TextUtil.RemoveSymbols(tempArray[i]).ToLower();
            }
            string[] sentences = tempArray.Where(str => !string.IsNullOrWhiteSpace(str) && str.Length > 1).ToArray();
            dgvSentences.Rows.Clear();
            for (int i = 0; i < sentences.Length; i++) {
                dgvSentences.Rows.Add((i + 1).ToString().PadLeft(6, '0'), sentences[i]);
            }
            lblTotalSentences.Text = string.Format("{0} sentences.", dgvSentences.RowCount);
            dgvSentences.Focus();
        }

        private void dgvSentences_SelectionChanged(object sender, EventArgs e) {
            if (dgvSentences.SelectedRows.Count > 0) {
                DataGridViewRow row = dgvSentences.SelectedRows[0];
                txtCurrentSentence.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnRecord_Click(object sender, EventArgs e) {
            if (!Directory.Exists(audioDir)) {
                Directory.CreateDirectory(audioDir);
            }
            MessageBox.Show(audioDir);
        }
    }
}
