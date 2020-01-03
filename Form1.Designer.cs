namespace Huffman
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTextToCode = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpEncode = new System.Windows.Forms.TabPage();
            this.btnEncode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tpDecode = new System.Windows.Forms.TabPage();
            this.btnDecode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEncodedOutput = new System.Windows.Forms.TextBox();
            this.tbCodedFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodeTable = new System.Windows.Forms.TextBox();
            this.ofdCodeTable = new System.Windows.Forms.OpenFileDialog();
            this.ofdCodedFile = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tpEncode.SuspendLayout();
            this.tpDecode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTextToCode
            // 
            this.tbTextToCode.Location = new System.Drawing.Point(8, 48);
            this.tbTextToCode.Multiline = true;
            this.tbTextToCode.Name = "tbTextToCode";
            this.tbTextToCode.Size = new System.Drawing.Size(387, 175);
            this.tbTextToCode.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpEncode);
            this.tabControl1.Controls.Add(this.tpDecode);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 125);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 403);
            this.tabControl1.TabIndex = 1;
            // 
            // tpEncode
            // 
            this.tpEncode.Controls.Add(this.btnEncode);
            this.tpEncode.Controls.Add(this.label4);
            this.tpEncode.Controls.Add(this.tbTextToCode);
            this.tpEncode.Location = new System.Drawing.Point(4, 22);
            this.tpEncode.Name = "tpEncode";
            this.tpEncode.Padding = new System.Windows.Forms.Padding(3);
            this.tpEncode.Size = new System.Drawing.Size(866, 377);
            this.tpEncode.TabIndex = 0;
            this.tpEncode.Text = "Encode";
            this.tpEncode.UseVisualStyleBackColor = true;
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(447, 48);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.BtnEncode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Text to code";
            // 
            // tpDecode
            // 
            this.tpDecode.Controls.Add(this.btnDecode);
            this.tpDecode.Controls.Add(this.label3);
            this.tpDecode.Controls.Add(this.tbEncodedOutput);
            this.tpDecode.Location = new System.Drawing.Point(4, 22);
            this.tpDecode.Name = "tpDecode";
            this.tpDecode.Padding = new System.Windows.Forms.Padding(3);
            this.tpDecode.Size = new System.Drawing.Size(866, 377);
            this.tpDecode.TabIndex = 1;
            this.tpDecode.Text = "Decode";
            this.tpDecode.UseVisualStyleBackColor = true;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(204, 31);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(147, 34);
            this.btnDecode.TabIndex = 6;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.BtnDecode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Decoded output";
            // 
            // tbEncodedOutput
            // 
            this.tbEncodedOutput.Location = new System.Drawing.Point(12, 95);
            this.tbEncodedOutput.Multiline = true;
            this.tbEncodedOutput.Name = "tbEncodedOutput";
            this.tbEncodedOutput.Size = new System.Drawing.Size(492, 273);
            this.tbEncodedOutput.TabIndex = 4;
            // 
            // tbCodedFile
            // 
            this.tbCodedFile.Location = new System.Drawing.Point(11, 85);
            this.tbCodedFile.Name = "tbCodedFile";
            this.tbCodedFile.Size = new System.Drawing.Size(497, 20);
            this.tbCodedFile.TabIndex = 3;
            this.tbCodedFile.Click += new System.EventHandler(this.TbCodedFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coded file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code table file";
            // 
            // tbCodeTable
            // 
            this.tbCodeTable.Location = new System.Drawing.Point(12, 35);
            this.tbCodeTable.Name = "tbCodeTable";
            this.tbCodeTable.Size = new System.Drawing.Size(494, 20);
            this.tbCodeTable.TabIndex = 0;
            this.tbCodeTable.Click += new System.EventHandler(this.TbCodeTable_Click);
            // 
            // ofdCodeTable
            // 
            this.ofdCodeTable.FileName = "CodeTable.txt";
            this.ofdCodeTable.FileOk += new System.ComponentModel.CancelEventHandler(this.OfdCodeTable_FileOk);
            // 
            // ofdCodedFile
            // 
            this.ofdCodedFile.FileName = "Encoded.bin";
            this.ofdCodedFile.FileOk += new System.ComponentModel.CancelEventHandler(this.OfdCodedFile_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 528);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbCodeTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodedFile);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Huffman coding";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpEncode.ResumeLayout(false);
            this.tpEncode.PerformLayout();
            this.tpDecode.ResumeLayout(false);
            this.tpDecode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTextToCode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpEncode;
        private System.Windows.Forms.TabPage tpDecode;
        private System.Windows.Forms.OpenFileDialog ofdCodeTable;
        private System.Windows.Forms.TextBox tbCodeTable;
        private System.Windows.Forms.TextBox tbCodedFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdCodedFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEncodedOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
    }
}

