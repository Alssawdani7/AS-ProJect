namespace ProjectSystem.PL
{
    partial class FormAddCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCust));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlHomeAddCust = new Guna.UI2.WinForms.Guna2Panel();
            this.ucCustDataCust1 = new ProjectSystem.PL.ucCustDataCust();
            this.guna2Panel1.SuspendLayout();
            this.pnlHomeAddCust.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(610, 4);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.bunifuLabel1);
            this.guna2Panel1.Controls.Add(this.btnClose);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(610, 38);
            this.guna2Panel1.TabIndex = 1;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("B Arabic Style", 20F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(465, -3);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuLabel1.Size = new System.Drawing.Size(107, 44);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "إضافة مشترك";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.HoverState.Image = global::ProjectSystem.Properties.Resources.closeRed_64;
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::ProjectSystem.Properties.Resources.close_64;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(12, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlHomeAddCust
            // 
            this.pnlHomeAddCust.BorderRadius = 15;
            this.pnlHomeAddCust.Controls.Add(this.guna2Panel1);
            this.pnlHomeAddCust.Controls.Add(this.ucCustDataCust1);
            this.pnlHomeAddCust.Controls.Add(this.guna2GradientPanel1);
            this.pnlHomeAddCust.FillColor = System.Drawing.Color.White;
            this.pnlHomeAddCust.Location = new System.Drawing.Point(234, 2);
            this.pnlHomeAddCust.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHomeAddCust.Name = "pnlHomeAddCust";
            this.pnlHomeAddCust.ShadowDecoration.Parent = this.pnlHomeAddCust;
            this.pnlHomeAddCust.Size = new System.Drawing.Size(610, 590);
            this.pnlHomeAddCust.TabIndex = 12;
            // 
            // ucCustDataCust1
            // 
            this.ucCustDataCust1.BackColor = System.Drawing.Color.White;
            this.ucCustDataCust1.Location = new System.Drawing.Point(65, 77);
            this.ucCustDataCust1.Name = "ucCustDataCust1";
            this.ucCustDataCust1.Padding = new System.Windows.Forms.Padding(3);
            this.ucCustDataCust1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucCustDataCust1.Size = new System.Drawing.Size(480, 490);
            this.ucCustDataCust1.TabIndex = 11;
            // 
            // FormAddCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1078, 595);
            this.Controls.Add(this.pnlHomeAddCust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(30, 80);
            this.Name = "FormAddCust";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormAddCust";
            this.Load += new System.EventHandler(this.FormAddCust_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnlHomeAddCust.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2Panel pnlHomeAddCust;
        public ucCustDataCust ucCustDataCust1;
    }
}