namespace SphinxCorporaMaker.Forms {
    partial class usrAutomatedAudio2Text {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.opnAudioAuto = new System.Windows.Forms.OpenFileDialog();
            this.lblTitleAutomated = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAudioFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlayAudio = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnOpenAutomated = new System.Windows.Forms.Button();
            this.txtChoosAudioAutomated = new System.Windows.Forms.TextBox();
            this.pnlContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleAutomated
            // 
            this.lblTitleAutomated.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitleAutomated.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleAutomated.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAutomated.ForeColor = System.Drawing.Color.White;
            this.lblTitleAutomated.Location = new System.Drawing.Point(5, 0);
            this.lblTitleAutomated.Name = "lblTitleAutomated";
            this.lblTitleAutomated.Size = new System.Drawing.Size(690, 25);
            this.lblTitleAutomated.TabIndex = 5;
            this.lblTitleAutomated.Text = "Automated Audio to Text Conversion";
            this.lblTitleAutomated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlContainer.Controls.Add(this.groupBox1);
            this.pnlContainer.Controls.Add(this.btnOpenAutomated);
            this.pnlContainer.Controls.Add(this.txtChoosAudioAutomated);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(5, 25);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(690, 490);
            this.pnlContainer.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(9, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 295);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audio Files";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colText,
            this.colAudioFormat,
            this.colPlayAudio});
            this.dataGridView1.Location = new System.Drawing.Point(16, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(641, 232);
            this.dataGridView1.TabIndex = 2;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 40;
            this.colId.Name = "colId";
            this.colId.Width = 70;
            // 
            // colText
            // 
            this.colText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colText.HeaderText = "Text";
            this.colText.MinimumWidth = 250;
            this.colText.Name = "colText";
            // 
            // colAudioFormat
            // 
            this.colAudioFormat.HeaderText = "Format";
            this.colAudioFormat.MinimumWidth = 50;
            this.colAudioFormat.Name = "colAudioFormat";
            this.colAudioFormat.Width = 70;
            // 
            // colPlayAudio
            // 
            this.colPlayAudio.HeaderText = "";
            this.colPlayAudio.Name = "colPlayAudio";
            this.colPlayAudio.Text = "Play";
            // 
            // btnOpenAutomated
            // 
            this.btnOpenAutomated.Location = new System.Drawing.Point(246, 67);
            this.btnOpenAutomated.Name = "btnOpenAutomated";
            this.btnOpenAutomated.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAutomated.TabIndex = 6;
            this.btnOpenAutomated.Text = "Open";
            this.btnOpenAutomated.UseVisualStyleBackColor = true;
            // 
            // txtChoosAudioAutomated
            // 
            this.txtChoosAudioAutomated.Location = new System.Drawing.Point(9, 69);
            this.txtChoosAudioAutomated.Name = "txtChoosAudioAutomated";
            this.txtChoosAudioAutomated.Size = new System.Drawing.Size(231, 20);
            this.txtChoosAudioAutomated.TabIndex = 5;
            this.txtChoosAudioAutomated.Text = "Select audio file(s)...";
            // 
            // usrAutomatedAudio2Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblTitleAutomated);
            this.Name = "usrAutomatedAudio2Text";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Size = new System.Drawing.Size(700, 520);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog opnAudioAuto;
        private System.Windows.Forms.Label lblTitleAutomated;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAudioFormat;
        private System.Windows.Forms.DataGridViewButtonColumn colPlayAudio;
        private System.Windows.Forms.Button btnOpenAutomated;
        private System.Windows.Forms.TextBox txtChoosAudioAutomated;
    }
}
