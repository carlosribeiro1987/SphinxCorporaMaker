namespace SphinxCorporaMaker.Forms {
    partial class usrRecordAudio {
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtRawText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSentences = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAudioFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecAudio = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colPlayAudio = new System.Windows.Forms.DataGridViewButtonColumn();
            this.opnAudioAuto = new System.Windows.Forms.OpenFileDialog();
            this.lblTitleAutomated = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentences)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlContainer.Controls.Add(this.groupBox2);
            this.pnlContainer.Controls.Add(this.groupBox1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(5, 25);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(690, 490);
            this.pnlContainer.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.txtRawText);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(9, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 202);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type/paste the text or open a text file";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(540, 173);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(123, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate Sentences";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtRawText
            // 
            this.txtRawText.Location = new System.Drawing.Point(16, 50);
            this.txtRawText.Multiline = true;
            this.txtRawText.Name = "txtRawText";
            this.txtRawText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRawText.Size = new System.Drawing.Size(647, 119);
            this.txtRawText.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(419, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSentences);
            this.groupBox1.Location = new System.Drawing.Point(9, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 197);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audio Files";
            // 
            // dgvSentences
            // 
            this.dgvSentences.AllowUserToAddRows = false;
            this.dgvSentences.AllowUserToDeleteRows = false;
            this.dgvSentences.AllowUserToResizeRows = false;
            this.dgvSentences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSentences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colText,
            this.colAudioFormat,
            this.colRecAudio,
            this.colPlayAudio});
            this.dgvSentences.Location = new System.Drawing.Point(16, 19);
            this.dgvSentences.Name = "dgvSentences";
            this.dgvSentences.RowHeadersVisible = false;
            this.dgvSentences.Size = new System.Drawing.Size(641, 159);
            this.dgvSentences.TabIndex = 2;
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
            this.colAudioFormat.HeaderText = "Has Audio?";
            this.colAudioFormat.MinimumWidth = 50;
            this.colAudioFormat.Name = "colAudioFormat";
            // 
            // colRecAudio
            // 
            this.colRecAudio.FillWeight = 40F;
            this.colRecAudio.HeaderText = "Rec";
            this.colRecAudio.MinimumWidth = 16;
            this.colRecAudio.Name = "colRecAudio";
            this.colRecAudio.Width = 32;
            // 
            // colPlayAudio
            // 
            this.colPlayAudio.FillWeight = 40F;
            this.colPlayAudio.HeaderText = "Play";
            this.colPlayAudio.MinimumWidth = 16;
            this.colPlayAudio.Name = "colPlayAudio";
            this.colPlayAudio.Text = "";
            this.colPlayAudio.Width = 32;
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
            this.lblTitleAutomated.TabIndex = 7;
            this.lblTitleAutomated.Text = "Record Audio to Text Sentences";
            this.lblTitleAutomated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usrRecordAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblTitleAutomated);
            this.Name = "usrRecordAudio";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Size = new System.Drawing.Size(700, 520);
            this.pnlContainer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSentences;
        private System.Windows.Forms.OpenFileDialog opnAudioAuto;
        private System.Windows.Forms.Label lblTitleAutomated;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtRawText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAudioFormat;
        private System.Windows.Forms.DataGridViewButtonColumn colRecAudio;
        private System.Windows.Forms.DataGridViewButtonColumn colPlayAudio;
    }
}
