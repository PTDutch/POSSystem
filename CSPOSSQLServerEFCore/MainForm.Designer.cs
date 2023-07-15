namespace CSPOSSQLServerEFCore
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            userManagementToolStripMenuItem = new ToolStripMenuItem();
            productManagementToolStripMenuItem = new ToolStripMenuItem();
            pointOfSaleSystemToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            aboutApplicationToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            userManagementToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            productManagementToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            pointOfSaleToolStripButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            logoutToolStripButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            exitToolStripButton = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1093, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userManagementToolStripMenuItem, productManagementToolStripMenuItem, pointOfSaleSystemToolStripMenuItem, logOutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // userManagementToolStripMenuItem
            // 
            userManagementToolStripMenuItem.Image = Properties.Resources.Graphicloads_Business_Profile_512;
            userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            userManagementToolStripMenuItem.Size = new Size(235, 26);
            userManagementToolStripMenuItem.Text = "User Management";
            userManagementToolStripMenuItem.Click += userManagementToolStripMenuItem_Click;
            // 
            // productManagementToolStripMenuItem
            // 
            productManagementToolStripMenuItem.Image = Properties.Resources.Dtafalonso_Android_Lollipop_Aptoide_512;
            productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
            productManagementToolStripMenuItem.Size = new Size(235, 26);
            productManagementToolStripMenuItem.Text = "Product Management";
            productManagementToolStripMenuItem.Click += productManagementToolStripMenuItem_Click;
            // 
            // pointOfSaleSystemToolStripMenuItem
            // 
            pointOfSaleSystemToolStripMenuItem.Image = Properties.Resources.AnyConv_com__Graphicloads_Flat_Finance_Statistics_market_256;
            pointOfSaleSystemToolStripMenuItem.Name = "pointOfSaleSystemToolStripMenuItem";
            pointOfSaleSystemToolStripMenuItem.Size = new Size(235, 26);
            pointOfSaleSystemToolStripMenuItem.Text = "Point Of Sale System";
            pointOfSaleSystemToolStripMenuItem.Click += pointOfSaleSystemToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Image = Properties.Resources.AnyConv_com__Papirus_Team_Papirus_Apps_Android_file_transfer_512;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(235, 26);
            logOutToolStripMenuItem.Text = "Log-Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.AnyConv_com__Everaldo_Crystal_Clear_Action_exit_128;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(235, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aboutApplicationToolStripMenuItem });
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(64, 24);
            aboutToolStripMenuItem1.Text = "About";
            // 
            // aboutApplicationToolStripMenuItem
            // 
            aboutApplicationToolStripMenuItem.Image = Properties.Resources.AnyConv_com__Oxygen_Icons_org_Oxygen_Actions_help_about_256;
            aboutApplicationToolStripMenuItem.Name = "aboutApplicationToolStripMenuItem";
            aboutApplicationToolStripMenuItem.Size = new Size(214, 26);
            aboutApplicationToolStripMenuItem.Text = "About Application";
            aboutApplicationToolStripMenuItem.Click += aboutApplicationToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 580);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1093, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.ForeColor = Color.Chocolate;
            toolStripStatusLabel1.Image = Properties.Resources.AnyConv_com__Graphicloads_Flat_Finance_Statistics_market_256;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(72, 20);
            toolStripStatusLabel1.Text = "status";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Right;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { userManagementToolStripButton, toolStripSeparator1, productManagementToolStripButton, toolStripSeparator2, pointOfSaleToolStripButton, toolStripSeparator3, logoutToolStripButton, toolStripSeparator4, exitToolStripButton, toolStripSeparator5 });
            toolStrip1.Location = new Point(914, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(179, 552);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // userManagementToolStripButton
            // 
            userManagementToolStripButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            userManagementToolStripButton.Image = Properties.Resources.Graphicloads_Business_Profile_64;
            userManagementToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            userManagementToolStripButton.ImageTransparentColor = Color.Magenta;
            userManagementToolStripButton.Name = "userManagementToolStripButton";
            userManagementToolStripButton.Padding = new Padding(5);
            userManagementToolStripButton.Size = new Size(176, 97);
            userManagementToolStripButton.Text = "User Management";
            userManagementToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            userManagementToolStripButton.Click += userManagementToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(176, 6);
            // 
            // productManagementToolStripButton
            // 
            productManagementToolStripButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            productManagementToolStripButton.Image = Properties.Resources.Dtafalonso_Android_Lollipop_Aptoide_64;
            productManagementToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            productManagementToolStripButton.ImageTransparentColor = Color.Magenta;
            productManagementToolStripButton.Name = "productManagementToolStripButton";
            productManagementToolStripButton.Padding = new Padding(5);
            productManagementToolStripButton.Size = new Size(176, 97);
            productManagementToolStripButton.Text = "Product Management";
            productManagementToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            productManagementToolStripButton.Click += productManagementToolStripButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(176, 6);
            // 
            // pointOfSaleToolStripButton
            // 
            pointOfSaleToolStripButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            pointOfSaleToolStripButton.Image = Properties.Resources.Graphicloads_Flat_Finance_Statistics_market_64;
            pointOfSaleToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            pointOfSaleToolStripButton.ImageTransparentColor = Color.Magenta;
            pointOfSaleToolStripButton.Name = "pointOfSaleToolStripButton";
            pointOfSaleToolStripButton.Padding = new Padding(5);
            pointOfSaleToolStripButton.Size = new Size(176, 97);
            pointOfSaleToolStripButton.Text = "Point Of Sale (POS)";
            pointOfSaleToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            pointOfSaleToolStripButton.Click += pointOfSaleToolStripButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(176, 6);
            // 
            // logoutToolStripButton
            // 
            logoutToolStripButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            logoutToolStripButton.Image = Properties.Resources.Papirus_Team_Papirus_Apps_Android_file_transfer1;
            logoutToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            logoutToolStripButton.ImageTransparentColor = Color.Magenta;
            logoutToolStripButton.Name = "logoutToolStripButton";
            logoutToolStripButton.Padding = new Padding(5);
            logoutToolStripButton.Size = new Size(176, 97);
            logoutToolStripButton.Text = "Log-Out";
            logoutToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            logoutToolStripButton.Click += logoutToolStripButton_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(176, 6);
            // 
            // exitToolStripButton
            // 
            exitToolStripButton.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            exitToolStripButton.Image = Properties.Resources.Everaldo_Crystal_Clear_Action_exit_64;
            exitToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripButton.ImageTransparentColor = Color.Magenta;
            exitToolStripButton.Name = "exitToolStripButton";
            exitToolStripButton.Padding = new Padding(5);
            exitToolStripButton.Size = new Size(82, 97);
            exitToolStripButton.Text = "Exit App";
            exitToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            exitToolStripButton.Click += exitToolStripButton_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(176, 6);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 606);
            ControlBox = false;
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visual Studio 2022 : c# & SQL Server With EF Core 6.0 : POS System : Dutcheang";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem userManagementToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem aboutApplicationToolStripMenuItem;
        private ToolStripMenuItem productManagementToolStripMenuItem;
        private ToolStripMenuItem pointOfSaleSystemToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStrip toolStrip1;
        private ToolStripButton userManagementToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton productManagementToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton pointOfSaleToolStripButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton logoutToolStripButton;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton exitToolStripButton;
        private ToolStripSeparator toolStripSeparator5;
    }
}