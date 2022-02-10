
namespace Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnHome = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBack = new System.Windows.Forms.ToolStripButton();
            this.tsBtnForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnGO = new System.Windows.Forms.ToolStripButton();
            this.labelKeywords = new System.Windows.Forms.ToolStripLabel();
            this.cmbBox = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dissconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewKeywordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(800, 450);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnHome,
            this.tsBtnBack,
            this.tsBtnForward,
            this.toolStripTextBox1,
            this.tsBtnGO,
            this.labelKeywords,
            this.cmbBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnHome
            // 
            this.tsBtnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnHome.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnHome.Image")));
            this.tsBtnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnHome.Name = "tsBtnHome";
            this.tsBtnHome.Size = new System.Drawing.Size(29, 25);
            this.tsBtnHome.Text = "Home";
            this.tsBtnHome.Click += new System.EventHandler(this.tsBtnHome_Click);
            // 
            // tsBtnBack
            // 
            this.tsBtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBack.Image")));
            this.tsBtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBack.Name = "tsBtnBack";
            this.tsBtnBack.Size = new System.Drawing.Size(29, 25);
            this.tsBtnBack.Text = "Back";
            this.tsBtnBack.Click += new System.EventHandler(this.tsBtnBack_Click);
            // 
            // tsBtnForward
            // 
            this.tsBtnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnForward.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnForward.Image")));
            this.tsBtnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnForward.Name = "tsBtnForward";
            this.tsBtnForward.Size = new System.Drawing.Size(29, 25);
            this.tsBtnForward.Text = "Forward";
            this.tsBtnForward.Click += new System.EventHandler(this.tsBtnForward_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(300, 28);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // tsBtnGO
            // 
            this.tsBtnGO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnGO.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnGO.Image")));
            this.tsBtnGO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnGO.Name = "tsBtnGO";
            this.tsBtnGO.Size = new System.Drawing.Size(29, 25);
            this.tsBtnGO.Text = "Navigate";
            this.tsBtnGO.Click += new System.EventHandler(this.tsBtnGO_Click);
            // 
            // labelKeywords
            // 
            this.labelKeywords.Name = "labelKeywords";
            this.labelKeywords.Size = new System.Drawing.Size(131, 25);
            this.labelKeywords.Text = "Blocked keywords:";
            // 
            // cmbBox
            // 
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(121, 28);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.dissconnectToolStripMenuItem,
            this.addToolStripMenuItem,
            this.viewKeywordsToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // dissconnectToolStripMenuItem
            // 
            this.dissconnectToolStripMenuItem.Name = "dissconnectToolStripMenuItem";
            this.dissconnectToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.dissconnectToolStripMenuItem.Text = "Disconnect";
            this.dissconnectToolStripMenuItem.Click += new System.EventHandler(this.dissconnectToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.addToolStripMenuItem.Text = "AddKeyword";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // viewKeywordsToolStripMenuItem
            // 
            this.viewKeywordsToolStripMenuItem.Name = "viewKeywordsToolStripMenuItem";
            this.viewKeywordsToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.viewKeywordsToolStripMenuItem.Text = "ViewKeywords";
            this.viewKeywordsToolStripMenuItem.Click += new System.EventHandler(this.viewKeywordsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.webBrowser1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnHome;
        private System.Windows.Forms.ToolStripButton tsBtnBack;
        private System.Windows.Forms.ToolStripButton tsBtnForward;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton tsBtnGO;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dissconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewKeywordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cmbBox;
        private System.Windows.Forms.ToolStripLabel labelKeywords;
    }
}

