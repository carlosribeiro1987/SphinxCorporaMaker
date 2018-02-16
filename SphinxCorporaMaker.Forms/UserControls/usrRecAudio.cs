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
using Util.Audio;

namespace SphinxCorporaMaker.UserControls {
    public partial class usrRecAudio : UserControl {
        string audioDir = Path.Combine(Application.StartupPath, "CorporaFiles", "audio");
        RecordWaveAudio wavAudio = null;
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
            btnRecord.Enabled = dgvSentences.SelectedRows.Count > 0;
            if (dgvSentences.SelectedRows.Count > 0) {
                DataGridViewRow row = dgvSentences.SelectedRows[0];
                txtCurrentSentence.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnRecord_Click(object sender, EventArgs e) {
            

            //MessageBox.Show(audioDir);
        }

        private void usrRecAudio_Load(object sender, EventArgs e) {
            cmbInputDevices.DataSource = RecordWaveAudio.InputAudioDevices();
            cmbInputDevices.SelectedIndex = 0;
        }

        private void btnRecord_MouseUp(object sender, MouseEventArgs e) {
            dgvSentences.MultiSelect = false;
            
            tmrRecording.Enabled = false;
            lblRecodStatus.Text = "Hold the button to record.";
            lblRecodStatus.ForeColor = Color.Black;
            NextSentenceRow();
            if (wavAudio != null) {
                wavAudio.Stop();
                wavAudio = null;
            }
        }
        private void NextSentenceRow() {
            DataGridViewRow currentRow = dgvSentences.CurrentRow;
            int currRowIndex = currentRow.Index;
            int maxRowIndex = dgvSentences.Rows.Count - 1 - 1;
            if (currRowIndex < maxRowIndex) {
                DataGridViewRow nextRow = dgvSentences.Rows[currRowIndex + 1];
                dgvSentences.CurrentCell = nextRow.Cells[0];
                nextRow.Selected = true;
                dgvSentences.Focus();
            }
        }

        private void btnRecord_MouseDown(object sender, MouseEventArgs e) {
            lblRecodStatus.Text = "RECORDING...";
            lblRecodStatus.ForeColor = Color.Red;
            tmrRecording.Enabled = true;
            if (dgvSentences.SelectedRows.Count < 1)
                return;
            if (!Directory.Exists(audioDir)) {
                Directory.CreateDirectory(audioDir);
            }
            wavAudio = new RecordWaveAudio(audioDir, dgvSentences.CurrentRow.Cells[0].Value.ToString(), cmbInputDevices.SelectedIndex);
            wavAudio.Start();
        }

        private void tmrRecording_Tick(object sender, EventArgs e) {
            lblRecodStatus.Visible = !lblRecodStatus.Visible;
        }
    }
}
