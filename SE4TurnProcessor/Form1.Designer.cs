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
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.txtSavePath);
            this.panel1.Controls.Add(this.lblBinPath);
            this.panel1.Controls.Add(this.txtBinPath);
            this.panel1.Controls.Add(this.lblSavePath);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 100);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBinPath;
        private System.Windows.Forms.Label lblBinPath;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSavePath;
    }
}

