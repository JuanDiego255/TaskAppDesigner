namespace TaskApp.WinForms
{
    partial class UserEditForm
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
            components = new System.ComponentModel.Container();
            _rootLayout = new TableLayoutPanel();
            _headerPanel = new Panel();
            _lblTitle = new Label();
            _contentPanel = new Panel();
            _formLayout = new TableLayoutPanel();
            _lblName = new Label();
            _txtName = new TextBox();
            _lblDescription = new Label();
            _txtDescription = new TextBox();
            _footerPanel = new Panel();
            _btnActions = new FlowLayoutPanel();
            _btnOk = new Button();
            _btnCancel = new Button();
            _toolTip = new ToolTip(components);
            _rootLayout.SuspendLayout();
            _headerPanel.SuspendLayout();
            _contentPanel.SuspendLayout();
            _formLayout.SuspendLayout();
            _footerPanel.SuspendLayout();
            _btnActions.SuspendLayout();
            SuspendLayout();
            //
            // _rootLayout
            //
            _rootLayout.BackColor = Color.White;
            _rootLayout.ColumnCount = 1;
            _rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _rootLayout.Controls.Add(_headerPanel, 0, 0);
            _rootLayout.Controls.Add(_contentPanel, 0, 1);
            _rootLayout.Controls.Add(_footerPanel, 0, 2);
            _rootLayout.Dock = DockStyle.Fill;
            _rootLayout.Location = new Point(0, 0);
            _rootLayout.Margin = new Padding(0);
            _rootLayout.Name = "_rootLayout";
            _rootLayout.RowCount = 3;
            _rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            _rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            _rootLayout.Size = new Size(480, 320);
            _rootLayout.TabIndex = 0;
            //
            // _headerPanel
            //
            _headerPanel.BackColor = Color.FromArgb(24, 28, 36);
            _headerPanel.Controls.Add(_lblTitle);
            _headerPanel.Dock = DockStyle.Fill;
            _headerPanel.Location = new Point(0, 0);
            _headerPanel.Margin = new Padding(0);
            _headerPanel.Name = "_headerPanel";
            _headerPanel.Padding = new Padding(20, 0, 20, 0);
            _headerPanel.Size = new Size(480, 60);
            _headerPanel.TabIndex = 0;
            //
            // _lblTitle
            //
            _lblTitle.Dock = DockStyle.Fill;
            _lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            _lblTitle.ForeColor = Color.White;
            _lblTitle.Location = new Point(20, 0);
            _lblTitle.Name = "_lblTitle";
            _lblTitle.Size = new Size(440, 60);
            _lblTitle.TabIndex = 0;
            _lblTitle.Text = "Nuevo usuario";
            _lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            //
            // _contentPanel
            //
            _contentPanel.BackColor = Color.White;
            _contentPanel.Controls.Add(_formLayout);
            _contentPanel.Dock = DockStyle.Fill;
            _contentPanel.Location = new Point(0, 60);
            _contentPanel.Margin = new Padding(0);
            _contentPanel.Name = "_contentPanel";
            _contentPanel.Padding = new Padding(20, 20, 20, 10);
            _contentPanel.Size = new Size(480, 190);
            _contentPanel.TabIndex = 1;
            //
            // _formLayout
            //
            _formLayout.BackColor = Color.White;
            _formLayout.ColumnCount = 2;
            _formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            _formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _formLayout.Controls.Add(_lblName, 0, 0);
            _formLayout.Controls.Add(_txtName, 1, 0);
            _formLayout.Controls.Add(_lblDescription, 0, 1);
            _formLayout.Controls.Add(_txtDescription, 1, 1);
            _formLayout.Dock = DockStyle.Fill;
            _formLayout.Location = new Point(20, 20);
            _formLayout.Name = "_formLayout";
            _formLayout.RowCount = 2;
            _formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            _formLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _formLayout.Size = new Size(440, 160);
            _formLayout.TabIndex = 0;
            //
            // _lblName
            //
            _lblName.Dock = DockStyle.Fill;
            _lblName.Font = new Font("Segoe UI", 10F);
            _lblName.ForeColor = Color.FromArgb(60, 60, 60);
            _lblName.Location = new Point(0, 0);
            _lblName.Margin = new Padding(0);
            _lblName.Name = "_lblName";
            _lblName.Size = new Size(110, 50);
            _lblName.TabIndex = 0;
            _lblName.Text = "Nombre *";
            _lblName.TextAlign = ContentAlignment.MiddleLeft;
            //
            // _txtName
            //
            _txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            _txtName.BackColor = Color.FromArgb(250, 250, 252);
            _txtName.BorderStyle = BorderStyle.FixedSingle;
            _txtName.Font = new Font("Segoe UI", 10F);
            _txtName.ForeColor = Color.FromArgb(30, 30, 30);
            _txtName.Location = new Point(113, 12);
            _txtName.Name = "_txtName";
            _txtName.Size = new Size(324, 25);
            _txtName.TabIndex = 1;
            //
            // _lblDescription
            //
            _lblDescription.Dock = DockStyle.Top;
            _lblDescription.Font = new Font("Segoe UI", 10F);
            _lblDescription.ForeColor = Color.FromArgb(60, 60, 60);
            _lblDescription.Location = new Point(0, 50);
            _lblDescription.Margin = new Padding(0);
            _lblDescription.Name = "_lblDescription";
            _lblDescription.Padding = new Padding(0, 12, 0, 0);
            _lblDescription.Size = new Size(110, 35);
            _lblDescription.TabIndex = 2;
            _lblDescription.Text = "Descripción";
            //
            // _txtDescription
            //
            _txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _txtDescription.BackColor = Color.FromArgb(250, 250, 252);
            _txtDescription.BorderStyle = BorderStyle.FixedSingle;
            _txtDescription.Font = new Font("Segoe UI", 10F);
            _txtDescription.ForeColor = Color.FromArgb(30, 30, 30);
            _txtDescription.Location = new Point(113, 60);
            _txtDescription.Margin = new Padding(3, 10, 3, 3);
            _txtDescription.Multiline = true;
            _txtDescription.Name = "_txtDescription";
            _txtDescription.ScrollBars = ScrollBars.Vertical;
            _txtDescription.Size = new Size(324, 97);
            _txtDescription.TabIndex = 3;
            //
            // _footerPanel
            //
            _footerPanel.BackColor = Color.FromArgb(248, 249, 251);
            _footerPanel.Controls.Add(_btnActions);
            _footerPanel.Dock = DockStyle.Fill;
            _footerPanel.Location = new Point(0, 250);
            _footerPanel.Margin = new Padding(0);
            _footerPanel.Name = "_footerPanel";
            _footerPanel.Padding = new Padding(20, 15, 20, 15);
            _footerPanel.Size = new Size(480, 70);
            _footerPanel.TabIndex = 2;
            //
            // _btnActions
            //
            _btnActions.Controls.Add(_btnOk);
            _btnActions.Controls.Add(_btnCancel);
            _btnActions.Dock = DockStyle.Right;
            _btnActions.FlowDirection = FlowDirection.RightToLeft;
            _btnActions.Location = new Point(220, 15);
            _btnActions.Name = "_btnActions";
            _btnActions.Size = new Size(240, 40);
            _btnActions.TabIndex = 0;
            _btnActions.WrapContents = false;
            //
            // _btnOk
            //
            _btnOk.BackColor = Color.FromArgb(24, 28, 36);
            _btnOk.Cursor = Cursors.Hand;
            _btnOk.FlatAppearance.BorderSize = 0;
            _btnOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(54, 62, 80);
            _btnOk.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 52, 66);
            _btnOk.FlatStyle = FlatStyle.Flat;
            _btnOk.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _btnOk.ForeColor = Color.White;
            _btnOk.Location = new Point(125, 0);
            _btnOk.Margin = new Padding(10, 0, 0, 0);
            _btnOk.Name = "_btnOk";
            _btnOk.Size = new Size(115, 38);
            _btnOk.TabIndex = 0;
            _btnOk.Text = "Guardar";
            _toolTip.SetToolTip(_btnOk, "Guardar usuario");
            _btnOk.UseVisualStyleBackColor = false;
            //
            // _btnCancel
            //
            _btnCancel.BackColor = Color.White;
            _btnCancel.Cursor = Cursors.Hand;
            _btnCancel.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            _btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 235, 235);
            _btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
            _btnCancel.FlatStyle = FlatStyle.Flat;
            _btnCancel.Font = new Font("Segoe UI", 10F);
            _btnCancel.ForeColor = Color.FromArgb(60, 60, 60);
            _btnCancel.Location = new Point(10, 0);
            _btnCancel.Margin = new Padding(10, 0, 0, 0);
            _btnCancel.Name = "_btnCancel";
            _btnCancel.Size = new Size(105, 38);
            _btnCancel.TabIndex = 1;
            _btnCancel.Text = "Cancelar";
            _toolTip.SetToolTip(_btnCancel, "Cancelar y cerrar");
            _btnCancel.UseVisualStyleBackColor = false;
            //
            // _toolTip
            //
            _toolTip.AutomaticDelay = 150;
            _toolTip.AutoPopDelay = 5000;
            _toolTip.InitialDelay = 150;
            _toolTip.ReshowDelay = 100;
            _toolTip.ShowAlways = true;
            //
            // UserEditForm
            //
            AcceptButton = _btnOk;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = _btnCancel;
            ClientSize = new Size(480, 320);
            Controls.Add(_rootLayout);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo usuario";
            _rootLayout.ResumeLayout(false);
            _headerPanel.ResumeLayout(false);
            _contentPanel.ResumeLayout(false);
            _formLayout.ResumeLayout(false);
            _formLayout.PerformLayout();
            _footerPanel.ResumeLayout(false);
            _btnActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _rootLayout;
        private System.Windows.Forms.Panel _headerPanel;
        private System.Windows.Forms.Label _lblTitle;
        private System.Windows.Forms.Panel _contentPanel;
        private System.Windows.Forms.TableLayoutPanel _formLayout;
        private System.Windows.Forms.Label _lblName;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label _lblDescription;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Panel _footerPanel;
        private System.Windows.Forms.FlowLayoutPanel _btnActions;
        private System.Windows.Forms.Button _btnOk;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.ToolTip _toolTip;
    }
}