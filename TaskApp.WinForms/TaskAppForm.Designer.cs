namespace TaskApp.WinForms
{
    partial class TaskAppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            _rootLayout = new TableLayoutPanel();
            _topbar = new Panel();
            _navLayout = new TableLayoutPanel();
            _lblTitle = new Label();
            _navActions = new FlowLayoutPanel();
            _btnNew = new Button();
            _btnEdit = new Button();
            _btnDelete = new Button();
            _separatorPanel = new Panel();
            _btnToInProgress = new Button();
            _btnToDone = new Button();
            _btnRefresh = new Button();
            _navActionsUser = new FlowLayoutPanel();
            _btnNewUser = new Button();
            _btnEditUser = new Button();
            _btnDeleteUser = new Button();
            _btnRefreshUser = new Button();
            _bodyLayout = new TableLayoutPanel();
            _sidebar = new Panel();
            _sideMenu = new FlowLayoutPanel();
            _btnTareas = new Button();
            _btnUsuarios = new Button();
            _sideHeader = new Panel();
            _lblMenu = new Label();
            _contentWrapper = new TableLayoutPanel();
            _contentSeparator = new Panel();
            _contentLayout = new TableLayoutPanel();
            _filtersLayout = new TableLayoutPanel();
            _txtSearch = new TextBox();
            _cmbStatus = new ComboBox();
            _cmbPriority = new ComboBox();
            _txtUser = new TextBox();
            _gridCard = new Panel();
            _grid = new DataGridView();
            _userContentLayout = new TableLayoutPanel();
            _userFiltersLayout = new TableLayoutPanel();
            _txtUserSearch = new TextBox();
            _userGridCard = new Panel();
            _userGrid = new DataGridView();
            _btnDashboard = new Button();
            this._colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colUserDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colUserCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            _toolTip = new ToolTip(components);
            _rootLayout.SuspendLayout();
            _topbar.SuspendLayout();
            _navLayout.SuspendLayout();
            _navActions.SuspendLayout();
            _navActionsUser.SuspendLayout();
            _bodyLayout.SuspendLayout();
            _sidebar.SuspendLayout();
            _sideMenu.SuspendLayout();
            _sideHeader.SuspendLayout();
            _contentWrapper.SuspendLayout();
            _contentLayout.SuspendLayout();
            _filtersLayout.SuspendLayout();
            _gridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_grid).BeginInit();
            _userContentLayout.SuspendLayout();
            _userFiltersLayout.SuspendLayout();
            _userGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_userGrid).BeginInit();
            SuspendLayout();
            // 
            // _rootLayout
            // 
            _rootLayout.BackColor = Color.White;
            _rootLayout.ColumnCount = 1;
            _rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _rootLayout.Controls.Add(_topbar, 0, 0);
            _rootLayout.Controls.Add(_bodyLayout, 0, 1);
            _rootLayout.Dock = DockStyle.Fill;
            _rootLayout.Location = new Point(0, 0);
            _rootLayout.Name = "_rootLayout";
            _rootLayout.RowCount = 2;
            _rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            _rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _rootLayout.Size = new Size(1100, 650);
            _rootLayout.TabIndex = 0;
            // 
            // _topbar
            // 
            _topbar.BackColor = Color.FromArgb(250, 250, 250);
            _topbar.Controls.Add(_navLayout);
            _topbar.Dock = DockStyle.Fill;
            _topbar.Location = new Point(3, 3);
            _topbar.Name = "_topbar";
            _topbar.Padding = new Padding(14, 10, 14, 10);
            _topbar.Size = new Size(1094, 56);
            _topbar.TabIndex = 0;
            // 
            // _navLayout
            // 
            _navLayout.BackColor = Color.Transparent;
            _navLayout.ColumnCount = 3;
            _navLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _navLayout.ColumnStyles.Add(new ColumnStyle());
            _navLayout.ColumnStyles.Add(new ColumnStyle());
            _navLayout.Controls.Add(_lblTitle, 0, 0);
            _navLayout.Controls.Add(_navActions, 1, 0);
            _navLayout.Controls.Add(_navActionsUser, 2, 0);
            _navLayout.Dock = DockStyle.Fill;
            _navLayout.Location = new Point(14, 10);
            _navLayout.Name = "_navLayout";
            _navLayout.RowCount = 1;
            _navLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _navLayout.Size = new Size(1066, 36);
            _navLayout.TabIndex = 0;
            // 
            // _lblTitle
            // 
            _lblTitle.Dock = DockStyle.Fill;
            _lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblTitle.ForeColor = Color.FromArgb(25, 25, 25);
            _lblTitle.Location = new Point(3, 0);
            _lblTitle.Name = "_lblTitle";
            _lblTitle.Size = new Size(599, 36);
            _lblTitle.TabIndex = 0;
            _lblTitle.Text = "Administrador de tareas";
            _lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _navActions
            // 
            _navActions.AutoSize = true;
            _navActions.Controls.Add(_btnNew);
            _navActions.Controls.Add(_btnEdit);
            _navActions.Controls.Add(_btnDelete);
            _navActions.Controls.Add(_separatorPanel);
            _navActions.Controls.Add(_btnToInProgress);
            _navActions.Controls.Add(_btnToDone);
            _navActions.Controls.Add(_btnRefresh);
            _navActions.Dock = DockStyle.Fill;
            _navActions.Location = new Point(605, 0);
            _navActions.Margin = new Padding(0);
            _navActions.Name = "_navActions";
            _navActions.Size = new Size(285, 36);
            _navActions.TabIndex = 1;
            _navActions.WrapContents = false;
            // 
            // _btnNew
            // 
            _btnNew.BackColor = Color.White;
            _btnNew.Cursor = Cursors.Hand;
            _btnNew.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            _btnNew.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
            _btnNew.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
            _btnNew.FlatStyle = FlatStyle.Flat;
            _btnNew.Font = new Font("Segoe UI Emoji", 11F);
            _btnNew.ForeColor = Color.FromArgb(30, 30, 30);
            _btnNew.Location = new Point(2, 0);
            _btnNew.Margin = new Padding(2, 0, 2, 0);
            _btnNew.Name = "_btnNew";
            _btnNew.Size = new Size(40, 36);
            _btnNew.TabIndex = 0;
            _btnNew.TabStop = false;
            _btnNew.Text = "➕";
            _toolTip.SetToolTip(_btnNew, "Crear (Nuevo)");
            _btnNew.UseVisualStyleBackColor = false;
            // 
            // _btnEdit
            // 
            _btnEdit.BackColor = Color.White;
            _btnEdit.Cursor = Cursors.Hand;
            _btnEdit.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            _btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
            _btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
            _btnEdit.FlatStyle = FlatStyle.Flat;
            _btnEdit.Font = new Font("Segoe UI Emoji", 11F);
            _btnEdit.ForeColor = Color.FromArgb(30, 30, 30);
            _btnEdit.Location = new Point(46, 0);
            _btnEdit.Margin = new Padding(2, 0, 2, 0);
            _btnEdit.Name = "_btnEdit";
            _btnEdit.Size = new Size(40, 36);
            _btnEdit.TabIndex = 1;
            _btnEdit.TabStop = false;
            _btnEdit.Text = "✏️";
            _toolTip.SetToolTip(_btnEdit, "Actualizar (Editar)");
            _btnEdit.UseVisualStyleBackColor = false;
            // 
            // _btnDelete
            // 
            _btnDelete.BackColor = Color.White;
            _btnDelete.Cursor = Cursors.Hand;
            _btnDelete.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            _btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
            _btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
            _btnDelete.FlatStyle = FlatStyle.Flat;
            _btnDelete.Font = new Font("Segoe UI Emoji", 11F);
            _btnDelete.ForeColor = Color.FromArgb(30, 30, 30);
            _btnDelete.Location = new Point(90, 0);
            _btnDelete.Margin = new Padding(2, 0, 2, 0);
            _btnDelete.Name = "_btnDelete";
            _btnDelete.Size = new Size(40, 36);
            _btnDelete.TabIndex = 2;
            _btnDelete.TabStop = false;
            _btnDelete.Text = "🗑️";
            _toolTip.SetToolTip(_btnDelete, "Eliminar");
            _btnDelete.UseVisualStyleBackColor = false;
            // 
            // _separatorPanel
            // 
            _separatorPanel.BackColor = Color.FromArgb(220, 220, 220);
            _separatorPanel.Location = new Point(142, 4);
            _separatorPanel.Margin = new Padding(10, 4, 10, 4);
            _separatorPanel.Name = "_separatorPanel";
            _separatorPanel.Size = new Size(1, 28);
            _separatorPanel.TabIndex = 3;
            // 
            // _btnToInProgress
            // 
            _btnToInProgress.BackColor = Color.White;
            _btnToInProgress.Cursor = Cursors.Hand;
            _btnToInProgress.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            _btnToInProgress.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
            _btnToInProgress.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
            _btnToInProgress.FlatStyle = FlatStyle.Flat;
            _btnToInProgress.Font = new Font("Segoe UI Emoji", 11F);
            _btnToInProgress.ForeColor = Color.FromArgb(30, 30, 30);
            _btnToInProgress.Location = new Point(155, 0);
            _btnToInProgress.Margin = new Padding(2, 0, 2, 0);
            _btnToInProgress.Name = "_btnToInProgress";
            _btnToInProgress.Size = new Size(40, 36);
            _btnToInProgress.TabIndex = 4;
            _btnToInProgress.TabStop = false;
            _btnToInProgress.Text = "⏳";
            _toolTip.SetToolTip(_btnToInProgress, "Pasar a En proceso");
            _btnToInProgress.UseVisualStyleBackColor = false;
            // 
            // _btnToDone
            // 
            _btnToDone.BackColor = Color.White;
            _btnToDone.Cursor = Cursors.Hand;
            _btnToDone.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            _btnToDone.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
            _btnToDone.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
            _btnToDone.FlatStyle = FlatStyle.Flat;
            _btnToDone.Font = new Font("Segoe UI Emoji", 11F);
            _btnToDone.ForeColor = Color.FromArgb(30, 30, 30);
            _btnToDone.Location = new Point(199, 0);
            _btnToDone.Margin = new Padding(2, 0, 2, 0);
            _btnToDone.Name = "_btnToDone";
            _btnToDone.Size = new Size(40, 36);
            _btnToDone.TabIndex = 5;
            _btnToDone.TabStop = false;
            _btnToDone.Text = "✅";
            _toolTip.SetToolTip(_btnToDone, "Finalizar (Pasar a Done)");
            _btnToDone.UseVisualStyleBackColor = false;
            // 
            // _btnRefresh
            // 
            _btnRefresh.BackColor = Color.White;
            _btnRefresh.Cursor = Cursors.Hand;
            _btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            _btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
            _btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
            _btnRefresh.FlatStyle = FlatStyle.Flat;
            _btnRefresh.Font = new Font("Segoe UI Emoji", 11F);
            _btnRefresh.ForeColor = Color.FromArgb(30, 30, 30);
            _btnRefresh.Location = new Point(243, 0);
            _btnRefresh.Margin = new Padding(2, 0, 2, 0);
            _btnRefresh.Name = "_btnRefresh";
            _btnRefresh.Size = new Size(40, 36);
            _btnRefresh.TabIndex = 6;
            _btnRefresh.TabStop = false;
            _btnRefresh.Text = "🔄";
            _toolTip.SetToolTip(_btnRefresh, "Refrescar");
            _btnRefresh.UseVisualStyleBackColor = false;
            // 
            // _navActionsUser
            // 
            _navActionsUser.AutoSize = true;
            _navActionsUser.Controls.Add(_btnNewUser);
            _navActionsUser.Controls.Add(_btnEditUser);
            _navActionsUser.Controls.Add(_btnDeleteUser);
            _navActionsUser.Controls.Add(_btnRefreshUser);
            _navActionsUser.Dock = DockStyle.Fill;
            _navActionsUser.Location = new Point(890, 0);
            _navActionsUser.Margin = new Padding(0);
            _navActionsUser.Name = "_navActionsUser";
            _navActionsUser.Size = new Size(176, 36);
            _navActionsUser.TabIndex = 2;
            _navActionsUser.Visible = false;
            _navActionsUser.WrapContents = false;
            // 
            // _btnNewUser
            // 
            _btnNewUser.BackColor = Color.White;
            _btnNewUser.Cursor = Cursors.Hand;
            _btnNewUser.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            _btnNewUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
            _btnNewUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
            _btnNewUser.FlatStyle = FlatStyle.Flat;
            _btnNewUser.Font = new Font("Segoe UI Emoji", 11F);
            _btnNewUser.ForeColor = Color.FromArgb(30, 30, 30);
            _btnNewUser.Location = new Point(2, 0);
            _btnNewUser.Margin = new Padding(2, 0, 2, 0);
            _btnNewUser.Name = "_btnNewUser";
            _btnNewUser.Size = new Size(40, 36);
            _btnNewUser.TabIndex = 0;
            _btnNewUser.TabStop = false;
            _btnNewUser.Text = "➕";
            _toolTip.SetToolTip(_btnNewUser, "Crear usuario");
            _btnNewUser.UseVisualStyleBackColor = false;
            // 
            // _btnEditUser
            // 
            _btnEditUser.BackColor = Color.White;
            _btnEditUser.Cursor = Cursors.Hand;
            _btnEditUser.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            _btnEditUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
            _btnEditUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
            _btnEditUser.FlatStyle = FlatStyle.Flat;
            _btnEditUser.Font = new Font("Segoe UI Emoji", 11F);
            _btnEditUser.ForeColor = Color.FromArgb(30, 30, 30);
            _btnEditUser.Location = new Point(46, 0);
            _btnEditUser.Margin = new Padding(2, 0, 2, 0);
            _btnEditUser.Name = "_btnEditUser";
            _btnEditUser.Size = new Size(40, 36);
            _btnEditUser.TabIndex = 1;
            _btnEditUser.TabStop = false;
            _btnEditUser.Text = "✏️";
            _toolTip.SetToolTip(_btnEditUser, "Editar usuario");
            _btnEditUser.UseVisualStyleBackColor = false;
            // 
            // _btnDeleteUser
            // 
            _btnDeleteUser.BackColor = Color.White;
            _btnDeleteUser.Cursor = Cursors.Hand;
            _btnDeleteUser.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            _btnDeleteUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
            _btnDeleteUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
            _btnDeleteUser.FlatStyle = FlatStyle.Flat;
            _btnDeleteUser.Font = new Font("Segoe UI Emoji", 11F);
            _btnDeleteUser.ForeColor = Color.FromArgb(30, 30, 30);
            _btnDeleteUser.Location = new Point(90, 0);
            _btnDeleteUser.Margin = new Padding(2, 0, 2, 0);
            _btnDeleteUser.Name = "_btnDeleteUser";
            _btnDeleteUser.Size = new Size(40, 36);
            _btnDeleteUser.TabIndex = 2;
            _btnDeleteUser.TabStop = false;
            _btnDeleteUser.Text = "🗑️";
            _toolTip.SetToolTip(_btnDeleteUser, "Eliminar usuario");
            _btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // _btnRefreshUser
            // 
            _btnRefreshUser.BackColor = Color.White;
            _btnRefreshUser.Cursor = Cursors.Hand;
            _btnRefreshUser.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            _btnRefreshUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
            _btnRefreshUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
            _btnRefreshUser.FlatStyle = FlatStyle.Flat;
            _btnRefreshUser.Font = new Font("Segoe UI Emoji", 11F);
            _btnRefreshUser.ForeColor = Color.FromArgb(30, 30, 30);
            _btnRefreshUser.Location = new Point(134, 0);
            _btnRefreshUser.Margin = new Padding(2, 0, 2, 0);
            _btnRefreshUser.Name = "_btnRefreshUser";
            _btnRefreshUser.Size = new Size(40, 36);
            _btnRefreshUser.TabIndex = 3;
            _btnRefreshUser.TabStop = false;
            _btnRefreshUser.Text = "🔄";
            _toolTip.SetToolTip(_btnRefreshUser, "Refrescar usuarios");
            _btnRefreshUser.UseVisualStyleBackColor = false;
            // 
            // _bodyLayout
            // 
            _bodyLayout.BackColor = Color.White;
            _bodyLayout.ColumnCount = 2;
            _bodyLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            _bodyLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _bodyLayout.Controls.Add(_sidebar, 0, 0);
            _bodyLayout.Controls.Add(_contentWrapper, 1, 0);
            _bodyLayout.Dock = DockStyle.Fill;
            _bodyLayout.Location = new Point(0, 62);
            _bodyLayout.Margin = new Padding(0);
            _bodyLayout.Name = "_bodyLayout";
            _bodyLayout.RowCount = 1;
            _bodyLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _bodyLayout.Size = new Size(1100, 588);
            _bodyLayout.TabIndex = 1;
            // 
            // _sidebar
            // 
            _sidebar.BackColor = Color.FromArgb(24, 28, 36);
            _sidebar.Controls.Add(_sideMenu);
            _sidebar.Controls.Add(_sideHeader);
            _sidebar.Dock = DockStyle.Fill;
            _sidebar.Location = new Point(0, 0);
            _sidebar.Margin = new Padding(0);
            _sidebar.Name = "_sidebar";
            _sidebar.Padding = new Padding(12);
            _sidebar.Size = new Size(220, 588);
            _sidebar.TabIndex = 0;
            // 
            // _sideMenu
            // 
            _sideMenu.AutoScroll = true;
            _sideMenu.Controls.Add(_btnTareas);
            _sideMenu.Controls.Add(_btnUsuarios);
            _sideMenu.Dock = DockStyle.Fill;
            _sideMenu.FlowDirection = FlowDirection.TopDown;
            _sideMenu.Location = new Point(12, 68);
            _sideMenu.Name = "_sideMenu";
            _sideMenu.Padding = new Padding(0, 10, 0, 0);
            _sideMenu.Size = new Size(196, 508);
            _sideMenu.TabIndex = 1;
            _sideMenu.WrapContents = false;
            // 
            // _btnTareas
            // 
            _btnTareas.BackColor = Color.FromArgb(32, 37, 48);
            _btnTareas.Cursor = Cursors.Hand;
            _btnTareas.FlatAppearance.BorderSize = 0;
            _btnTareas.FlatAppearance.MouseDownBackColor = Color.FromArgb(54, 62, 80);
            _btnTareas.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 52, 66);
            _btnTareas.FlatStyle = FlatStyle.Flat;
            _btnTareas.ForeColor = Color.White;
            _btnTareas.Location = new Point(0, 10);
            _btnTareas.Margin = new Padding(0);
            _btnTareas.Name = "_btnTareas";
            _btnTareas.Padding = new Padding(12, 0, 0, 0);
            _btnTareas.Size = new Size(180, 40);
            _btnTareas.TabIndex = 1;
            _btnTareas.TabStop = false;
            _btnTareas.Text = "Tareas";
            _btnTareas.TextAlign = ContentAlignment.MiddleLeft;
            _btnTareas.UseVisualStyleBackColor = false;
            // 
            // _btnUsuarios
            // 
            _btnUsuarios.BackColor = Color.FromArgb(32, 37, 48);
            _btnUsuarios.Cursor = Cursors.Hand;
            _btnUsuarios.FlatAppearance.BorderSize = 0;
            _btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(54, 62, 80);
            _btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 52, 66);
            _btnUsuarios.FlatStyle = FlatStyle.Flat;
            _btnUsuarios.ForeColor = Color.White;
            _btnUsuarios.Location = new Point(0, 50);
            _btnUsuarios.Margin = new Padding(0);
            _btnUsuarios.Name = "_btnUsuarios";
            _btnUsuarios.Padding = new Padding(12, 0, 0, 0);
            _btnUsuarios.Size = new Size(180, 40);
            _btnUsuarios.TabIndex = 2;
            _btnUsuarios.TabStop = false;
            _btnUsuarios.Text = "Usuarios";
            _btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            _btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // _sideHeader
            // 
            _sideHeader.Controls.Add(_lblMenu);
            _sideHeader.Dock = DockStyle.Top;
            _sideHeader.Location = new Point(12, 12);
            _sideHeader.Name = "_sideHeader";
            _sideHeader.Size = new Size(196, 56);
            _sideHeader.TabIndex = 0;
            // 
            // _lblMenu
            // 
            _lblMenu.Dock = DockStyle.Fill;
            _lblMenu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            _lblMenu.ForeColor = Color.White;
            _lblMenu.Location = new Point(0, 0);
            _lblMenu.Name = "_lblMenu";
            _lblMenu.Size = new Size(196, 56);
            _lblMenu.TabIndex = 0;
            _lblMenu.Text = "MENU";
            _lblMenu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _contentWrapper
            // 
            _contentWrapper.BackColor = Color.White;
            _contentWrapper.ColumnCount = 1;
            _contentWrapper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _contentWrapper.Controls.Add(_contentSeparator, 0, 0);
            _contentWrapper.Controls.Add(_contentLayout, 0, 1);
            _contentWrapper.Controls.Add(_userContentLayout, 0, 2);
            _contentWrapper.Dock = DockStyle.Fill;
            _contentWrapper.Location = new Point(220, 0);
            _contentWrapper.Margin = new Padding(0);
            _contentWrapper.Name = "_contentWrapper";
            _contentWrapper.RowCount = 3;
            _contentWrapper.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            _contentWrapper.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _contentWrapper.RowStyles.Add(new RowStyle(SizeType.Percent, 0F));
            _contentWrapper.Size = new Size(880, 588);
            _contentWrapper.TabIndex = 1;
            // 
            // _contentSeparator
            // 
            _contentSeparator.BackColor = Color.FromArgb(230, 230, 230);
            _contentSeparator.Dock = DockStyle.Fill;
            _contentSeparator.Location = new Point(0, 0);
            _contentSeparator.Margin = new Padding(0);
            _contentSeparator.Name = "_contentSeparator";
            _contentSeparator.Size = new Size(880, 1);
            _contentSeparator.TabIndex = 0;
            // 
            // _contentLayout
            // 
            _contentLayout.BackColor = Color.White;
            _contentLayout.ColumnCount = 1;
            _contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _contentLayout.Controls.Add(_filtersLayout, 0, 0);
            _contentLayout.Controls.Add(_gridCard, 0, 1);
            _contentLayout.Dock = DockStyle.Fill;
            _contentLayout.Location = new Point(0, 1);
            _contentLayout.Margin = new Padding(0);
            _contentLayout.Name = "_contentLayout";
            _contentLayout.Padding = new Padding(12);
            _contentLayout.RowCount = 2;
            _contentLayout.RowStyles.Add(new RowStyle());
            _contentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _contentLayout.Size = new Size(880, 587);
            _contentLayout.TabIndex = 1;
            // 
            // _filtersLayout
            // 
            _filtersLayout.AutoSize = true;
            _filtersLayout.BackColor = Color.White;
            _filtersLayout.ColumnCount = 4;
            _filtersLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            _filtersLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            _filtersLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            _filtersLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            _filtersLayout.Controls.Add(_txtSearch, 0, 0);
            _filtersLayout.Controls.Add(_cmbStatus, 1, 0);
            _filtersLayout.Controls.Add(_cmbPriority, 2, 0);
            _filtersLayout.Controls.Add(_txtUser, 3, 0);
            _filtersLayout.Dock = DockStyle.Top;
            _filtersLayout.Location = new Point(12, 12);
            _filtersLayout.Margin = new Padding(0);
            _filtersLayout.Name = "_filtersLayout";
            _filtersLayout.RowCount = 1;
            _filtersLayout.RowStyles.Add(new RowStyle());
            _filtersLayout.Size = new Size(856, 31);
            _filtersLayout.TabIndex = 0;
            // 
            // _txtSearch
            // 
            _txtSearch.Dock = DockStyle.Fill;
            _txtSearch.Location = new Point(3, 3);
            _txtSearch.Name = "_txtSearch";
            _txtSearch.PlaceholderText = "Buscar por descripción...";
            _txtSearch.Size = new Size(336, 25);
            _txtSearch.TabIndex = 0;
            // 
            // _cmbStatus
            // 
            _cmbStatus.Dock = DockStyle.Fill;
            _cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            _cmbStatus.FormattingEnabled = true;
            _cmbStatus.Location = new Point(345, 3);
            _cmbStatus.Name = "_cmbStatus";
            _cmbStatus.Size = new Size(165, 25);
            _cmbStatus.TabIndex = 1;
            // 
            // _cmbPriority
            // 
            _cmbPriority.Dock = DockStyle.Fill;
            _cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            _cmbPriority.FormattingEnabled = true;
            _cmbPriority.Location = new Point(516, 3);
            _cmbPriority.Name = "_cmbPriority";
            _cmbPriority.Size = new Size(165, 25);
            _cmbPriority.TabIndex = 2;
            // 
            // _txtUser
            // 
            _txtUser.Dock = DockStyle.Fill;
            _txtUser.Location = new Point(687, 3);
            _txtUser.Name = "_txtUser";
            _txtUser.PlaceholderText = "Usuario";
            _txtUser.Size = new Size(166, 25);
            _txtUser.TabIndex = 3;
            // 
            // _gridCard
            // 
            _gridCard.BackColor = Color.White;
            _gridCard.Controls.Add(_grid);
            _gridCard.Dock = DockStyle.Fill;
            _gridCard.Location = new Point(12, 53);
            _gridCard.Margin = new Padding(0, 10, 0, 0);
            _gridCard.Name = "_gridCard";
            _gridCard.Padding = new Padding(10);
            _gridCard.Size = new Size(856, 522);
            _gridCard.TabIndex = 1;
            // 
            // _grid
            // 
            this._grid.AutoGenerateColumns = false;
            this._grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this._colDescription,
                this._colUser,
                this._colStatus,
                this._colPriority,
                this._colDue,
                this._colNotes});
            _grid.AllowUserToAddRows = false;
            _grid.AllowUserToDeleteRows = false;
            _grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(253, 253, 254);
            _grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            _grid.BackgroundColor = Color.White;
            _grid.BorderStyle = BorderStyle.None;
            _grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            _grid.ColumnHeadersHeight = 44;
            _grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(22, 22, 22);
            dataGridViewCellStyle3.Padding = new Padding(10, 6, 10, 6);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(232, 240, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(22, 22, 22);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _grid.DefaultCellStyle = dataGridViewCellStyle3;
            _grid.Dock = DockStyle.Fill;
            _grid.EnableHeadersVisualStyles = false;
            _grid.GridColor = Color.FromArgb(235, 238, 242);
            _grid.Location = new Point(10, 10);
            _grid.MultiSelect = false;
            _grid.Name = "_grid";
            _grid.ReadOnly = true;
            _grid.RowHeadersVisible = false;
            _grid.RowTemplate.Height = 44;
            _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _grid.Size = new Size(836, 502);
            _grid.TabIndex = 0;
            // 
            // _userContentLayout
            // 
            _userContentLayout.BackColor = Color.White;
            _userContentLayout.ColumnCount = 1;
            _userContentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _userContentLayout.Controls.Add(_userFiltersLayout, 0, 0);
            _userContentLayout.Controls.Add(_userGridCard, 0, 1);
            _userContentLayout.Dock = DockStyle.Fill;
            _userContentLayout.Location = new Point(0, 588);
            _userContentLayout.Margin = new Padding(0);
            _userContentLayout.Name = "_userContentLayout";
            _userContentLayout.Padding = new Padding(12);
            _userContentLayout.RowCount = 2;
            _userContentLayout.RowStyles.Add(new RowStyle());
            _userContentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _userContentLayout.Size = new Size(880, 1);
            _userContentLayout.TabIndex = 2;
            _userContentLayout.Visible = false;
            // 
            // _userFiltersLayout
            // 
            _userFiltersLayout.AutoSize = true;
            _userFiltersLayout.BackColor = Color.White;
            _userFiltersLayout.ColumnCount = 1;
            _userFiltersLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _userFiltersLayout.Controls.Add(_txtUserSearch, 0, 0);
            _userFiltersLayout.Dock = DockStyle.Top;
            _userFiltersLayout.Location = new Point(12, 12);
            _userFiltersLayout.Margin = new Padding(0);
            _userFiltersLayout.Name = "_userFiltersLayout";
            _userFiltersLayout.RowCount = 1;
            _userFiltersLayout.RowStyles.Add(new RowStyle());
            _userFiltersLayout.Size = new Size(856, 31);
            _userFiltersLayout.TabIndex = 0;
            // 
            // _txtUserSearch
            // 
            _txtUserSearch.Dock = DockStyle.Fill;
            _txtUserSearch.Location = new Point(3, 3);
            _txtUserSearch.Name = "_txtUserSearch";
            _txtUserSearch.PlaceholderText = "Buscar por nombre...";
            _txtUserSearch.Size = new Size(850, 25);
            _txtUserSearch.TabIndex = 0;
            // 
            // _userGridCard
            // 
            _userGridCard.BackColor = Color.White;
            _userGridCard.Controls.Add(_userGrid);
            _userGridCard.Dock = DockStyle.Fill;
            _userGridCard.Location = new Point(12, 53);
            _userGridCard.Margin = new Padding(0, 10, 0, 0);
            _userGridCard.Name = "_userGridCard";
            _userGridCard.Padding = new Padding(10);
            _userGridCard.Size = new Size(856, 1);
            _userGridCard.TabIndex = 1;
            // 
            // _userGrid
            // 
            this._userGrid.AutoGenerateColumns = false;
            _userGrid.AllowUserToAddRows = false;
            _userGrid.AllowUserToDeleteRows = false;
            _userGrid.AllowUserToResizeRows = false;
            this._userGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this._colUserName,
                this._colUserDescription,
                this._colUserCreatedAt});
            dataGridViewCellStyle4.BackColor = Color.FromArgb(253, 253, 254);
            _userGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            _userGrid.BackgroundColor = Color.White;
            _userGrid.BorderStyle = BorderStyle.None;
            _userGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _userGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle5.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            _userGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            _userGrid.ColumnHeadersHeight = 44;
            _userGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(22, 22, 22);
            dataGridViewCellStyle6.Padding = new Padding(10, 6, 10, 6);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(232, 240, 254);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(22, 22, 22);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            _userGrid.DefaultCellStyle = dataGridViewCellStyle6;
            _userGrid.Dock = DockStyle.Fill;
            _userGrid.EnableHeadersVisualStyles = false;
            _userGrid.GridColor = Color.FromArgb(235, 238, 242);
            _userGrid.Location = new Point(10, 10);
            _userGrid.MultiSelect = false;
            _userGrid.Name = "_userGrid";
            _userGrid.ReadOnly = true;
            _userGrid.RowHeadersVisible = false;
            _userGrid.RowTemplate.Height = 44;
            _userGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _userGrid.Size = new Size(836, 0);
            _userGrid.TabIndex = 0;
            // 
            // _btnDashboard
            // 
            _btnDashboard.BackColor = Color.FromArgb(32, 37, 48);
            _btnDashboard.Cursor = Cursors.Hand;
            _btnDashboard.FlatAppearance.BorderSize = 0;
            _btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(54, 62, 80);
            _btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 52, 66);
            _btnDashboard.FlatStyle = FlatStyle.Flat;
            _btnDashboard.ForeColor = Color.White;
            _btnDashboard.Location = new Point(0, 10);
            _btnDashboard.Margin = new Padding(0);
            _btnDashboard.Name = "_btnDashboard";
            _btnDashboard.Padding = new Padding(12, 0, 0, 0);
            _btnDashboard.Size = new Size(180, 40);
            _btnDashboard.TabIndex = 0;
            _btnDashboard.TabStop = false;
            _btnDashboard.Text = "Dashboard";
            _btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            _btnDashboard.UseVisualStyleBackColor = false;
            // 
            // _toolTip
            // 
            _toolTip.AutomaticDelay = 150;
            _toolTip.AutoPopDelay = 5000;
            _toolTip.InitialDelay = 150;
            _toolTip.ReshowDelay = 100;
            _toolTip.ShowAlways = true;


            //
            // _colDescription
            //
            this._colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._colDescription.DataPropertyName = "Description";
            this._colDescription.FillWeight = 40F;
            this._colDescription.HeaderText = "Descripción";
            this._colDescription.Name = "_colDescription";
            this._colDescription.ReadOnly = true;

            //
            // _colUser
            //
            this._colUser.DataPropertyName = "Name";
            this._colUser.HeaderText = "Usuario";
            this._colUser.Name = "_colUser";
            this._colUser.ReadOnly = true;
            this._colUser.Width = 160;

            //
            // _colStatus
            //
            this._colStatus.DataPropertyName = "Status";
            this._colStatus.HeaderText = "Estado";
            this._colStatus.Name = "_colStatus";
            this._colStatus.ReadOnly = true;
            this._colStatus.Width = 140;

            //
            // _colPriority
            //
            this._colPriority.DataPropertyName = "Priority";
            this._colPriority.HeaderText = "Prioridad";
            this._colPriority.Name = "_colPriority";
            this._colPriority.ReadOnly = true;
            this._colPriority.Width = 140;

            //
            // _colDue
            //
            this._colDue.DataPropertyName = "DueDate";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this._colDue.DefaultCellStyle = dataGridViewCellStyle4;
            this._colDue.HeaderText = "Vence";
            this._colDue.Name = "_colDue";
            this._colDue.ReadOnly = true;
            this._colDue.Width = 140;

            //
            // _colNotes
            //
            this._colNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._colNotes.DataPropertyName = "Notes";
            this._colNotes.FillWeight = 30F;
            this._colNotes.HeaderText = "Notas";
            this._colNotes.Name = "_colNotes";
            this._colNotes.ReadOnly = true;

            //
            // _colUserDescription
            //
            this._colUserDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._colUserDescription.DataPropertyName = "Description";
            this._colUserDescription.FillWeight = 40F;
            this._colUserDescription.HeaderText = "Descripción";
            this._colUserDescription.Name = "_colUserDescription";
            this._colUserDescription.ReadOnly = true;

            //
            // _colUser
            //
            this._colUserName.DataPropertyName = "Name";
            this._colUserName.HeaderText = "Usuario";
            this._colUserName.Name = "_colUserName";
            this._colUserName.ReadOnly = true;
            this._colUserName.Width = 160;

            //
            // _colStatus
            //
            this._colUserCreatedAt.DataPropertyName = "CreatedAtUtc";
            this._colUserCreatedAt.HeaderText = "Fecha de creación";
            this._colUserCreatedAt.Name = "_colUserCreatedAt";
            this._colUserCreatedAt.ReadOnly = true;
            this._colUserCreatedAt.Width = 140;
            // 
            // TaskAppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 650);
            Controls.Add(_rootLayout);
            Font = new Font("Segoe UI", 10F);
            Name = "TaskAppForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador de tareas";
            _rootLayout.ResumeLayout(false);
            _topbar.ResumeLayout(false);
            _navLayout.ResumeLayout(false);
            _navLayout.PerformLayout();
            _navActions.ResumeLayout(false);
            _navActionsUser.ResumeLayout(false);
            _bodyLayout.ResumeLayout(false);
            _sidebar.ResumeLayout(false);
            _sideMenu.ResumeLayout(false);
            _sideHeader.ResumeLayout(false);
            _contentWrapper.ResumeLayout(false);
            _contentLayout.ResumeLayout(false);
            _contentLayout.PerformLayout();
            _filtersLayout.ResumeLayout(false);
            _filtersLayout.PerformLayout();
            _gridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_grid).EndInit();
            _userContentLayout.ResumeLayout(false);
            _userContentLayout.PerformLayout();
            _userFiltersLayout.ResumeLayout(false);
            _userFiltersLayout.PerformLayout();
            _userGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_userGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _rootLayout;
        private System.Windows.Forms.TableLayoutPanel _bodyLayout;
        private System.Windows.Forms.TableLayoutPanel _contentWrapper;
        private System.Windows.Forms.TableLayoutPanel _contentLayout;
        private System.Windows.Forms.TableLayoutPanel _filtersLayout;
        private System.Windows.Forms.TableLayoutPanel _navLayout;
        private System.Windows.Forms.Panel _topbar;
        private System.Windows.Forms.Label _lblTitle;
        private System.Windows.Forms.FlowLayoutPanel _navActions;
        private System.Windows.Forms.Panel _separatorPanel;
        private System.Windows.Forms.Button _btnNew;
        private System.Windows.Forms.Button _btnEdit;
        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.Button _btnToInProgress;
        private System.Windows.Forms.Button _btnToDone;
        private System.Windows.Forms.Button _btnRefresh;
        private System.Windows.Forms.Panel _sidebar;
        private System.Windows.Forms.Panel _sideHeader;
        private System.Windows.Forms.Label _lblMenu;
        private System.Windows.Forms.FlowLayoutPanel _sideMenu;
        private System.Windows.Forms.Button _btnDashboard;
        private System.Windows.Forms.Button _btnTareas;
        private System.Windows.Forms.Button _btnUsuarios;
        private System.Windows.Forms.Panel _contentSeparator;
        private System.Windows.Forms.Panel _gridCard;
        private System.Windows.Forms.TextBox _txtSearch;
        private System.Windows.Forms.ComboBox _cmbStatus;
        private System.Windows.Forms.ComboBox _cmbPriority;
        private System.Windows.Forms.TextBox _txtUser;
        private System.Windows.Forms.DataGridView _grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colNotes;
        private System.Windows.Forms.ToolTip _toolTip;

        // User section
        private System.Windows.Forms.FlowLayoutPanel _navActionsUser;
        private System.Windows.Forms.Button _btnNewUser;
        private System.Windows.Forms.Button _btnEditUser;
        private System.Windows.Forms.Button _btnDeleteUser;
        private System.Windows.Forms.Button _btnRefreshUser;
        private System.Windows.Forms.TableLayoutPanel _userContentLayout;
        private System.Windows.Forms.TableLayoutPanel _userFiltersLayout;
        private System.Windows.Forms.TextBox _txtUserSearch;
        private System.Windows.Forms.Panel _userGridCard;
        private System.Windows.Forms.DataGridView _userGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colUserDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colUserCreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colUserUpdatedAt;
    }
}