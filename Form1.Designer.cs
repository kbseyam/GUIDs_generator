namespace GUID_Gen {
    partial class Form1 {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.LbGUID = new System.Windows.Forms.Label();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.TabsControl = new System.Windows.Forms.TabControl();
            this.TabText = new System.Windows.Forms.TabPage();
            this.TabToFile = new System.Windows.Forms.TabPage();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.NumUpDownOfGUID = new System.Windows.Forms.NumericUpDown();
            this.BtnGenerateToFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TabsControl.SuspendLayout();
            this.TabText.SuspendLayout();
            this.TabToFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownOfGUID)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnGenerate.Location = new System.Drawing.Point(14, 29);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(133, 43);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // LbGUID
            // 
            this.LbGUID.AutoSize = true;
            this.LbGUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGUID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LbGUID.Location = new System.Drawing.Point(8, 103);
            this.LbGUID.Name = "LbGUID";
            this.LbGUID.Size = new System.Drawing.Size(559, 33);
            this.LbGUID.TabIndex = 2;
            this.LbGUID.Text = "4dda0fe4-5477-4d1b-bb78-528d9bd0a744";
            // 
            // BtnCopy
            // 
            this.BtnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCopy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnCopy.Location = new System.Drawing.Point(454, 29);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(113, 43);
            this.BtnCopy.TabIndex = 3;
            this.BtnCopy.Text = "Copy";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // TabsControl
            // 
            this.TabsControl.Controls.Add(this.TabText);
            this.TabsControl.Controls.Add(this.TabToFile);
            this.TabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsControl.Location = new System.Drawing.Point(0, 0);
            this.TabsControl.Name = "TabsControl";
            this.TabsControl.SelectedIndex = 0;
            this.TabsControl.Size = new System.Drawing.Size(614, 209);
            this.TabsControl.TabIndex = 4;
            // 
            // TabText
            // 
            this.TabText.Controls.Add(this.BtnCopy);
            this.TabText.Controls.Add(this.BtnGenerate);
            this.TabText.Controls.Add(this.LbGUID);
            this.TabText.Location = new System.Drawing.Point(4, 22);
            this.TabText.Name = "TabText";
            this.TabText.Padding = new System.Windows.Forms.Padding(3);
            this.TabText.Size = new System.Drawing.Size(606, 183);
            this.TabText.TabIndex = 0;
            this.TabText.Text = "Text";
            this.TabText.UseVisualStyleBackColor = true;
            // 
            // TabToFile
            // 
            this.TabToFile.Controls.Add(this.label1);
            this.TabToFile.Controls.Add(this.BtnGenerateToFile);
            this.TabToFile.Controls.Add(this.NumUpDownOfGUID);
            this.TabToFile.Location = new System.Drawing.Point(4, 22);
            this.TabToFile.Name = "TabToFile";
            this.TabToFile.Padding = new System.Windows.Forms.Padding(3);
            this.TabToFile.Size = new System.Drawing.Size(606, 183);
            this.TabToFile.TabIndex = 1;
            this.TabToFile.Text = "To file";
            this.TabToFile.UseVisualStyleBackColor = true;
            // 
            // NumUpDownOfGUID
            // 
            this.NumUpDownOfGUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUpDownOfGUID.Location = new System.Drawing.Point(196, 20);
            this.NumUpDownOfGUID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumUpDownOfGUID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDownOfGUID.Name = "NumUpDownOfGUID";
            this.NumUpDownOfGUID.Size = new System.Drawing.Size(150, 29);
            this.NumUpDownOfGUID.TabIndex = 0;
            this.NumUpDownOfGUID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnGenerateToFile
            // 
            this.BtnGenerateToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerateToFile.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnGenerateToFile.Location = new System.Drawing.Point(13, 69);
            this.BtnGenerateToFile.Name = "BtnGenerateToFile";
            this.BtnGenerateToFile.Size = new System.Drawing.Size(157, 53);
            this.BtnGenerateToFile.TabIndex = 1;
            this.BtnGenerateToFile.Text = "Generate";
            this.BtnGenerateToFile.UseVisualStyleBackColor = true;
            this.BtnGenerateToFile.Click += new System.EventHandler(this.BtnGenerateToFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "number of GUIDs:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 209);
            this.Controls.Add(this.TabsControl);
            this.Name = "Form1";
            this.Text = "GUIDs generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabsControl.ResumeLayout(false);
            this.TabText.ResumeLayout(false);
            this.TabText.PerformLayout();
            this.TabToFile.ResumeLayout(false);
            this.TabToFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownOfGUID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Label LbGUID;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.TabControl TabsControl;
        private System.Windows.Forms.TabPage TabText;
        private System.Windows.Forms.TabPage TabToFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown NumUpDownOfGUID;
        private System.Windows.Forms.Button BtnGenerateToFile;
        private System.Windows.Forms.Label label1;
    }
}

