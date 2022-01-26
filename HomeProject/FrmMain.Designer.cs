namespace HomeProject
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("UserProfile");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ShoppingItems");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("MyInventory");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("StatisticsAndCharts");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("HomeProject", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelApp = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDisplyName = new System.Windows.Forms.Label();
            this.panelNavitagion = new System.Windows.Forms.Panel();
            this.treeViewNavgation = new System.Windows.Forms.TreeView();
            this.imagListNavigation = new System.Windows.Forms.ImageList(this.components);
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelNavitagion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BackgroundImage = global::HomeProject.Properties.Resources.pngtree_an_abstract_background_perfect_for_any_project_you_might_have_image_3106051;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(804, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.RosyBrown;
            this.lblLogo.Location = new System.Drawing.Point(36, 29);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(105, 19);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "HomeProject";
            // 
            // panelApp
            // 
            this.panelApp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelApp.BackgroundImage = global::HomeProject.Properties.Resources.pngtree_an_abstract_background_perfect_for_any_project_you_might_have_image_310605;
            this.panelApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelApp.Controls.Add(this.btnExit);
            this.panelApp.Controls.Add(this.pictureBox1);
            this.panelApp.Controls.Add(this.lblDisplyName);
            this.panelApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelApp.Location = new System.Drawing.Point(0, 100);
            this.panelApp.Name = "panelApp";
            this.panelApp.Size = new System.Drawing.Size(804, 100);
            this.panelApp.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(716, 59);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeProject.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(11, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblDisplyName
            // 
            this.lblDisplyName.AutoSize = true;
            this.lblDisplyName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplyName.Location = new System.Drawing.Point(117, 40);
            this.lblDisplyName.Name = "lblDisplyName";
            this.lblDisplyName.Size = new System.Drawing.Size(188, 19);
            this.lblDisplyName.TabIndex = 0;
            this.lblDisplyName.Text = "AbdulrahmanMahmoud";
            this.lblDisplyName.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelNavitagion
            // 
            this.panelNavitagion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelNavitagion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavitagion.Controls.Add(this.treeViewNavgation);
            this.panelNavitagion.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavitagion.Location = new System.Drawing.Point(0, 200);
            this.panelNavitagion.Name = "panelNavitagion";
            this.panelNavitagion.Size = new System.Drawing.Size(214, 218);
            this.panelNavitagion.TabIndex = 2;
            // 
            // treeViewNavgation
            // 
            this.treeViewNavgation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.treeViewNavgation.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewNavgation.HotTracking = true;
            this.treeViewNavgation.ImageIndex = 0;
            this.treeViewNavgation.ImageList = this.imagListNavigation;
            this.treeViewNavgation.Location = new System.Drawing.Point(0, 0);
            this.treeViewNavgation.Name = "treeViewNavgation";
            treeNode6.ImageKey = "download.png";
            treeNode6.Name = "NodeUserProfile";
            treeNode6.SelectedImageKey = "Cheek.png";
            treeNode6.Text = "UserProfile";
            treeNode7.ImageKey = "شوبينق.jpg";
            treeNode7.Name = "NodeShoppingItems";
            treeNode7.SelectedImageKey = "Cheek.png";
            treeNode7.Text = "ShoppingItems";
            treeNode8.ImageKey = "SHOPING 2.jpg";
            treeNode8.Name = "NodeMyInventory";
            treeNode8.SelectedImageKey = "Cheek.png";
            treeNode8.Text = "MyInventory";
            treeNode9.ImageKey = "احصائيات.png";
            treeNode9.Name = "NodeStatisticsAndCharts";
            treeNode9.SelectedImageKey = "Cheek.png";
            treeNode9.Text = "StatisticsAndCharts";
            treeNode10.ImageKey = "Home.png";
            treeNode10.Name = "NodeRoot";
            treeNode10.Text = "HomeProject";
            this.treeViewNavgation.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeViewNavgation.SelectedImageIndex = 0;
            this.treeViewNavgation.Size = new System.Drawing.Size(213, 216);
            this.treeViewNavgation.TabIndex = 0;
            this.treeViewNavgation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewNavgation_AfterSelect);
            // 
            // imagListNavigation
            // 
            this.imagListNavigation.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagListNavigation.ImageStream")));
            this.imagListNavigation.TransparentColor = System.Drawing.Color.Transparent;
            this.imagListNavigation.Images.SetKeyName(0, "Home.png");
            this.imagListNavigation.Images.SetKeyName(1, "download.png");
            this.imagListNavigation.Images.SetKeyName(2, "شوبينق.jpg");
            this.imagListNavigation.Images.SetKeyName(3, "SHOPING 2.jpg");
            this.imagListNavigation.Images.SetKeyName(4, "احصائيات.png");
            this.imagListNavigation.Images.SetKeyName(5, "Cheek.png");
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContent.BackgroundImage = global::HomeProject.Properties.Resources.pngtree_an_abstract_background_perfect_for_any_project_you_might_have_image_310605;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(214, 200);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(590, 218);
            this.panelContent.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HomeProject.Properties.Resources.pngtree_an_abstract_background_perfect_for_any_project_you_might_have_image_310605;
            this.ClientSize = new System.Drawing.Size(804, 418);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelNavitagion);
            this.Controls.Add(this.panelApp);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMain";
            this.Text = "HomeProject";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelApp.ResumeLayout(false);
            this.panelApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelNavitagion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelApp;
        private System.Windows.Forms.Panel panelNavitagion;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDisplyName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TreeView treeViewNavgation;
        private System.Windows.Forms.ImageList imagListNavigation;
    }
}