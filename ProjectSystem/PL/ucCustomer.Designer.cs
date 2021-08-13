
namespace ProjectSystem.PL
{
    partial class ucCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCustomer));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgvCustomer = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dgvCust_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustRead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustBlnc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnAddCust = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.elpsDgv = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowCustomTheming = true;
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomer.ColumnHeadersHeight = 40;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCust_id,
            this.dgvCustNo,
            this.dgvCustName,
            this.dgvCustMeter,
            this.dgvCustLoc,
            this.dgvCustPhone,
            this.dgvCustRead,
            this.dgvCustBlnc,
            this.dgvCustStatus});
            this.dgvCustomer.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvCustomer.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvCustomer.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomer.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvCustomer.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCustomer.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvCustomer.CurrentTheme.GridColor = System.Drawing.Color.Silver;
            this.dgvCustomer.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvCustomer.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvCustomer.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomer.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvCustomer.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCustomer.CurrentTheme.Name = null;
            this.dgvCustomer.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomer.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvCustomer.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomer.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvCustomer.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.GridColor = System.Drawing.Color.Silver;
            this.dgvCustomer.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvCustomer.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvCustomer.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCustomer.Location = new System.Drawing.Point(20, 194);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(20);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Amiri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomer.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomer.RowTemplate.Height = 30;
            this.dgvCustomer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1086, 444);
            this.dgvCustomer.TabIndex = 11;
            this.dgvCustomer.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // dgvCust_id
            // 
            this.dgvCust_id.DataPropertyName = "cust_id";
            this.dgvCust_id.HeaderText = "cust id";
            this.dgvCust_id.Name = "dgvCust_id";
            this.dgvCust_id.ReadOnly = true;
            this.dgvCust_id.Visible = false;
            // 
            // dgvCustNo
            // 
            this.dgvCustNo.FillWeight = 30.45683F;
            this.dgvCustNo.HeaderText = "م";
            this.dgvCustNo.Name = "dgvCustNo";
            this.dgvCustNo.ReadOnly = true;
            // 
            // dgvCustName
            // 
            this.dgvCustName.DataPropertyName = "اسم_المشترك";
            this.dgvCustName.FillWeight = 113.5424F;
            this.dgvCustName.HeaderText = "اسم المشترك";
            this.dgvCustName.Name = "dgvCustName";
            this.dgvCustName.ReadOnly = true;
            // 
            // dgvCustMeter
            // 
            this.dgvCustMeter.DataPropertyName = "رقم_العداد";
            this.dgvCustMeter.FillWeight = 114.2423F;
            this.dgvCustMeter.HeaderText = "رقم العداد";
            this.dgvCustMeter.Name = "dgvCustMeter";
            this.dgvCustMeter.ReadOnly = true;
            // 
            // dgvCustLoc
            // 
            this.dgvCustLoc.DataPropertyName = "العنوان";
            this.dgvCustLoc.FillWeight = 113.5438F;
            this.dgvCustLoc.HeaderText = "العنوان";
            this.dgvCustLoc.Name = "dgvCustLoc";
            this.dgvCustLoc.ReadOnly = true;
            // 
            // dgvCustPhone
            // 
            this.dgvCustPhone.DataPropertyName = "الجوال";
            this.dgvCustPhone.HeaderText = "الجوال";
            this.dgvCustPhone.Name = "dgvCustPhone";
            this.dgvCustPhone.ReadOnly = true;
            // 
            // dgvCustRead
            // 
            this.dgvCustRead.DataPropertyName = "آخر_قراءة";
            this.dgvCustRead.HeaderText = "آخر قراءة";
            this.dgvCustRead.Name = "dgvCustRead";
            this.dgvCustRead.ReadOnly = true;
            // 
            // dgvCustBlnc
            // 
            this.dgvCustBlnc.DataPropertyName = "الرصيد";
            this.dgvCustBlnc.FillWeight = 114.249F;
            this.dgvCustBlnc.HeaderText = "الرصيد";
            this.dgvCustBlnc.Name = "dgvCustBlnc";
            this.dgvCustBlnc.ReadOnly = true;
            // 
            // dgvCustStatus
            // 
            this.dgvCustStatus.DataPropertyName = "الحالة";
            this.dgvCustStatus.FillWeight = 113.9653F;
            this.dgvCustStatus.HeaderText = "الحالة";
            this.dgvCustStatus.Name = "dgvCustStatus";
            this.dgvCustStatus.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.AllowAnimations = true;
            this.btnSearch.AllowMouseEffects = true;
            this.btnSearch.AllowToggling = false;
            this.btnSearch.AnimationSpeed = 200;
            this.btnSearch.AutoGenerateColors = false;
            this.btnSearch.AutoRoundBorders = false;
            this.btnSearch.AutoSizeLeftIcon = true;
            this.btnSearch.AutoSizeRightIcon = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackColor1 = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.ButtonText = "";
            this.btnSearch.ButtonTextMarginLeft = 0;
            this.btnSearch.ColorContrastOnClick = 45;
            this.btnSearch.ColorContrastOnHover = 45;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSearch.CustomizableEdges = borderEdges1;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearch.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearch.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSearch.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSearch.IconMarginLeft = 11;
            this.btnSearch.IconPadding = 10;
            this.btnSearch.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSearch.IconSize = 25;
            this.btnSearch.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnSearch.IdleBorderRadius = 45;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleFillColor = System.Drawing.Color.White;
            this.btnSearch.IdleIconLeftImage = global::ProjectSystem.Properties.Resources.searchBlue;
            this.btnSearch.IdleIconRightImage = null;
            this.btnSearch.IndicateFocus = false;
            this.btnSearch.Location = new System.Drawing.Point(197, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearch.OnDisabledState.BorderRadius = 45;
            this.btnSearch.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnDisabledState.BorderThickness = 1;
            this.btnSearch.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearch.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSearch.OnDisabledState.IconLeftImage = null;
            this.btnSearch.OnDisabledState.IconRightImage = null;
            this.btnSearch.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSearch.onHoverState.BorderRadius = 45;
            this.btnSearch.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.onHoverState.BorderThickness = 1;
            this.btnSearch.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSearch.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.onHoverState.IconLeftImage = null;
            this.btnSearch.onHoverState.IconRightImage = null;
            this.btnSearch.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch.OnIdleState.BorderRadius = 45;
            this.btnSearch.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnIdleState.BorderThickness = 1;
            this.btnSearch.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnSearch.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.OnIdleState.IconLeftImage = global::ProjectSystem.Properties.Resources.searchBlue;
            this.btnSearch.OnIdleState.IconRightImage = null;
            this.btnSearch.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSearch.OnPressedState.BorderRadius = 45;
            this.btnSearch.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnPressedState.BorderThickness = 1;
            this.btnSearch.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSearch.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.OnPressedState.IconLeftImage = null;
            this.btnSearch.OnPressedState.IconRightImage = null;
            this.btnSearch.Size = new System.Drawing.Size(45, 45);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.TextMarginLeft = 0;
            this.btnSearch.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSearch.UseDefaultRadiusAndThickness = true;
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.SystemColors.Highlight;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Transparent;
            this.txtSearch.BorderRadius = 16;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Noon", 11F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(337, 19);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = System.Drawing.SystemColors.Highlight;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Transparent;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "البحث";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(399, 44);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 4;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "البحث";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            // 
            // btnAddCust
            // 
            this.btnAddCust.AllowAnimations = true;
            this.btnAddCust.AllowMouseEffects = true;
            this.btnAddCust.AllowToggling = false;
            this.btnAddCust.AnimationSpeed = 200;
            this.btnAddCust.AutoGenerateColors = false;
            this.btnAddCust.AutoRoundBorders = false;
            this.btnAddCust.AutoSizeLeftIcon = true;
            this.btnAddCust.AutoSizeRightIcon = true;
            this.btnAddCust.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCust.BackColor1 = System.Drawing.SystemColors.HotTrack;
            this.btnAddCust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCust.BackgroundImage")));
            this.btnAddCust.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCust.ButtonText = "إضافة مشترك";
            this.btnAddCust.ButtonTextMarginLeft = 0;
            this.btnAddCust.ColorContrastOnClick = 45;
            this.btnAddCust.ColorContrastOnHover = 45;
            this.btnAddCust.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddCust.CustomizableEdges = borderEdges2;
            this.btnAddCust.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddCust.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddCust.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddCust.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddCust.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddCust.Font = new System.Drawing.Font("Noon", 15F);
            this.btnAddCust.ForeColor = System.Drawing.Color.White;
            this.btnAddCust.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCust.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddCust.IconLeftPadding = new System.Windows.Forms.Padding(10);
            this.btnAddCust.IconMarginLeft = 11;
            this.btnAddCust.IconPadding = 10;
            this.btnAddCust.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCust.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddCust.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnAddCust.IconSize = 25;
            this.btnAddCust.IdleBorderColor = System.Drawing.Color.White;
            this.btnAddCust.IdleBorderRadius = 20;
            this.btnAddCust.IdleBorderThickness = 1;
            this.btnAddCust.IdleFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddCust.IdleIconLeftImage = global::ProjectSystem.Properties.Resources.add;
            this.btnAddCust.IdleIconRightImage = null;
            this.btnAddCust.IndicateFocus = true;
            this.btnAddCust.Location = new System.Drawing.Point(833, 19);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddCust.OnDisabledState.BorderRadius = 20;
            this.btnAddCust.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCust.OnDisabledState.BorderThickness = 1;
            this.btnAddCust.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddCust.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddCust.OnDisabledState.IconLeftImage = null;
            this.btnAddCust.OnDisabledState.IconRightImage = null;
            this.btnAddCust.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnAddCust.onHoverState.BorderRadius = 20;
            this.btnAddCust.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCust.onHoverState.BorderThickness = 1;
            this.btnAddCust.onHoverState.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddCust.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddCust.onHoverState.IconLeftImage = null;
            this.btnAddCust.onHoverState.IconRightImage = null;
            this.btnAddCust.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnAddCust.OnIdleState.BorderRadius = 20;
            this.btnAddCust.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCust.OnIdleState.BorderThickness = 1;
            this.btnAddCust.OnIdleState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddCust.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddCust.OnIdleState.IconLeftImage = global::ProjectSystem.Properties.Resources.add;
            this.btnAddCust.OnIdleState.IconRightImage = null;
            this.btnAddCust.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btnAddCust.OnPressedState.BorderRadius = 20;
            this.btnAddCust.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCust.OnPressedState.BorderThickness = 1;
            this.btnAddCust.OnPressedState.FillColor = System.Drawing.Color.Turquoise;
            this.btnAddCust.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddCust.OnPressedState.IconLeftImage = null;
            this.btnAddCust.OnPressedState.IconRightImage = null;
            this.btnAddCust.Size = new System.Drawing.Size(167, 45);
            this.btnAddCust.TabIndex = 9;
            this.btnAddCust.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCust.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddCust.TextMarginLeft = 0;
            this.btnAddCust.TextPadding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnAddCust.UseDefaultRadiusAndThickness = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // elpsDgv
            // 
            this.elpsDgv.ElipseRadius = 25;
            this.elpsDgv.TargetControl = this.dgvCustomer;
            // 
            // ucCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnAddCust);
            this.Name = "ucCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1126, 658);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddCust;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvCustomer;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSearch;
        private Bunifu.Framework.UI.BunifuElipse elpsDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCust_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustBlnc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustStatus;
    }
}
