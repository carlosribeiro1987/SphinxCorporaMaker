namespace SphinxCorporaMaker.UserControls {
    partial class usrTypeText {
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRawText = new System.Windows.Forms.TextBox();
            this.menTypeText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menChangeFont = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.fntChangeFont = new System.Windows.Forms.FontDialog();
            this.opnOpenText = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.menTypeText.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRawText);
            this.groupBox2.Controls.Add(this.txtFilePath);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 500);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type/paste the text or open a text file";
            // 
            // txtRawText
            // 
            this.txtRawText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRawText.ContextMenuStrip = this.menTypeText;
            this.txtRawText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawText.Location = new System.Drawing.Point(10, 50);
            this.txtRawText.Multiline = true;
            this.txtRawText.Name = "txtRawText";
            this.txtRawText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRawText.Size = new System.Drawing.Size(665, 438);
            this.txtRawText.TabIndex = 2;
            this.txtRawText.TextChanged += new System.EventHandler(this.txtRawText_TextChanged);
            // 
            // menTypeText
            // 
            this.menTypeText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menChangeFont});
            this.menTypeText.Name = "menTypeText";
            this.menTypeText.Size = new System.Drawing.Size(143, 26);
            // 
            // menChangeFont
            // 
            this.menChangeFont.Name = "menChangeFont";
            this.menChangeFont.Size = new System.Drawing.Size(142, 22);
            this.menChangeFont.Text = "Change Font";
            this.menChangeFont.Click += new System.EventHandler(this.menChangeFont_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(10, 24);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(515, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(531, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(144, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // opnOpenText
            // 
            this.opnOpenText.FileName = "openFileDialog1";
            this.opnOpenText.Filter = "Text files (*.txt) | *.txt";
            // 
            // usrTypeText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.groupBox2);
            this.Name = "usrTypeText";
            this.Size = new System.Drawing.Size(685, 500);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menTypeText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRawText;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ContextMenuStrip menTypeText;
        private System.Windows.Forms.ToolStripMenuItem menChangeFont;
        private System.Windows.Forms.FontDialog fntChangeFont;
        private System.Windows.Forms.OpenFileDialog opnOpenText;
    }
}
