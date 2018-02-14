using SphinxCorporaMaker.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SphinxCorporaMaker.Forms {
    public partial class frmRecAudio4Text : Form {
        private byte step = 0;
        public string openText;
        usrTypeText step01 = new usrTypeText();
        usrRecAudio step02 = new usrRecAudio();
        public frmRecAudio4Text() {
            InitializeComponent();
            step01._textChanged += SentencesChanged;
        }

        private void frmRecAudio4Text_Load(object sender, EventArgs e) {
            btnNext.Enabled = false;
            Steps();
        }

        private void btnNext_Click(object sender, EventArgs e) {
            Steps();
        }

        private void Steps() {
            
            switch (step) {
                case 0:                    
                    step01.Dock = DockStyle.Fill;                    
                    pnlBack.Controls.Add(step01);
                    step = 1;
                    break;
                case 1:
                    openText = step01.CurrentText;
                    step02.Dock = DockStyle.Fill;                    
                    pnlBack.Controls.Remove(step01);
                    pnlBack.Controls.Add(step02);
                    step02.AddSentences(step01.CurrentText);
                    step = 2;
                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
        }

        public void SentencesChanged(object sender, EventArgs e) {
            btnNext.Enabled = !string.IsNullOrWhiteSpace(step01.CurrentText);
        }

        public byte CurrentStep {
            get { return step; }
            set { step = value; }
        }


    }
}
