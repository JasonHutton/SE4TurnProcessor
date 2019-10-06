namespace SE4TurnProcessor
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
            this.txtBinPath = new System.Windows.Forms.TextBox();
            this.lblBinPath = new System.Windows.Forms.Label();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1Label = new System.Windows.Forms.TextBox();
            this.cb1Ready = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cb2Ready = new System.Windows.Forms.CheckBox();
            this.txt2Label = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGames = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBinPath
            // 
            this.txtBinPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinPath.Location = new System.Drawing.Point(70, 8);
            this.txtBinPath.Name = "txtBinPath";
            this.txtBinPath.Size = new System.Drawing.Size(703, 20);
            this.txtBinPath.TabIndex = 0;
            this.txtBinPath.TextChanged += new System.EventHandler(this.txtBinPath_TextChanged);
            // 
            // lblBinPath
            // 
            this.lblBinPath.AutoSize = true;
            this.lblBinPath.Location = new System.Drawing.Point(7, 11);
            this.lblBinPath.Name = "lblBinPath";
            this.lblBinPath.Size = new System.Drawing.Size(61, 13);
            this.lblBinPath.TabIndex = 1;
            this.lblBinPath.Text = "Binary Path";
            // 
            // lblSavePath
            // 
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.Location = new System.Drawing.Point(7, 38);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(57, 13);
            this.lblSavePath.TabIndex = 2;
            this.lblSavePath.Text = "Save Path";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtSavePath);
            this.panel1.Controls.Add(this.lblBinPath);
            this.panel1.Controls.Add(this.txtBinPath);
            this.panel1.Controls.Add(this.lblSavePath);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 67);
            this.panel1.TabIndex = 4;
            // 
            // txtSavePath
            // 
            this.txtSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSavePath.Location = new System.Drawing.Point(70, 35);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(703, 20);
            this.txtSavePath.TabIndex = 3;
            this.txtSavePath.TextChanged += new System.EventHandler(this.txtSavePath_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.cmbGames);
            this.panel2.Location = new System.Drawing.Point(13, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 38);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 308);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cb1Ready);
            this.panel4.Controls.Add(this.txt1Label);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(10, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(763, 34);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // txt1Label
            // 
            this.txt1Label.Location = new System.Drawing.Point(24, 4);
            this.txt1Label.Name = "txt1Label";
            this.txt1Label.Size = new System.Drawing.Size(239, 20);
            this.txt1Label.TabIndex = 1;
            this.txt1Label.TextChanged += new System.EventHandler(this.txt1Label_TextChanged);
            // 
            // cb1Ready
            // 
            this.cb1Ready.AutoSize = true;
            this.cb1Ready.Enabled = false;
            this.cb1Ready.Location = new System.Drawing.Point(269, 7);
            this.cb1Ready.Name = "cb1Ready";
            this.cb1Ready.Size = new System.Drawing.Size(88, 17);
            this.cb1Ready.TabIndex = 2;
            this.cb1Ready.Text = "Turn Ready?";
            this.cb1Ready.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cb2Ready);
            this.panel5.Controls.Add(this.txt2Label);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(10, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(763, 34);
            this.panel5.TabIndex = 3;
            // 
            // cb2Ready
            // 
            this.cb2Ready.AutoSize = true;
            this.cb2Ready.Enabled = false;
            this.cb2Ready.Location = new System.Drawing.Point(269, 7);
            this.cb2Ready.Name = "cb2Ready";
            this.cb2Ready.Size = new System.Drawing.Size(88, 17);
            this.cb2Ready.TabIndex = 2;
            this.cb2Ready.Text = "Turn Ready?";
            this.cb2Ready.UseVisualStyleBackColor = true;
            // 
            // txt2Label
            // 
            this.txt2Label.Location = new System.Drawing.Point(24, 4);
            this.txt2Label.Name = "txt2Label";
            this.txt2Label.Size = new System.Drawing.Size(239, 20);
            this.txt2Label.TabIndex = 1;
            this.txt2Label.TextChanged += new System.EventHandler(this.txt2Label_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "2";
            // 
            // cmbGames
            // 
            this.cmbGames.FormattingEnabled = true;
            this.cmbGames.Location = new System.Drawing.Point(9, 4);
            this.cmbGames.Name = "cmbGames";
            this.cmbGames.Size = new System.Drawing.Size(357, 21);
            this.cmbGames.TabIndex = 0;
            this.cmbGames.SelectedIndexChanged += new System.EventHandler(this.cmbGames_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "SE4 Turn Processor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBinPath;
        private System.Windows.Forms.Label lblBinPath;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox cb2Ready;
        private System.Windows.Forms.TextBox txt2Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cb1Ready;
        private System.Windows.Forms.TextBox txt1Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGames;
    }
}

