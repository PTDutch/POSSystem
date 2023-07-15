namespace CSPOSSQLServerEFCore
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            youtubeLinkLabel = new LinkLabel();
            facebookLinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(187, 35);
            label1.Name = "label1";
            label1.Size = new Size(571, 62);
            label1.TabIndex = 0;
            label1.Text = "Point Of Sale (POS) 2022";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(392, 140);
            label2.Name = "label2";
            label2.Size = new Size(141, 31);
            label2.TabIndex = 1;
            label2.Text = "Version 1.0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(187, 202);
            label3.Name = "label3";
            label3.Size = new Size(581, 62);
            label3.TabIndex = 2;
            label3.Text = "Developed by Dutcheang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(88, 342);
            label4.Name = "label4";
            label4.Size = new Size(113, 31);
            label4.TabIndex = 3;
            label4.Text = "YouTube :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(80, 393);
            label5.Name = "label5";
            label5.Size = new Size(121, 31);
            label5.TabIndex = 4;
            label5.Text = "Facebook :";
            // 
            // youtubeLinkLabel
            // 
            youtubeLinkLabel.AutoSize = true;
            youtubeLinkLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            youtubeLinkLabel.Location = new Point(238, 346);
            youtubeLinkLabel.Name = "youtubeLinkLabel";
            youtubeLinkLabel.Size = new Size(644, 31);
            youtubeLinkLabel.TabIndex = 5;
            youtubeLinkLabel.TabStop = true;
            youtubeLinkLabel.Text = "https://www.youtube.com/channel/UC0cIbksiIAncvzx30_I2zhA";
            youtubeLinkLabel.LinkClicked += youtubeLinkLabel_LinkClicked;
            // 
            // facebookLinkLabel
            // 
            facebookLinkLabel.AutoSize = true;
            facebookLinkLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            facebookLinkLabel.Location = new Point(238, 393);
            facebookLinkLabel.Name = "facebookLinkLabel";
            facebookLinkLabel.Size = new Size(635, 31);
            facebookLinkLabel.TabIndex = 6;
            facebookLinkLabel.TabStop = true;
            facebookLinkLabel.Text = "https://www.facebook.com/profile.php?id=100004101161438";
            facebookLinkLabel.LinkClicked += facebookLinkLabel_LinkClicked;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 496);
            Controls.Add(facebookLinkLabel);
            Controls.Add(youtubeLinkLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AboutForm";
            Text = "About Form : Dutcheang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel youtubeLinkLabel;
        private LinkLabel facebookLinkLabel;
    }
}