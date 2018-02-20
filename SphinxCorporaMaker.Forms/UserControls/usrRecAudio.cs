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
using NAudio.Wave;
using Util;

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
                dgvSentences.Rows[i].Cells[2].Value = HasAudio(dgvSentences.Rows[i]);
            }
            lblTotalSentences.Text = string.Format("{0} sentences.", dgvSentences.RowCount);
            UpdateTotalTimeLabel();
            dgvSentences.Focus();
        }

        private void dgvSentences_SelectionChanged(object sender, EventArgs e) {
            lblRecordStatus.Visible = true;
            btnRecord.Enabled = dgvSentences.SelectedRows.Count > 0;
            if (dgvSentences.SelectedRows.Count > 0) {
                DataGridViewRow row = dgvSentences.SelectedRows[0];
                txtCurrentSentence.Text = row.Cells[1].Value.ToString();


            }
        }

        private void usrRecAudio_Load(object sender, EventArgs e) {
            cmbInputDevices.DataSource = RecordWaveAudio.InputAudioDevices();
            cmbInputDevices.SelectedIndex = 0;
        }

        private void btnRecord_MouseUp(object sender, MouseEventArgs e) {
            dgvSentences.MultiSelect = false;

            tmrRecording.Enabled = false;
            lblRecordStatus.Text = "Hold the button to record.";
            lblRecordStatus.ForeColor = Color.Black;
            
            if (wavAudio != null) {
                wavAudio.Stop();
                wavAudio = null;
            }
            AudioFileReader reader = new AudioFileReader(Path.Combine(audioDir, dgvSentences.CurrentRow.Cells[0].Value.ToString() + ".wav"));
            TimeSpan silence = AudioUtil.GetSilenceDuration(reader, AudioUtil.SilenceLocation.Start);
            MessageBox.Show("Silence: "+silence.TotalMilliseconds.ToString());
            NextSentenceRow();
        }
        private string HasAudio(DataGridViewRow row) {
            string rowFile = Path.Combine(audioDir, row.Cells[0].Value.ToString() + ".wav");
            bool hasAudio = File.Exists(rowFile);
            if (hasAudio) {
                TimeSpan duration = GetAudioFileTime(rowFile); 
                return string.Format("{0}.{1:D3}", duration.ToString().Substring(0, 8), duration.Milliseconds);
            }
            else {
                return "No audio";
            }
        }
        private bool HasAudio() {
            return File.Exists(Path.Combine(audioDir, dgvSentences.CurrentRow.Cells[0].Value.ToString() + ".wav"));
        }

        private void NextSentenceRow() {
            DataGridViewRow currentRow = dgvSentences.CurrentRow;
            int currRowIndex = currentRow.Index;
            int maxRowIndex = dgvSentences.Rows.Count - 1 - 1;
            dgvSentences.CurrentRow.Cells[2].Value = HasAudio(dgvSentences.CurrentRow);


            if (currRowIndex < maxRowIndex) {
                DataGridViewRow nextRow = dgvSentences.Rows[currRowIndex + 1];
                dgvSentences.CurrentCell = nextRow.Cells[0];
                nextRow.Selected = true;                
            }
            UpdateTotalTimeLabel();
            dgvSentences.Focus();
        }

        private void btnRecord_MouseDown(object sender, MouseEventArgs e) {
            lblRecordStatus.Text = "RECORDING...";
            lblRecordStatus.ForeColor = Color.Red;
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
            lblRecordStatus.Visible = !lblRecordStatus.Visible;
        }

        private void DrawPlayButton() {

        }

        private TimeSpan GetTotalAudioTime(string dirPath) {
            DirectoryInfo audioDir = new DirectoryInfo(dirPath);
            TimeSpan total = TimeSpan.Zero;
            foreach (var file in audioDir.GetFiles("*.wav")) {
                WaveFileReader reader = new WaveFileReader(file.FullName);
                TimeSpan span = reader.TotalTime;
                total += span;
                reader.Dispose();
            }                       
            return total;
        }
        private TimeSpan GetAudioFileTime(string filePath) {
            WaveFileReader reader = new WaveFileReader(filePath);
            TimeSpan duration = reader.TotalTime;
            reader.Dispose();
            return duration;
        }
        private void UpdateTotalTimeLabel() {
            TimeSpan totalAudio = GetTotalAudioTime(audioDir);
            if (totalAudio != TimeSpan.Zero)
                lblAudioTime.Text = string.Format("Total audio time: {0}.{1:D3}", totalAudio.ToString().Substring(0, 8), totalAudio.Milliseconds);
            else
                lblAudioTime.Text = "Total audio time: 00:00:00.000";
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void btnRecord_Click(object sender, EventArgs e) {

        }
    }
}
