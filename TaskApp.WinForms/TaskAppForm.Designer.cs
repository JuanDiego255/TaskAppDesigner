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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();

            this._rootLayout = new System.Windows.Forms.TableLayoutPanel();
            this._bodyLayout = new System.Windows.Forms.TableLayoutPanel();
            this._contentWrapper = new System.Windows.Forms.TableLayoutPanel();
            this._contentLayout = new System.Windows.Forms.TableLayoutPanel();
            this._filtersLayout = new System.Windows.Forms.TableLayoutPanel();
            this._topbar = new System.Windows.Forms.Panel();
            this._navLayout = new System.Windows.Forms.TableLayoutPanel();
            this._lblTitle = new System.Windows.Forms.Label();
            this._navActions = new System.Windows.Forms.FlowLayoutPanel();
            this._btnNew = new System.Windows.Forms.Button();
            this._btnEdit = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this._btnToInProgress = new System.Windows.Forms.Button();
            this._btnToDone = new System.Windows.Forms.Button();
            this._btnRefresh = new System.Windows.Forms.Button();
            this._separatorPanel = new System.Windows.Forms.Panel();
            this._sidebar = new System.Windows.Forms.Panel();
            this._sideHeader = new System.Windows.Forms.Panel();
            this._lblMenu = new System.Windows.Forms.Label();
            this._sideMenu = new System.Windows.Forms.FlowLayoutPanel();
            this._btnDashboard = new System.Windows.Forms.Button();
            this._btnTareas = new System.Windows.Forms.Button();
            this._contentSeparator = new System.Windows.Forms.Panel();
            this._gridCard = new System.Windows.Forms.Panel();
            this._txtSearch = new System.Windows.Forms.TextBox();
            this._cmbStatus = new System.Windows.Forms.ComboBox();
            this._cmbPriority = new System.Windows.Forms.ComboBox();
            this._txtUser = new System.Windows.Forms.TextBox();
            this._grid = new System.Windows.Forms.DataGridView();
            this._colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);

            this._rootLayout.SuspendLayout();
            this._bodyLayout.SuspendLayout();
            this._contentWrapper.SuspendLayout();
            this._contentLayout.SuspendLayout();
            this._filtersLayout.SuspendLayout();
            this._topbar.SuspendLayout();
            this._navLayout.SuspendLayout();
            this._navActions.SuspendLayout();
            this._sidebar.SuspendLayout();
            this._sideHeader.SuspendLayout();
            this._sideMenu.SuspendLayout();
            this._gridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this.SuspendLayout();

            //
            // _toolTip
            //
            this._toolTip.AutomaticDelay = 150;
            this._toolTip.AutoPopDelay = 5000;
            this._toolTip.ReshowDelay = 100;
            this._toolTip.ShowAlways = true;

            //
            // _rootLayout
            //
            this._rootLayout.ColumnCount = 1;
            this._rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._rootLayout.Controls.Add(this._topbar, 0, 0);
            this._rootLayout.Controls.Add(this._bodyLayout, 0, 1);
            this._rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rootLayout.Location = new System.Drawing.Point(0, 0);
            this._rootLayout.Name = "_rootLayout";
            this._rootLayout.Padding = System.Windows.Forms.Padding.Empty;
            this._rootLayout.RowCount = 2;
            this._rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this._rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._rootLayout.Size = new System.Drawing.Size(1100, 650);
            this._rootLayout.TabIndex = 0;
            this._rootLayout.BackColor = System.Drawing.Color.White;

            //
            // _topbar
            //
            this._topbar.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this._topbar.Controls.Add(this._navLayout);
            this._topbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._topbar.Location = new System.Drawing.Point(0, 0);
            this._topbar.Name = "_topbar";
            this._topbar.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this._topbar.Size = new System.Drawing.Size(1100, 56);
            this._topbar.TabIndex = 0;

            //
            // _navLayout
            //
            this._navLayout.BackColor = System.Drawing.Color.Transparent;
            this._navLayout.ColumnCount = 2;
            this._navLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._navLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this._navLayout.Controls.Add(this._lblTitle, 0, 0);
            this._navLayout.Controls.Add(this._navActions, 1, 0);
            this._navLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._navLayout.Location = new System.Drawing.Point(14, 10);
            this._navLayout.Name = "_navLayout";
            this._navLayout.RowCount = 1;
            this._navLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._navLayout.Size = new System.Drawing.Size(1072, 36);
            this._navLayout.TabIndex = 0;

            //
            // _lblTitle
            //
            this._lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this._lblTitle.ForeColor = System.Drawing.Color.FromArgb(25, 25, 25);
            this._lblTitle.Location = new System.Drawing.Point(0, 0);
            this._lblTitle.Name = "_lblTitle";
            this._lblTitle.Size = new System.Drawing.Size(800, 36);
            this._lblTitle.TabIndex = 0;
            this._lblTitle.Text = "Administrador de tareas";
            this._lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            //
            // _navActions
            //
            this._navActions.AutoSize = true;
            this._navActions.Controls.Add(this._btnNew);
            this._navActions.Controls.Add(this._btnEdit);
            this._navActions.Controls.Add(this._btnDelete);
            this._navActions.Controls.Add(this._separatorPanel);
            this._navActions.Controls.Add(this._btnToInProgress);
            this._navActions.Controls.Add(this._btnToDone);
            this._navActions.Controls.Add(this._btnRefresh);
            this._navActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this._navActions.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this._navActions.Location = new System.Drawing.Point(800, 0);
            this._navActions.Margin = System.Windows.Forms.Padding.Empty;
            this._navActions.Name = "_navActions";
            this._navActions.Padding = System.Windows.Forms.Padding.Empty;
            this._navActions.Size = new System.Drawing.Size(272, 36);
            this._navActions.TabIndex = 1;
            this._navActions.WrapContents = false;

            //
            // _btnNew
            //
            this._btnNew.BackColor = System.Drawing.Color.White;
            this._btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this._btnNew.FlatAppearance.BorderSize = 1;
            this._btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this._btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this._btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnNew.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this._btnNew.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this._btnNew.Location = new System.Drawing.Point(2, 0);
            this._btnNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._btnNew.Name = "_btnNew";
            this._btnNew.Padding = System.Windows.Forms.Padding.Empty;
            this._btnNew.Size = new System.Drawing.Size(40, 36);
            this._btnNew.TabIndex = 0;
            this._btnNew.TabStop = false;
            this._btnNew.Text = "➕";
            this._btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnNew.UseVisualStyleBackColor = false;
            this._toolTip.SetToolTip(this._btnNew, "Crear (Nuevo)");

            //
            // _btnEdit
            //
            this._btnEdit.BackColor = System.Drawing.Color.White;
            this._btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this._btnEdit.FlatAppearance.BorderSize = 1;
            this._btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this._btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this._btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnEdit.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this._btnEdit.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this._btnEdit.Location = new System.Drawing.Point(46, 0);
            this._btnEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Padding = System.Windows.Forms.Padding.Empty;
            this._btnEdit.Size = new System.Drawing.Size(40, 36);
            this._btnEdit.TabIndex = 1;
            this._btnEdit.TabStop = false;
            this._btnEdit.Text = "✏️";
            this._btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnEdit.UseVisualStyleBackColor = false;
            this._toolTip.SetToolTip(this._btnEdit, "Actualizar (Editar)");

            //
            // _btnDelete
            //
            this._btnDelete.BackColor = System.Drawing.Color.White;
            this._btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this._btnDelete.FlatAppearance.BorderSize = 1;
            this._btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this._btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDelete.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this._btnDelete.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this._btnDelete.Location = new System.Drawing.Point(90, 0);
            this._btnDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Padding = System.Windows.Forms.Padding.Empty;
            this._btnDelete.Size = new System.Drawing.Size(40, 36);
            this._btnDelete.TabIndex = 2;
            this._btnDelete.TabStop = false;
            this._btnDelete.Text = "🗑️";
            this._btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnDelete.UseVisualStyleBackColor = false;
            this._toolTip.SetToolTip(this._btnDelete, "Eliminar");

            //
            // _separatorPanel
            //
            this._separatorPanel.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this._separatorPanel.Location = new System.Drawing.Point(142, 4);
            this._separatorPanel.Margin = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this._separatorPanel.Name = "_separatorPanel";
            this._separatorPanel.Size = new System.Drawing.Size(1, 28);
            this._separatorPanel.TabIndex = 3;

            //
            // _btnToInProgress
            //
            this._btnToInProgress.BackColor = System.Drawing.Color.White;
            this._btnToInProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnToInProgress.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this._btnToInProgress.FlatAppearance.BorderSize = 1;
            this._btnToInProgress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this._btnToInProgress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this._btnToInProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnToInProgress.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this._btnToInProgress.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this._btnToInProgress.Location = new System.Drawing.Point(165, 0);
            this._btnToInProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._btnToInProgress.Name = "_btnToInProgress";
            this._btnToInProgress.Padding = System.Windows.Forms.Padding.Empty;
            this._btnToInProgress.Size = new System.Drawing.Size(40, 36);
            this._btnToInProgress.TabIndex = 4;
            this._btnToInProgress.TabStop = false;
            this._btnToInProgress.Text = "⏳";
            this._btnToInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnToInProgress.UseVisualStyleBackColor = false;
            this._toolTip.SetToolTip(this._btnToInProgress, "Pasar a En proceso");

            //
            // _btnToDone
            //
            this._btnToDone.BackColor = System.Drawing.Color.White;
            this._btnToDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnToDone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this._btnToDone.FlatAppearance.BorderSize = 1;
            this._btnToDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this._btnToDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this._btnToDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnToDone.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this._btnToDone.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this._btnToDone.Location = new System.Drawing.Point(209, 0);
            this._btnToDone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._btnToDone.Name = "_btnToDone";
            this._btnToDone.Padding = System.Windows.Forms.Padding.Empty;
            this._btnToDone.Size = new System.Drawing.Size(40, 36);
            this._btnToDone.TabIndex = 5;
            this._btnToDone.TabStop = false;
            this._btnToDone.Text = "✅";
            this._btnToDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnToDone.UseVisualStyleBackColor = false;
            this._toolTip.SetToolTip(this._btnToDone, "Finalizar (Pasar a Done)");

            //
            // _btnRefresh
            //
            this._btnRefresh.BackColor = System.Drawing.Color.White;
            this._btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this._btnRefresh.FlatAppearance.BorderSize = 1;
            this._btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this._btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this._btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnRefresh.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this._btnRefresh.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this._btnRefresh.Location = new System.Drawing.Point(253, 0);
            this._btnRefresh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._btnRefresh.Name = "_btnRefresh";
            this._btnRefresh.Padding = System.Windows.Forms.Padding.Empty;
            this._btnRefresh.Size = new System.Drawing.Size(40, 36);
            this._btnRefresh.TabIndex = 6;
            this._btnRefresh.TabStop = false;
            this._btnRefresh.Text = "🔄";
            this._btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnRefresh.UseVisualStyleBackColor = false;
            this._toolTip.SetToolTip(this._btnRefresh, "Refrescar");

            //
            // _bodyLayout
            //
            this._bodyLayout.BackColor = System.Drawing.Color.White;
            this._bodyLayout.ColumnCount = 2;
            this._bodyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this._bodyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._bodyLayout.Controls.Add(this._sidebar, 0, 0);
            this._bodyLayout.Controls.Add(this._contentWrapper, 1, 0);
            this._bodyLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bodyLayout.Location = new System.Drawing.Point(0, 62);
            this._bodyLayout.Margin = System.Windows.Forms.Padding.Empty;
            this._bodyLayout.Name = "_bodyLayout";
            this._bodyLayout.Padding = System.Windows.Forms.Padding.Empty;
            this._bodyLayout.RowCount = 1;
            this._bodyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._bodyLayout.Size = new System.Drawing.Size(1100, 588);
            this._bodyLayout.TabIndex = 1;

            //
            // _sidebar
            //
            this._sidebar.BackColor = System.Drawing.Color.FromArgb(24, 28, 36);
            this._sidebar.Controls.Add(this._sideMenu);
            this._sidebar.Controls.Add(this._sideHeader);
            this._sidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sidebar.Location = new System.Drawing.Point(0, 0);
            this._sidebar.Margin = System.Windows.Forms.Padding.Empty;
            this._sidebar.Name = "_sidebar";
            this._sidebar.Padding = new System.Windows.Forms.Padding(12);
            this._sidebar.Size = new System.Drawing.Size(220, 588);
            this._sidebar.TabIndex = 0;

            //
            // _sideHeader
            //
            this._sideHeader.Controls.Add(this._lblMenu);
            this._sideHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this._sideHeader.Location = new System.Drawing.Point(12, 12);
            this._sideHeader.Name = "_sideHeader";
            this._sideHeader.Size = new System.Drawing.Size(196, 56);
            this._sideHeader.TabIndex = 0;

            //
            // _lblMenu
            //
            this._lblMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lblMenu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this._lblMenu.ForeColor = System.Drawing.Color.White;
            this._lblMenu.Location = new System.Drawing.Point(0, 0);
            this._lblMenu.Name = "_lblMenu";
            this._lblMenu.Size = new System.Drawing.Size(196, 56);
            this._lblMenu.TabIndex = 0;
            this._lblMenu.Text = "MENU";
            this._lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            //
            // _sideMenu
            //
            this._sideMenu.AutoScroll = true;
            //this._sideMenu.Controls.Add(this._btnDashboard);
            this._sideMenu.Controls.Add(this._btnTareas);
            this._sideMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sideMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._sideMenu.Location = new System.Drawing.Point(12, 68);
            this._sideMenu.Name = "_sideMenu";
            this._sideMenu.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this._sideMenu.Size = new System.Drawing.Size(196, 508);
            this._sideMenu.TabIndex = 1;
            this._sideMenu.WrapContents = false;

            //
            // _btnDashboard
            //
            this._btnDashboard.BackColor = System.Drawing.Color.FromArgb(32, 37, 48);
            this._btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDashboard.FlatAppearance.BorderSize = 0;
            this._btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 62, 80);
            this._btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 52, 66);
            this._btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDashboard.ForeColor = System.Drawing.Color.White;
            this._btnDashboard.Location = new System.Drawing.Point(0, 10);
            this._btnDashboard.Margin = System.Windows.Forms.Padding.Empty;
            this._btnDashboard.Name = "_btnDashboard";
            this._btnDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this._btnDashboard.Size = new System.Drawing.Size(180, 40);
            this._btnDashboard.TabIndex = 0;
            this._btnDashboard.TabStop = false;
            this._btnDashboard.Text = "Dashboard";
            this._btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnDashboard.UseVisualStyleBackColor = false;

            //
            // _btnTareas
            //
            this._btnTareas.BackColor = System.Drawing.Color.FromArgb(32, 37, 48);
            this._btnTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnTareas.FlatAppearance.BorderSize = 0;
            this._btnTareas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 62, 80);
            this._btnTareas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 52, 66);
            this._btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnTareas.ForeColor = System.Drawing.Color.White;
            this._btnTareas.Location = new System.Drawing.Point(0, 50);
            this._btnTareas.Margin = System.Windows.Forms.Padding.Empty;
            this._btnTareas.Name = "_btnTareas";
            this._btnTareas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this._btnTareas.Size = new System.Drawing.Size(180, 40);
            this._btnTareas.TabIndex = 1;
            this._btnTareas.TabStop = false;
            this._btnTareas.Text = "Tareas";
            this._btnTareas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnTareas.UseVisualStyleBackColor = false;

            //
            // _contentWrapper
            //
            this._contentWrapper.BackColor = System.Drawing.Color.White;
            this._contentWrapper.ColumnCount = 1;
            this._contentWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._contentWrapper.Controls.Add(this._contentSeparator, 0, 0);
            this._contentWrapper.Controls.Add(this._contentLayout, 0, 1);
            this._contentWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this._contentWrapper.Location = new System.Drawing.Point(220, 0);
            this._contentWrapper.Margin = System.Windows.Forms.Padding.Empty;
            this._contentWrapper.Name = "_contentWrapper";
            this._contentWrapper.RowCount = 2;
            this._contentWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this._contentWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._contentWrapper.Size = new System.Drawing.Size(880, 588);
            this._contentWrapper.TabIndex = 1;

            //
            // _contentSeparator
            //
            this._contentSeparator.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this._contentSeparator.Dock = System.Windows.Forms.DockStyle.Fill;
            this._contentSeparator.Location = new System.Drawing.Point(0, 0);
            this._contentSeparator.Margin = System.Windows.Forms.Padding.Empty;
            this._contentSeparator.Name = "_contentSeparator";
            this._contentSeparator.Size = new System.Drawing.Size(880, 1);
            this._contentSeparator.TabIndex = 0;

            //
            // _contentLayout
            //
            this._contentLayout.BackColor = System.Drawing.Color.White;
            this._contentLayout.ColumnCount = 1;
            this._contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._contentLayout.Controls.Add(this._filtersLayout, 0, 0);
            this._contentLayout.Controls.Add(this._gridCard, 0, 1);
            this._contentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._contentLayout.Location = new System.Drawing.Point(0, 1);
            this._contentLayout.Margin = System.Windows.Forms.Padding.Empty;
            this._contentLayout.Name = "_contentLayout";
            this._contentLayout.Padding = new System.Windows.Forms.Padding(12);
            this._contentLayout.RowCount = 2;
            this._contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this._contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._contentLayout.Size = new System.Drawing.Size(880, 587);
            this._contentLayout.TabIndex = 1;

            //
            // _filtersLayout
            //
            this._filtersLayout.AutoSize = true;
            this._filtersLayout.BackColor = System.Drawing.Color.White;
            this._filtersLayout.ColumnCount = 4;
            this._filtersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this._filtersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._filtersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._filtersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._filtersLayout.Controls.Add(this._txtSearch, 0, 0);
            this._filtersLayout.Controls.Add(this._cmbStatus, 1, 0);
            this._filtersLayout.Controls.Add(this._cmbPriority, 2, 0);
            this._filtersLayout.Controls.Add(this._txtUser, 3, 0);
            this._filtersLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this._filtersLayout.Location = new System.Drawing.Point(12, 12);
            this._filtersLayout.Margin = System.Windows.Forms.Padding.Empty;
            this._filtersLayout.Name = "_filtersLayout";
            this._filtersLayout.RowCount = 1;
            this._filtersLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this._filtersLayout.Size = new System.Drawing.Size(856, 29);
            this._filtersLayout.TabIndex = 0;

            //
            // _txtSearch
            //
            this._txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtSearch.Location = new System.Drawing.Point(3, 3);
            this._txtSearch.Name = "_txtSearch";
            this._txtSearch.PlaceholderText = "Buscar por descripción...";
            this._txtSearch.Size = new System.Drawing.Size(336, 23);
            this._txtSearch.TabIndex = 0;

            //
            // _cmbStatus
            //
            this._cmbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbStatus.FormattingEnabled = true;
            this._cmbStatus.Location = new System.Drawing.Point(345, 3);
            this._cmbStatus.Name = "_cmbStatus";
            this._cmbStatus.Size = new System.Drawing.Size(165, 23);
            this._cmbStatus.TabIndex = 1;

            //
            // _cmbPriority
            //
            this._cmbPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbPriority.FormattingEnabled = true;
            this._cmbPriority.Location = new System.Drawing.Point(516, 3);
            this._cmbPriority.Name = "_cmbPriority";
            this._cmbPriority.Size = new System.Drawing.Size(165, 23);
            this._cmbPriority.TabIndex = 2;

            //
            // _txtUser
            //
            this._txtUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtUser.Location = new System.Drawing.Point(687, 3);
            this._txtUser.Name = "_txtUser";
            this._txtUser.PlaceholderText = "Usuario (exacto)";
            this._txtUser.Size = new System.Drawing.Size(166, 23);
            this._txtUser.TabIndex = 3;

            //
            // _gridCard
            //
            this._gridCard.BackColor = System.Drawing.Color.White;
            this._gridCard.Controls.Add(this._grid);
            this._gridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridCard.Location = new System.Drawing.Point(12, 51);
            this._gridCard.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this._gridCard.Name = "_gridCard";
            this._gridCard.Padding = new System.Windows.Forms.Padding(10);
            this._gridCard.Size = new System.Drawing.Size(856, 524);
            this._gridCard.TabIndex = 1;

            //
            // _grid
            //
            this._grid.AllowUserToAddRows = false;
            this._grid.AllowUserToDeleteRows = false;
            this._grid.AllowUserToResizeRows = false;
            this._grid.AutoGenerateColumns = false;
            this._grid.BackgroundColor = System.Drawing.Color.White;
            this._grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this._grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._grid.ColumnHeadersHeight = 44;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this._colDescription,
                this._colUser,
                this._colStatus,
                this._colPriority,
                this._colDue,
                this._colNotes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(22, 22, 22);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(232, 240, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(22, 22, 22);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.DefaultCellStyle = dataGridViewCellStyle2;
            this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grid.EnableHeadersVisualStyles = false;
            this._grid.GridColor = System.Drawing.Color.FromArgb(235, 238, 242);
            this._grid.Location = new System.Drawing.Point(10, 10);
            this._grid.MultiSelect = false;
            this._grid.Name = "_grid";
            this._grid.ReadOnly = true;
            this._grid.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(253, 253, 254);
            this._grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this._grid.RowTemplate.Height = 44;
            this._grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grid.Size = new System.Drawing.Size(836, 504);
            this._grid.TabIndex = 0;

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
            this._colUser.DataPropertyName = "AssignedUser";
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
            // TaskAppForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this._rootLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "TaskAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de tareas";
            this._rootLayout.ResumeLayout(false);
            this._bodyLayout.ResumeLayout(false);
            this._contentWrapper.ResumeLayout(false);
            this._contentLayout.ResumeLayout(false);
            this._contentLayout.PerformLayout();
            this._filtersLayout.ResumeLayout(false);
            this._filtersLayout.PerformLayout();
            this._topbar.ResumeLayout(false);
            this._navLayout.ResumeLayout(false);
            this._navLayout.PerformLayout();
            this._navActions.ResumeLayout(false);
            this._sidebar.ResumeLayout(false);
            this._sideHeader.ResumeLayout(false);
            this._sideMenu.ResumeLayout(false);
            this._gridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.ResumeLayout(false);
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
    }
}