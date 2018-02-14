using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SphinxCorporaMaker.Forms;

namespace SphinxCorporaMaker.UserControls {
    public partial class usrTypeText : UserControl {
        public event EventHandler _textChanged;
        string currentText = string.Empty;
        public usrTypeText() {
            InitializeComponent();
        }

        private void menChangeFont_Click(object sender, EventArgs e) {
            if (fntChangeFont.ShowDialog() == DialogResult.OK) {
                txtRawText.Font = fntChangeFont.Font;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            if (opnOpenText.ShowDialog() == DialogResult.OK) {
                txtFilePath.Text = opnOpenText.FileName;
                if (File.Exists(opnOpenText.FileName)) {
                    txtRawText.Clear();
                    using (StreamReader reader = new StreamReader(opnOpenText.FileName, Encoding.Default, true)) {

                        txtRawText.Text = reader.ReadToEnd();
                       
                    }
                }
                currentText = txtRawText.Text;
            }
        }



        public string CurrentText {
            get {
                currentText = txtRawText.Text;
                //currentText.Replace()
                return currentText;
            }
        }

        private void txtRawText_TextChanged(object sender, EventArgs e) {
            if(_textChanged != null) {
                _textChanged(this, e);
            }
        }
    }
}
