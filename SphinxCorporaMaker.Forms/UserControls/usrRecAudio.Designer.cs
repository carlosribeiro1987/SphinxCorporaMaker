namespace SphinxCorporaMaker.UserControls {
    partial class usrRecAudio {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSentences = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRecord = new System.Windows.Forms.Button();
            this.txtCurrentSentence = new System.Windows.Forms.TextBox();
            this.lblTotalSentences = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentences)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalSentences);
            this.groupBox1.Controls.Add(this.dgvSentences);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record audio for the sentences";
            // 
            // dgvSentences
            // 
            this.dgvSentences.AllowUserToAddRows = false;
            this.dgvSentences.AllowUserToDeleteRows = false;
            this.dgvSentences.AllowUserToResizeRows = false;
            this.dgvSentences.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvSentences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSentences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colText});
            this.dgvSentences.Location = new System.Drawing.Point(13, 20);
            this.dgvSentences.MultiSelect = false;
            this.dgvSentences.Name = "dgvSentences";
            this.dgvSentences.RowHeadersVisible = false;
            this.dgvSentences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSentences.Size = new System.Drawing.Size(660, 252);
            this.dgvSentences.TabIndex = 0;
            this.dgvSentences.SelectionChanged += new System.EventHandler(this.dgvSentences_SelectionChanged);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.Width = 80;
            // 
            // colText
            // 
            this.colText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colText.HeaderText = "Text";
            this.colText.Name = "colText";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.btnRecord);
            this.groupBox2.Controls.Add(this.txtCurrentSentence);
            this.groupBox2.Location = new System.Drawing.Point(0, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Click \"Record\" button then read the sentence";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 78);
            this.panel1.TabIndex = 5;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(578, 147);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(95, 28);
            this.btnRecord.TabIndex = 4;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // txtCurrentSentence
            // 
            this.txtCurrentSentence.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentSentence.ForeColor = System.Drawing.Color.Navy;
            this.txtCurrentSentence.Location = new System.Drawing.Point(13, 19);
            this.txtCurrentSentence.Multiline = true;
            this.txtCurrentSentence.Name = "txtCurrentSentence";
            this.txtCurrentSentence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCurrentSentence.Size = new System.Drawing.Size(660, 72);
            this.txtCurrentSentence.TabIndex = 3;
            this.txtCurrentSentence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalSentences
            // 
            this.lblTotalSentences.AutoSize = true;
            this.lblTotalSentences.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSentences.Location = new System.Drawing.Point(10, 275);
            this.lblTotalSentences.Name = "lblTotalSentences";
            this.lblTotalSentences.Size = new System.Drawing.Size(103, 17);
            this.lblTotalSentences.TabIndex = 1;
            this.lblTotalSentences.Text = "0000 sentences.";
            // 
            // usrRecAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "usrRecAudio";
            this.Size = new System.Drawing.Size(685, 500);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentences)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSentences;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCurrentSentence;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label lblTotalSentences;
    }
}
