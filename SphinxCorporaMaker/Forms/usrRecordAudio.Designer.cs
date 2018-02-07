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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.opnAudioAuto = new System.Windows.Forms.OpenFileDialog();
            this.lblTitleAutomated = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAudioFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecAudio = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colPlayAudio = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(9, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 197);
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
            this.colRecAudio,
            this.colPlayAudio});
            this.dataGridView1.Location = new System.Drawing.Point(16, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(641, 159);
            this.dataGridView1.TabIndex = 2;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(9, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 202);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type/paste the text or open a text file";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(419, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 50);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(647, 119);
            this.textBox2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Generate Sentences";
            this.button2.UseVisualStyleBackColor = true;
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
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog opnAudioAuto;
        private System.Windows.Forms.Label lblTitleAutomated;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAudioFormat;
        private System.Windows.Forms.DataGridViewButtonColumn colRecAudio;
        private System.Windows.Forms.DataGridViewButtonColumn colPlayAudio;
    }
}
