namespace ProxySwitcher
{
    partial class SettingsBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsBox));
            this.proxyUrlLabel = new System.Windows.Forms.Label();
            this.proxyPortLabel = new System.Windows.Forms.Label();
            this.proxyUrlTxt = new System.Windows.Forms.TextBox();
            this.proxyPortTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // proxyUrlLabel
            // 
            this.proxyUrlLabel.AutoSize = true;
            this.proxyUrlLabel.Location = new System.Drawing.Point(12, 9);
            this.proxyUrlLabel.Name = "proxyUrlLabel";
            this.proxyUrlLabel.Size = new System.Drawing.Size(46, 13);
            this.proxyUrlLabel.TabIndex = 0;
            this.proxyUrlLabel.Text = "ProxyUrl";
            // 
            // proxyPortLabel
            // 
            this.proxyPortLabel.AutoSize = true;
            this.proxyPortLabel.Location = new System.Drawing.Point(12, 48);
            this.proxyPortLabel.Name = "proxyPortLabel";
            this.proxyPortLabel.Size = new System.Drawing.Size(52, 13);
            this.proxyPortLabel.TabIndex = 1;
            this.proxyPortLabel.Text = "ProxyPort";
            // 
            // proxyUrlTxt
            // 
            this.proxyUrlTxt.Location = new System.Drawing.Point(88, 6);
            this.proxyUrlTxt.Name = "proxyUrlTxt";
            this.proxyUrlTxt.Size = new System.Drawing.Size(100, 20);
            this.proxyUrlTxt.TabIndex = 2;
            // 
            // proxyPortTxt
            // 
            this.proxyPortTxt.Location = new System.Drawing.Point(88, 41);
            this.proxyPortTxt.Name = "proxyPortTxt";
            this.proxyPortTxt.Size = new System.Drawing.Size(100, 20);
            this.proxyPortTxt.TabIndex = 3;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(113, 80);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // SettingsBox
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 115);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.proxyPortTxt);
            this.Controls.Add(this.proxyUrlTxt);
            this.Controls.Add(this.proxyPortLabel);
            this.Controls.Add(this.proxyUrlLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsBox";
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label proxyUrlLabel;
        private System.Windows.Forms.Label proxyPortLabel;
        private System.Windows.Forms.TextBox proxyUrlTxt;
        private System.Windows.Forms.TextBox proxyPortTxt;
        private System.Windows.Forms.Button saveBtn;
    }
}