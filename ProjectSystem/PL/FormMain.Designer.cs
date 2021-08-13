namespace ProjectSystem.PL
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.ElpsForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHome = new Bunifu.UI.WinForms.BunifuPanel();
            this.pages = new Bunifu.UI.WinForms.BunifuPages();
            this.pageHome = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pageMeter = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pageCust = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pageRead = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.pageLoc = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.pageBill = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.pageReport = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnLogout = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnSettings = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnRead = new Guna.UI2.WinForms.Guna2Button();
            this.btnCust = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnMeter = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogo1ut = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ucCustomer1 = new ProjectSystem.PL.ucCustomer();
            this.pnlHome.SuspendLayout();
            this.pages.SuspendLayout();
            this.pageHome.SuspendLayout();
            this.pageMeter.SuspendLayout();
            this.pageCust.SuspendLayout();
            this.pageRead.SuspendLayout();
            this.pageLoc.SuspendLayout();
            this.pageBill.SuspendLayout();
            this.pageReport.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElpsForm
            // 
            this.ElpsForm.ElipseRadius = 30;
            this.ElpsForm.TargetControl = this;
            // 
            // pnlHome
            // 
            this.pnlHome.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHome.BackgroundImage")));
            this.pnlHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHome.BorderColor = System.Drawing.Color.Transparent;
            this.pnlHome.BorderRadius = 40;
            this.pnlHome.BorderThickness = 0;
            this.pnlHome.Controls.Add(this.pages);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(0, 50);
            this.pnlHome.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Padding = new System.Windows.Forms.Padding(10);
            this.pnlHome.ShowBorders = true;
            this.pnlHome.Size = new System.Drawing.Size(1146, 678);
            this.pnlHome.TabIndex = 4;
            // 
            // pages
            // 
            this.pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pages.AllowTransitions = false;
            this.pages.Controls.Add(this.pageHome);
            this.pages.Controls.Add(this.pageMeter);
            this.pages.Controls.Add(this.pageCust);
            this.pages.Controls.Add(this.pageRead);
            this.pages.Controls.Add(this.pageLoc);
            this.pages.Controls.Add(this.pageBill);
            this.pages.Controls.Add(this.pageReport);
            this.pages.Controls.Add(this.tabPage2);
            this.pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pages.Location = new System.Drawing.Point(10, 10);
            this.pages.Margin = new System.Windows.Forms.Padding(0);
            this.pages.Multiline = true;
            this.pages.Name = "pages";
            this.pages.Page = this.pageCust;
            this.pages.PageIndex = 2;
            this.pages.PageName = "pageCust";
            this.pages.PageTitle = "btnCust";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(1126, 658);
            this.pages.TabIndex = 1;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.pages.Transition = animation1;
            this.pages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            this.pages.SelectedIndexChanged += new System.EventHandler(this.pages_SelectedIndexChanged);
            // 
            // pageHome
            // 
            this.pageHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageHome.Controls.Add(this.label1);
            this.pageHome.Location = new System.Drawing.Point(4, 4);
            this.pageHome.Name = "pageHome";
            this.pageHome.Padding = new System.Windows.Forms.Padding(3);
            this.pageHome.Size = new System.Drawing.Size(1118, 632);
            this.pageHome.TabIndex = 0;
            this.pageHome.Text = "btnHome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOME Page";
            // 
            // pageMeter
            // 
            this.pageMeter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageMeter.Controls.Add(this.label2);
            this.pageMeter.Location = new System.Drawing.Point(4, 4);
            this.pageMeter.Name = "pageMeter";
            this.pageMeter.Padding = new System.Windows.Forms.Padding(3);
            this.pageMeter.Size = new System.Drawing.Size(1118, 632);
            this.pageMeter.TabIndex = 1;
            this.pageMeter.Text = "btnMeter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 71);
            this.label2.TabIndex = 1;
            this.label2.Text = "METERS";
            // 
            // pageCust
            // 
            this.pageCust.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageCust.Controls.Add(this.ucCustomer1);
            this.pageCust.Controls.Add(this.label3);
            this.pageCust.Location = new System.Drawing.Point(4, 4);
            this.pageCust.Name = "pageCust";
            this.pageCust.Padding = new System.Windows.Forms.Padding(3);
            this.pageCust.Size = new System.Drawing.Size(1118, 632);
            this.pageCust.TabIndex = 2;
            this.pageCust.Text = "btnCust";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 71);
            this.label3.TabIndex = 1;
            this.label3.Text = "CUSTOMERS";
            // 
            // pageRead
            // 
            this.pageRead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageRead.Controls.Add(this.label4);
            this.pageRead.Location = new System.Drawing.Point(4, 4);
            this.pageRead.Name = "pageRead";
            this.pageRead.Padding = new System.Windows.Forms.Padding(3);
            this.pageRead.Size = new System.Drawing.Size(1118, 632);
            this.pageRead.TabIndex = 3;
            this.pageRead.Text = "btnRead";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 71);
            this.label4.TabIndex = 1;
            this.label4.Text = "READ";
            // 
            // pageLoc
            // 
            this.pageLoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageLoc.Controls.Add(this.label5);
            this.pageLoc.Location = new System.Drawing.Point(4, 4);
            this.pageLoc.Name = "pageLoc";
            this.pageLoc.Padding = new System.Windows.Forms.Padding(3);
            this.pageLoc.Size = new System.Drawing.Size(1118, 632);
            this.pageLoc.TabIndex = 4;
            this.pageLoc.Text = "btnLoc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(454, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 71);
            this.label5.TabIndex = 2;
            this.label5.Text = "LOCATION";
            // 
            // pageBill
            // 
            this.pageBill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageBill.Controls.Add(this.label8);
            this.pageBill.Location = new System.Drawing.Point(4, 4);
            this.pageBill.Name = "pageBill";
            this.pageBill.Padding = new System.Windows.Forms.Padding(3);
            this.pageBill.Size = new System.Drawing.Size(1118, 632);
            this.pageBill.TabIndex = 5;
            this.pageBill.Text = "btnBill";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mistral", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(448, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 71);
            this.label8.TabIndex = 2;
            this.label8.Text = "BILL";
            // 
            // pageReport
            // 
            this.pageReport.Controls.Add(this.label7);
            this.pageReport.Location = new System.Drawing.Point(4, 4);
            this.pageReport.Name = "pageReport";
            this.pageReport.Padding = new System.Windows.Forms.Padding(3);
            this.pageReport.Size = new System.Drawing.Size(1118, 632);
            this.pageReport.TabIndex = 6;
            this.pageReport.Text = "btnReport";
            this.pageReport.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mistral", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 71);
            this.label7.TabIndex = 2;
            this.label7.Text = "REPORT";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1118, 632);
            this.tabPage2.TabIndex = 7;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundColor = System.Drawing.Color.White;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.BorderColor = System.Drawing.Color.White;
            this.pnlHeader.BorderRadius = 0;
            this.pnlHeader.BorderThickness = 0;
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.btnSettings);
            this.pnlHeader.Controls.Add(this.bunifuPanel1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShowBorders = true;
            this.pnlHeader.Size = new System.Drawing.Size(1146, 50);
            this.pnlHeader.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveImage = global::ProjectSystem.Properties.Resources.logoutRed;
            this.btnLogout.AllowAnimations = true;
            this.btnLogout.AllowBuffering = false;
            this.btnLogout.AllowToggling = false;
            this.btnLogout.AllowZooming = true;
            this.btnLogout.AllowZoomingOnFocus = false;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.ErrorImage = null;
            this.btnLogout.FadeWhenInactive = false;
            this.btnLogout.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnLogout.Image = global::ProjectSystem.Properties.Resources.logout;
            this.btnLogout.ImageLocation = null;
            this.btnLogout.ImageMargin = 5;
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.btnLogout.InitialImage = null;
            this.btnLogout.Location = new System.Drawing.Point(19, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Rotation = 0;
            this.btnLogout.ShowActiveImage = true;
            this.btnLogout.ShowCursorChanges = true;
            this.btnLogout.ShowImageBorders = true;
            this.btnLogout.ShowSizeMarkers = false;
            this.btnLogout.Size = new System.Drawing.Size(25, 25);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.ToolTipText = "";
            this.btnLogout.WaitOnLoad = false;
            this.btnLogout.ZoomSpeed = 10;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.ActiveImage = global::ProjectSystem.Properties.Resources.settingsBlue;
            this.btnSettings.AllowAnimations = true;
            this.btnSettings.AllowBuffering = false;
            this.btnSettings.AllowToggling = false;
            this.btnSettings.AllowZooming = true;
            this.btnSettings.AllowZoomingOnFocus = false;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.ErrorImage = null;
            this.btnSettings.FadeWhenInactive = false;
            this.btnSettings.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSettings.Image = global::ProjectSystem.Properties.Resources.settings;
            this.btnSettings.ImageLocation = null;
            this.btnSettings.ImageMargin = 5;
            this.btnSettings.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSettings.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btnSettings.InitialImage = null;
            this.btnSettings.Location = new System.Drawing.Point(260, 10);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Rotation = 0;
            this.btnSettings.ShowActiveImage = true;
            this.btnSettings.ShowCursorChanges = true;
            this.btnSettings.ShowImageBorders = true;
            this.btnSettings.ShowSizeMarkers = false;
            this.btnSettings.Size = new System.Drawing.Size(30, 30);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.ToolTipText = "";
            this.btnSettings.WaitOnLoad = false;
            this.btnSettings.ZoomSpeed = 10;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 35;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.lblUser);
            this.bunifuPanel1.Controls.Add(this.bunifuPictureBox2);
            this.bunifuPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuPanel1.Location = new System.Drawing.Point(66, 5);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(172, 40);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Eras Demi ITC", 12F);
            this.lblUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUser.Location = new System.Drawing.Point(49, 10);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(92, 19);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User Name";
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.AutoSizeHeight = true;
            this.bunifuPictureBox2.BorderRadius = 20;
            this.bunifuPictureBox2.Image = global::ProjectSystem.Properties.Resources.userBlue;
            this.bunifuPictureBox2.InitialImage = global::ProjectSystem.Properties.Resources.user;
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(40, 40);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuPictureBox2.TabIndex = 0;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel2.BorderRadius = 0;
            this.bunifuPanel2.BorderThickness = 0;
            this.bunifuPanel2.Controls.Add(this.guna2Button1);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel2.Controls.Add(this.label6);
            this.bunifuPanel2.Controls.Add(this.btnReport);
            this.bunifuPanel2.Controls.Add(this.btnBill);
            this.bunifuPanel2.Controls.Add(this.btnRead);
            this.bunifuPanel2.Controls.Add(this.btnCust);
            this.bunifuPanel2.Controls.Add(this.btnLoc);
            this.bunifuPanel2.Controls.Add(this.btnMeter);
            this.bunifuPanel2.Controls.Add(this.btnHome);
            this.bunifuPanel2.Controls.Add(this.btnLogo1ut);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPanel2.Location = new System.Drawing.Point(1146, 0);
            this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(220, 728);
            this.bunifuPanel2.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.guna2Button1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(31, 532);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(154, 44);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.Text = "خروج";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Colonna MT", 38F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(31, 60);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(155, 54);
            this.bunifuLabel1.TabIndex = 12;
            this.bunifuLabel1.Text = "AS Soft";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Mj_King 1", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(36, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "ـــــــــــــــــــــــــــــــــــــــــــــــ";
            // 
            // btnReport
            // 
            this.btnReport.AnimatedGIF = true;
            this.btnReport.AutoRoundedCorners = true;
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.BorderColor = System.Drawing.Color.Transparent;
            this.btnReport.BorderRadius = 19;
            this.btnReport.BorderThickness = 1;
            this.btnReport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReport.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnReport.CheckedState.CustomBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnReport.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnReport.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.btnReport.CheckedState.Image = global::ProjectSystem.Properties.Resources.reportBlue;
            this.btnReport.CheckedState.Parent = this.btnReport;
            this.btnReport.CustomImages.Parent = this.btnReport;
            this.btnReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReport.DisabledState.Parent = this.btnReport;
            this.btnReport.FillColor = System.Drawing.Color.Transparent;
            this.btnReport.Font = new System.Drawing.Font("Hacen Dalal St", 12F);
            this.btnReport.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReport.HoverState.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnReport.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnReport.HoverState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnReport.HoverState.Image = global::ProjectSystem.Properties.Resources.reportBlue;
            this.btnReport.HoverState.Parent = this.btnReport;
            this.btnReport.Image = global::ProjectSystem.Properties.Resources.reportDark;
            this.btnReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnReport.IndicateFocus = true;
            this.btnReport.Location = new System.Drawing.Point(-12, 448);
            this.btnReport.Name = "btnReport";
            this.btnReport.ShadowDecoration.Parent = this.btnReport;
            this.btnReport.Size = new System.Drawing.Size(180, 40);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "التقارير";
            this.btnReport.UseTransparentBackground = true;
            this.btnReport.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBill
            // 
            this.btnBill.AnimatedGIF = true;
            this.btnBill.AutoRoundedCorners = true;
            this.btnBill.BackColor = System.Drawing.Color.Transparent;
            this.btnBill.BorderColor = System.Drawing.Color.Transparent;
            this.btnBill.BorderRadius = 19;
            this.btnBill.BorderThickness = 1;
            this.btnBill.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBill.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBill.CheckedState.CustomBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBill.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnBill.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.btnBill.CheckedState.Image = global::ProjectSystem.Properties.Resources.billBlue;
            this.btnBill.CheckedState.Parent = this.btnBill;
            this.btnBill.CustomImages.Parent = this.btnBill;
            this.btnBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBill.DisabledState.Parent = this.btnBill;
            this.btnBill.FillColor = System.Drawing.Color.Transparent;
            this.btnBill.Font = new System.Drawing.Font("Hacen Dalal St", 12F);
            this.btnBill.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBill.HoverState.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnBill.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnBill.HoverState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBill.HoverState.Image = global::ProjectSystem.Properties.Resources.billBlue;
            this.btnBill.HoverState.Parent = this.btnBill;
            this.btnBill.Image = global::ProjectSystem.Properties.Resources.billDark;
            this.btnBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBill.ImageSize = new System.Drawing.Size(22, 23);
            this.btnBill.IndicateFocus = true;
            this.btnBill.Location = new System.Drawing.Point(-12, 402);
            this.btnBill.Name = "btnBill";
            this.btnBill.ShadowDecoration.Parent = this.btnBill;
            this.btnBill.Size = new System.Drawing.Size(180, 40);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "الفواتير";
            this.btnBill.UseTransparentBackground = true;
            this.btnBill.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRead
            // 
            this.btnRead.AnimatedGIF = true;
            this.btnRead.AutoRoundedCorners = true;
            this.btnRead.BackColor = System.Drawing.Color.Transparent;
            this.btnRead.BorderColor = System.Drawing.Color.Transparent;
            this.btnRead.BorderRadius = 19;
            this.btnRead.BorderThickness = 1;
            this.btnRead.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRead.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRead.CheckedState.CustomBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRead.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnRead.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.btnRead.CheckedState.Image = global::ProjectSystem.Properties.Resources.readBlue;
            this.btnRead.CheckedState.Parent = this.btnRead;
            this.btnRead.CustomImages.Parent = this.btnRead;
            this.btnRead.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRead.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRead.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRead.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRead.DisabledState.Parent = this.btnRead;
            this.btnRead.FillColor = System.Drawing.Color.Transparent;
            this.btnRead.Font = new System.Drawing.Font("Hacen Dalal St", 12F);
            this.btnRead.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRead.HoverState.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnRead.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnRead.HoverState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRead.HoverState.Image = global::ProjectSystem.Properties.Resources.readBlue;
            this.btnRead.HoverState.Parent = this.btnRead;
            this.btnRead.Image = global::ProjectSystem.Properties.Resources.readDark;
            this.btnRead.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRead.ImageSize = new System.Drawing.Size(24, 24);
            this.btnRead.IndicateFocus = true;
            this.btnRead.Location = new System.Drawing.Point(-12, 356);
            this.btnRead.Name = "btnRead";
            this.btnRead.ShadowDecoration.Parent = this.btnRead;
            this.btnRead.Size = new System.Drawing.Size(180, 40);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "القراءات";
            this.btnRead.UseTransparentBackground = true;
            this.btnRead.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCust
            // 
            this.btnCust.AnimatedGIF = true;
            this.btnCust.AutoRoundedCorners = true;
            this.btnCust.BackColor = System.Drawing.Color.Transparent;
            this.btnCust.BorderColor = System.Drawing.Color.Transparent;
            this.btnCust.BorderRadius = 19;
            this.btnCust.BorderThickness = 1;
            this.btnCust.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCust.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCust.CheckedState.CustomBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCust.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnCust.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.btnCust.CheckedState.Image = global::ProjectSystem.Properties.Resources.customerBlue;
            this.btnCust.CheckedState.Parent = this.btnCust;
            this.btnCust.CustomImages.Parent = this.btnCust;
            this.btnCust.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCust.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCust.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCust.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCust.DisabledState.Parent = this.btnCust;
            this.btnCust.FillColor = System.Drawing.Color.Transparent;
            this.btnCust.Font = new System.Drawing.Font("Hacen Dalal St", 12F);
            this.btnCust.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCust.HoverState.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnCust.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnCust.HoverState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCust.HoverState.Image = global::ProjectSystem.Properties.Resources.customerBlue;
            this.btnCust.HoverState.Parent = this.btnCust;
            this.btnCust.Image = global::ProjectSystem.Properties.Resources.customerDark;
            this.btnCust.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCust.ImageSize = new System.Drawing.Size(22, 22);
            this.btnCust.IndicateFocus = true;
            this.btnCust.Location = new System.Drawing.Point(-12, 310);
            this.btnCust.Name = "btnCust";
            this.btnCust.ShadowDecoration.Parent = this.btnCust;
            this.btnCust.Size = new System.Drawing.Size(180, 40);
            this.btnCust.TabIndex = 3;
            this.btnCust.Text = "المشتركين";
            this.btnCust.UseTransparentBackground = true;
            this.btnCust.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.AnimatedGIF = true;
            this.btnLoc.AutoRoundedCorners = true;
            this.btnLoc.BackColor = System.Drawing.Color.Transparent;
            this.btnLoc.BorderColor = System.Drawing.Color.Transparent;
            this.btnLoc.BorderRadius = 19;
            this.btnLoc.BorderThickness = 1;
            this.btnLoc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLoc.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLoc.CheckedState.CustomBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLoc.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoc.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.btnLoc.CheckedState.Image = global::ProjectSystem.Properties.Resources.locBlue;
            this.btnLoc.CheckedState.Parent = this.btnLoc;
            this.btnLoc.CustomImages.Parent = this.btnLoc;
            this.btnLoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoc.DisabledState.Parent = this.btnLoc;
            this.btnLoc.FillColor = System.Drawing.Color.Transparent;
            this.btnLoc.Font = new System.Drawing.Font("Hacen Dalal St", 12F);
            this.btnLoc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLoc.HoverState.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoc.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnLoc.HoverState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoc.HoverState.Image = global::ProjectSystem.Properties.Resources.locBlue;
            this.btnLoc.HoverState.Parent = this.btnLoc;
            this.btnLoc.Image = global::ProjectSystem.Properties.Resources.locDark;
            this.btnLoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLoc.ImageSize = new System.Drawing.Size(22, 22);
            this.btnLoc.IndicateFocus = true;
            this.btnLoc.Location = new System.Drawing.Point(-12, 264);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.ShadowDecoration.Parent = this.btnLoc;
            this.btnLoc.Size = new System.Drawing.Size(180, 40);
            this.btnLoc.TabIndex = 3;
            this.btnLoc.Text = "المناطق";
            this.btnLoc.UseTransparentBackground = true;
            this.btnLoc.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMeter
            // 
            this.btnMeter.AnimatedGIF = true;
            this.btnMeter.AutoRoundedCorners = true;
            this.btnMeter.BackColor = System.Drawing.Color.Transparent;
            this.btnMeter.BorderColor = System.Drawing.Color.Transparent;
            this.btnMeter.BorderRadius = 19;
            this.btnMeter.BorderThickness = 1;
            this.btnMeter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMeter.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnMeter.CheckedState.CustomBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMeter.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnMeter.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.btnMeter.CheckedState.Image = global::ProjectSystem.Properties.Resources.meterBlue;
            this.btnMeter.CheckedState.Parent = this.btnMeter;
            this.btnMeter.CustomImages.Parent = this.btnMeter;
            this.btnMeter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMeter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMeter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMeter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMeter.DisabledState.Parent = this.btnMeter;
            this.btnMeter.FillColor = System.Drawing.Color.Transparent;
            this.btnMeter.Font = new System.Drawing.Font("Hacen Dalal St", 12F);
            this.btnMeter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMeter.HoverState.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnMeter.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnMeter.HoverState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMeter.HoverState.Image = global::ProjectSystem.Properties.Resources.meterBlue;
            this.btnMeter.HoverState.Parent = this.btnMeter;
            this.btnMeter.Image = global::ProjectSystem.Properties.Resources.meterDark;
            this.btnMeter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMeter.ImageSize = new System.Drawing.Size(24, 24);
            this.btnMeter.IndicateFocus = true;
            this.btnMeter.Location = new System.Drawing.Point(-12, 218);
            this.btnMeter.Name = "btnMeter";
            this.btnMeter.ShadowDecoration.Parent = this.btnMeter;
            this.btnMeter.Size = new System.Drawing.Size(180, 40);
            this.btnMeter.TabIndex = 3;
            this.btnMeter.Text = "العدادات";
            this.btnMeter.UseTransparentBackground = true;
            this.btnMeter.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnHome
            // 
            this.btnHome.AnimatedGIF = true;
            this.btnHome.AutoRoundedCorners = true;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderRadius = 19;
            this.btnHome.BorderThickness = 1;
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.Checked = true;
            this.btnHome.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.CheckedState.CustomBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.btnHome.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.btnHome.CheckedState.Image = global::ProjectSystem.Properties.Resources.homesBlue;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.DisabledState.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Hacen Dalal St", 12F);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHome.HoverState.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.HoverState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = global::ProjectSystem.Properties.Resources.homesDark;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnHome.IndicateFocus = true;
            this.btnHome.Location = new System.Drawing.Point(-12, 172);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(180, 40);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "الرئيسية";
            this.btnHome.UseTransparentBackground = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogo1ut
            // 
            this.btnLogo1ut.AllowAnimations = true;
            this.btnLogo1ut.AllowMouseEffects = true;
            this.btnLogo1ut.AllowToggling = false;
            this.btnLogo1ut.AnimationSpeed = 200;
            this.btnLogo1ut.AutoGenerateColors = false;
            this.btnLogo1ut.AutoRoundBorders = false;
            this.btnLogo1ut.AutoSizeLeftIcon = true;
            this.btnLogo1ut.AutoSizeRightIcon = true;
            this.btnLogo1ut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo1ut.BackColor1 = System.Drawing.SystemColors.HotTrack;
            this.btnLogo1ut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogo1ut.BackgroundImage")));
            this.btnLogo1ut.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogo1ut.ButtonText = "خروج";
            this.btnLogo1ut.ButtonTextMarginLeft = 0;
            this.btnLogo1ut.ColorContrastOnClick = 45;
            this.btnLogo1ut.ColorContrastOnHover = 45;
            this.btnLogo1ut.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLogo1ut.CustomizableEdges = borderEdges1;
            this.btnLogo1ut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogo1ut.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogo1ut.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogo1ut.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogo1ut.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogo1ut.Font = new System.Drawing.Font("Hacen Extender X-Slant", 12F);
            this.btnLogo1ut.ForeColor = System.Drawing.Color.White;
            this.btnLogo1ut.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogo1ut.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogo1ut.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogo1ut.IconMarginLeft = 11;
            this.btnLogo1ut.IconPadding = 10;
            this.btnLogo1ut.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogo1ut.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogo1ut.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogo1ut.IconSize = 25;
            this.btnLogo1ut.IdleBorderColor = System.Drawing.Color.White;
            this.btnLogo1ut.IdleBorderRadius = 20;
            this.btnLogo1ut.IdleBorderThickness = 1;
            this.btnLogo1ut.IdleFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogo1ut.IdleIconLeftImage = null;
            this.btnLogo1ut.IdleIconRightImage = global::ProjectSystem.Properties.Resources.logout1;
            this.btnLogo1ut.IndicateFocus = true;
            this.btnLogo1ut.Location = new System.Drawing.Point(39, 582);
            this.btnLogo1ut.Name = "btnLogo1ut";
            this.btnLogo1ut.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogo1ut.OnDisabledState.BorderRadius = 20;
            this.btnLogo1ut.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogo1ut.OnDisabledState.BorderThickness = 1;
            this.btnLogo1ut.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogo1ut.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogo1ut.OnDisabledState.IconLeftImage = null;
            this.btnLogo1ut.OnDisabledState.IconRightImage = null;
            this.btnLogo1ut.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnLogo1ut.onHoverState.BorderRadius = 20;
            this.btnLogo1ut.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogo1ut.onHoverState.BorderThickness = 1;
            this.btnLogo1ut.onHoverState.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogo1ut.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogo1ut.onHoverState.IconLeftImage = null;
            this.btnLogo1ut.onHoverState.IconRightImage = null;
            this.btnLogo1ut.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnLogo1ut.OnIdleState.BorderRadius = 20;
            this.btnLogo1ut.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogo1ut.OnIdleState.BorderThickness = 1;
            this.btnLogo1ut.OnIdleState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogo1ut.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLogo1ut.OnIdleState.IconLeftImage = null;
            this.btnLogo1ut.OnIdleState.IconRightImage = global::ProjectSystem.Properties.Resources.logout1;
            this.btnLogo1ut.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogo1ut.OnPressedState.BorderRadius = 20;
            this.btnLogo1ut.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogo1ut.OnPressedState.BorderThickness = 1;
            this.btnLogo1ut.OnPressedState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogo1ut.OnPressedState.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogo1ut.OnPressedState.IconLeftImage = null;
            this.btnLogo1ut.OnPressedState.IconRightImage = null;
            this.btnLogo1ut.Size = new System.Drawing.Size(150, 39);
            this.btnLogo1ut.TabIndex = 8;
            this.btnLogo1ut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogo1ut.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogo1ut.TextMarginLeft = 0;
            this.btnLogo1ut.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLogo1ut.UseDefaultRadiusAndThickness = true;
            // 
            // ucCustomer1
            // 
            this.ucCustomer1.BackColor = System.Drawing.Color.Transparent;
            this.ucCustomer1.Location = new System.Drawing.Point(20, 21);
            this.ucCustomer1.Name = "ucCustomer1";
            this.ucCustomer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucCustomer1.Size = new System.Drawing.Size(1078, 595);
            this.ucCustomer1.TabIndex = 2;
            this.ucCustomer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucCustomer1_KeyPress);
            this.ucCustomer1.MouseEnter += new System.EventHandler(this.ucCustomer1_MouseEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 728);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.bunifuPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Click += new System.EventHandler(this.FormMain_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseClick);
            this.pnlHome.ResumeLayout(false);
            this.pages.ResumeLayout(false);
            this.pageHome.ResumeLayout(false);
            this.pageHome.PerformLayout();
            this.pageMeter.ResumeLayout(false);
            this.pageMeter.PerformLayout();
            this.pageCust.ResumeLayout(false);
            this.pageCust.PerformLayout();
            this.pageRead.ResumeLayout(false);
            this.pageRead.PerformLayout();
            this.pageLoc.ResumeLayout(false);
            this.pageLoc.PerformLayout();
            this.pageBill.ResumeLayout(false);
            this.pageBill.PerformLayout();
            this.pageReport.ResumeLayout(false);
            this.pageReport.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse ElpsForm;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPages pages;
        private System.Windows.Forms.TabPage pageHome;
        private System.Windows.Forms.TabPage pageMeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage pageCust;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage pageRead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage pageLoc;
        private System.Windows.Forms.TabPage pageBill;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogo1ut;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuPanel pnlHeader;
        private Bunifu.UI.WinForms.BunifuPanel pnlHome;
        private Bunifu.UI.WinForms.BunifuImageButton btnSettings;
        private Bunifu.UI.WinForms.BunifuImageButton btnLogout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage pageReport;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnReport;
        private Guna.UI2.WinForms.Guna2Button btnBill;
        private Guna.UI2.WinForms.Guna2Button btnRead;
        private Guna.UI2.WinForms.Guna2Button btnCust;
        private Guna.UI2.WinForms.Guna2Button btnLoc;
        private Guna.UI2.WinForms.Guna2Button btnMeter;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private ucCustomer ucCustomer1;
    }
}