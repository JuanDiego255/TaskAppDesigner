using System.ComponentModel;
using TaskApp.Domain;

namespace TaskApp.WinForms;

public partial class TaskAppForm : Form
{
    private readonly MainViewModel _vm;
    private readonly UserViewModel _uvm;
    private readonly BindingSource _bs = new();
    private readonly BindingSource _userBs = new();
    private readonly System.Windows.Forms.Timer _filterTimer = new();
    private readonly System.Windows.Forms.Timer _userFilterTimer = new();

    /// <summary>
    /// Color activo para el botón del sidebar seleccionado.
    /// </summary>
    private static readonly Color SideActiveColor = Color.FromArgb(45, 52, 66);
    /// <summary>
    /// Color inactivo para los botones del sidebar.
    /// </summary>
    private static readonly Color SideInactiveColor = Color.FromArgb(32, 37, 48);

    public TaskAppForm(MainViewModel vm, UserViewModel uvm)
    {
        InitializeComponent();
        _vm = vm;
        _uvm = uvm;

        ConfigureFilterTimer();
        ConfigureUserFilterTimer();
        SetComboBoxes();
        SetEvents();

        _bs.DataSource = _vm.Items;
        _grid.DataSource = _bs;

        _userBs.DataSource = _uvm.Items;
        _userGrid.DataSource = _userBs;

        // Estado inicial: vista de tareas activa
        HighlightSideButton(_btnTareas);
    }

    protected override async void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        await ReloadGridAsync();
    }

    #region Inicialización
    /// <summary>
    /// Establece un timer que permite no aplicar los filtros al instante en que se presiona una tecla.
    /// </summary>
    private void ConfigureFilterTimer()
    {
        _filterTimer.Interval = 350;
        _filterTimer.Tick += async (_, __) =>
        {
            _filterTimer.Stop();
            await ReloadGridAsync();
        };
    }
    /// <summary>
    /// Establece un timer para los filtros de usuarios.
    /// </summary>
    private void ConfigureUserFilterTimer()
    {
        _userFilterTimer.Interval = 350;
        _userFilterTimer.Tick += async (_, __) =>
        {
            _userFilterTimer.Stop();
            await ReloadUserGridAsync();
        };
    }
    /// <summary>
    /// Se inicializan los combos de los filtros.
    /// </summary>
    private void SetComboBoxes()
    {
        _cmbStatus.Items.Add(new ComboItem<TaskStatusApp?>(null, "Todos los estados"));
        _cmbStatus.Items.Add(new ComboItem<TaskStatusApp>(TaskStatusApp.Pending, "Pendiente"));
        _cmbStatus.Items.Add(new ComboItem<TaskStatusApp>(TaskStatusApp.InProgress, "En proceso"));
        _cmbStatus.Items.Add(new ComboItem<TaskStatusApp>(TaskStatusApp.Done, "Finalizada"));
        _cmbStatus.SelectedIndex = 0;

        _cmbPriority.Items.Add(new ComboItem<TaskPriority?>(null, "Todas las prioridades"));
        _cmbPriority.Items.Add(new ComboItem<TaskPriority>(TaskPriority.Low, "Baja"));
        _cmbPriority.Items.Add(new ComboItem<TaskPriority>(TaskPriority.Medium, "Media"));
        _cmbPriority.Items.Add(new ComboItem<TaskPriority>(TaskPriority.High, "Alta"));
        _cmbPriority.SelectedIndex = 0;
    }
    /// <summary>
    /// Se establecen los eventos a cada uno de los controles.
    /// </summary>
    private void SetEvents()
    {
        // Filter events (Tasks)
        _txtSearch.TextChanged += (_, __) => DebounceReload();
        _txtUser.TextChanged += (_, __) => DebounceReload();
        _cmbStatus.SelectedIndexChanged += (_, __) => DebounceReload();
        _cmbPriority.SelectedIndexChanged += (_, __) => DebounceReload();

        // Filter events (Users)
        _txtUserSearch.TextChanged += (_, __) => DebounceUserReload();

        // Grid events (Tasks)
        _grid.SelectionChanged += (_, __) => UpdateActionButtons();
        _grid.CellFormatting += Grid_CellFormatting;
        _grid.CellPainting += Grid_CellPainting_AppChips;
        _grid.CellDoubleClick += Grid_CellDoubleClick;

        // Grid events (Users)
        _userGrid.SelectionChanged += (_, __) => UpdateUserActionButtons();
        _userGrid.CellDoubleClick += UserGrid_CellDoubleClick;

        // Grid card paint events for rounded border
        _gridCard.Paint += GridCard_Paint;
        _userGridCard.Paint += UserGridCard_Paint;

        // Task button events
        _btnRefresh.Click += BtnRefresh_Click;
        _btnNew.Click += BtnNew_Click;
        _btnEdit.Click += BtnEdit_Click;
        _btnDelete.Click += BtnDelete_Click;
        _btnToInProgress.Click += BtnToInProgress_Click;
        _btnToDone.Click += BtnToDone_Click;

        // User button events
        _btnNewUser.Click += BtnNewUser_Click;
        _btnEditUser.Click += BtnEditUser_Click;
        _btnDeleteUser.Click += BtnDeleteUser_Click;
        _btnRefreshUser.Click += BtnRefreshUser_Click;

        // Sidebar navigation events
        _btnTareas.Click += BtnTareas_Click;
        _btnUsuarios.Click += BtnUsuarios_Click;

        // Initial button state
        UpdateActionButtons();
    }

    #endregion

    #region Navegación Sidebar
    /// <summary>
    /// Muestra la vista de tareas y oculta la de usuarios.
    /// </summary>
    private async void BtnTareas_Click(object? sender, EventArgs e)
    {
        ShowTaskView();
        await ReloadGridAsync();
    }
    /// <summary>
    /// Muestra la vista de usuarios y oculta la de tareas.
    /// </summary>
    private async void BtnUsuarios_Click(object? sender, EventArgs e)
    {
        ShowUserView();
        await ReloadUserGridAsync();
    }
    /// <summary>
    /// Alterna la visibilidad de los paneles de contenido para mostrar tareas.
    /// </summary>
    private void ShowTaskView()
    {
        _lblTitle.Text = "Administrador de tareas";

        // Toggle content panels
        _contentLayout.Visible = true;
        _userContentLayout.Visible = false;

        // Toggle toolbar
        _navActions.Visible = true;
        _navActionsUser.Visible = false;

        // Ajustar row styles del content wrapper
        _contentWrapper.RowStyles[1] = new RowStyle(SizeType.Percent, 100F);
        _contentWrapper.RowStyles[2] = new RowStyle(SizeType.Percent, 0F);

        HighlightSideButton(_btnTareas);
    }
    /// <summary>
    /// Alterna la visibilidad de los paneles de contenido para mostrar usuarios.
    /// </summary>
    private void ShowUserView()
    {
        _lblTitle.Text = "Administrador de usuarios";

        // Toggle content panels
        _contentLayout.Visible = false;
        _userContentLayout.Visible = true;

        // Toggle toolbar
        _navActions.Visible = false;
        _navActionsUser.Visible = true;

        // Ajustar row styles del content wrapper
        _contentWrapper.RowStyles[1] = new RowStyle(SizeType.Percent, 0F);
        _contentWrapper.RowStyles[2] = new RowStyle(SizeType.Percent, 100F);

        HighlightSideButton(_btnUsuarios);
    }
    /// <summary>
    /// Resalta el botón del sidebar seleccionado y desactiva los demás.
    /// </summary>
    private void HighlightSideButton(Button active)
    {
        _btnTareas.BackColor = SideInactiveColor;
        _btnUsuarios.BackColor = SideInactiveColor;
        active.BackColor = SideActiveColor;
    }

    #endregion

    #region Funciones de datos (Tareas)
    /// <summary>
    /// Recarga los datos en el grid según los filtros seleccionados.
    /// </summary>
    private async Task ReloadGridAsync()
    {
        _vm.FilterText = string.IsNullOrWhiteSpace(_txtSearch.Text) ? null : _txtSearch.Text.Trim();
        _vm.FilterUser = string.IsNullOrWhiteSpace(_txtUser.Text) ? null : _txtUser.Text.Trim();
        _vm.FilterStatus = _cmbStatus.SelectedItem is ComboItem<TaskStatusApp> s ? s.Value : null;
        _vm.FilterPriority = _cmbPriority.SelectedItem is ComboItem<TaskPriority> p ? p.Value : null;

        try
        {
            UseWaitCursor = true;
            await _vm.ReloadAsync();
            _bs.ResetBindings(false);
            UpdateActionButtons();
        }
        finally
        {
            UseWaitCursor = false;
        }
    }
    /// <summary>
    /// Ejecuta el timer, da un pequeño lapso entre presionar una tecla y el reload.
    /// </summary>
    private void DebounceReload()
    {
        _filterTimer.Stop();
        _filterTimer.Start();
    }

    #endregion

    #region Funciones de datos (Usuarios)
    /// <summary>
    /// Recarga los datos en el grid de usuarios según el filtro de nombre.
    /// </summary>
    private async Task ReloadUserGridAsync()
    {
        _uvm.FilterUser = string.IsNullOrWhiteSpace(_txtUserSearch.Text) ? null : _txtUserSearch.Text.Trim();

        try
        {
            UseWaitCursor = true;
            await _uvm.ReloadAsyncUser();
            _userBs.ResetBindings(false);
            UpdateUserActionButtons();
        }
        finally
        {
            UseWaitCursor = false;
        }
    }
    /// <summary>
    /// Ejecuta el timer de usuarios.
    /// </summary>
    private void DebounceUserReload()
    {
        _userFilterTimer.Stop();
        _userFilterTimer.Start();
    }

    #endregion

    #region Eventos de los botones (Tareas)
    /// <summary>
    /// Refresca el gridView.
    /// </summary>
    private async void BtnRefresh_Click(object? sender, EventArgs e)
    {
        _btnRefresh.Enabled = false;
        try { await ReloadGridAsync(); }
        finally { _btnRefresh.Enabled = true; }
    }
    /// <summary>
    /// Maneja el evento Click del botón "Nuevo".
    /// Abre el formulario de edición, crea la tarea y recarga el grid.
    /// </summary>
    /// <param name="sender">
    /// Objeto que dispara el evento (normalmente el Button).
    /// </param>
    /// <param name="e">
    /// Datos del evento Click. No contiene información adicional.
    /// </param>
    private async void BtnNew_Click(object? sender, EventArgs e)
    {
        var dlg = new TaskEditForm(_uvm);
        if (dlg.ShowDialog(this) != DialogResult.OK) return;

        try
        {
            await _vm.CreateAsync(dlg.Model);
            await ReloadGridAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    /// <summary>
    /// Maneja el evento Click del botón "Editar".
    /// Abre el formulario de edición, actualiza la tarea y recarga el grid.
    /// </summary>
    /// <param name="sender">
    /// Objeto que dispara el evento (normalmente el Button).
    /// </param>
    /// <param name="e">
    /// Datos del evento Click. No contiene información adicional.
    /// </param>
    private async void BtnEdit_Click(object? sender, EventArgs e)
    {
        var selected = GetSelected();
        if (selected is null) return;

        if (selected.Status != TaskStatusApp.Pending)
        {
            MessageBox.Show("Solo se puede editar si está en estado Pendiente.", "Regla",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var dlg = new TaskEditForm(_uvm, selected);
        if (dlg.ShowDialog(this) != DialogResult.OK) return;

        try
        {
            await _vm.UpdateAsync(dlg.Model);
            await ReloadGridAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    /// <summary>
    /// Maneja el evento Click del botón "Eliminar".
    /// Elimina la tarea luego de un pequeño diálogo de confirmación.
    /// </summary>
    /// <param name="sender">
    /// Objeto que dispara el evento (normalmente el Button).
    /// </param>
    /// <param name="e">
    /// Datos del evento Click. No contiene información adicional.
    /// </param>
    private async void BtnDelete_Click(object? sender, EventArgs e)
    {
        var selected = GetSelected();
        if (selected is null) return;

        if (selected.Status == TaskStatusApp.InProgress)
        {
            MessageBox.Show("No se puede eliminar una tarea si está En proceso.", "Regla",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var ok = MessageBox.Show("¿Eliminar la tarea seleccionada?", "Confirmar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (ok != DialogResult.Yes) return;

        try
        {
            await _vm.DeleteAsync(selected.Id);
            await ReloadGridAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    /// <summary>
    /// Maneja el evento Click del botón "En Progreso".
    /// Cambia el estado de una tarea pendiente a "En Progeso".
    /// </summary>
    /// <param name="sender">
    /// Objeto que dispara el evento (normalmente el Button).
    /// </param>
    /// <param name="e">
    /// Datos del evento Click. No contiene información adicional.
    /// </param>
    private async void BtnToInProgress_Click(object? sender, EventArgs e)
    {
        var selected = GetSelected();
        if (selected is null) return;

        try
        {
            await _vm.ChangeStatusAsync(selected.Id, TaskStatusApp.InProgress);
            await ReloadGridAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Regla", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    /// <summary>
    /// Maneja el evento Click del botón "Finalizado".
    /// Cambia el estado de una tarea En Progreso a "Finalizada".
    /// </summary>
    /// <param name="sender">
    /// Objeto que dispara el evento (normalmente el Button).
    /// </param>
    /// <param name="e">
    /// Datos del evento Click. No contiene información adicional.
    /// </param>
    private async void BtnToDone_Click(object? sender, EventArgs e)
    {
        var selected = GetSelected();
        if (selected is null) return;

        try
        {
            await _vm.ChangeStatusAsync(selected.Id, TaskStatusApp.Done);
            await ReloadGridAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Regla", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    #endregion

    #region Eventos de los botones (Usuarios)
    /// <summary>
    /// Refresca el gridView de usuarios.
    /// </summary>
    private async void BtnRefreshUser_Click(object? sender, EventArgs e)
    {
        _btnRefreshUser.Enabled = false;
        try { await ReloadUserGridAsync(); }
        finally { _btnRefreshUser.Enabled = true; }
    }
    /// <summary>
    /// Abre el formulario para crear un nuevo usuario.
    /// </summary>
    private async void BtnNewUser_Click(object? sender, EventArgs e)
    {
        var dlg = new UserEditForm();
        if (dlg.ShowDialog(this) != DialogResult.OK) return;

        try
        {
            await _uvm.CreateAsync(dlg.Model);
            await ReloadUserGridAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    /// <summary>
    /// Abre el formulario para editar el usuario seleccionado.
    /// </summary>
    private async void BtnEditUser_Click(object? sender, EventArgs e)
    {
        var selected = GetSelectedUser();
        if (selected is null) return;

        var dlg = new UserEditForm(selected);
        if (dlg.ShowDialog(this) != DialogResult.OK) return;

        try
        {
            await _uvm.UpdateAsync(dlg.Model);
            await ReloadUserGridAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    /// <summary>
    /// Elimina el usuario seleccionado luego de confirmación.
    /// </summary>
    private async void BtnDeleteUser_Click(object? sender, EventArgs e)
    {
        var selected = GetSelectedUser();
        if (selected is null) return;       

        var ok = MessageBox.Show("¿Eliminar el usuario seleccionado?", "Confirmar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (ok != DialogResult.Yes) return;

        try
        {
            var count = _uvm.GetTareasById(selected.Id).Result;
            if(count > 0)
            {
                MessageBox.Show("Este usuario tiene tareas asignadas, no es posible eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            await _uvm.DeleteAsync(selected.Id);
            await ReloadUserGridAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #endregion

    #region Eventos del Grid (Tareas)
    /// <summary>
    /// Despliega el formulario de edición siempre y cuando esté en pendiente, esto al presionar doble click sobre una fila del grid.
    /// </summary>
    /// <param name="sender">
    /// Objeto que dispara el evento (normalmente el Button).
    /// </param>
    /// <param name="e">
    /// Datos del evento Click. No contiene información adicional.
    /// </param>
    private void Grid_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        var item = GetSelectedSilent();
        if (item is null) return;

        if (item.Status != TaskStatusApp.Pending)
        {
            MessageBox.Show("Solo se puede editar si está en estado Pendiente.", "Regla",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        _btnEdit.PerformClick();
    }
    /// <summary>
    /// Crea un formato para cada celda de estado y prioridad según el valor de cada celda.
    /// </summary>
    /// <param name="sender">
    /// Objeto que dispara el evento (normalmente el Button).
    /// </param>
    /// <param name="e">
    /// Datos del evento Click. No contiene información adicional.
    /// </param>
    private void Grid_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (_grid.Columns[e.ColumnIndex].DataPropertyName == nameof(TaskItem.Status))
        {
            var item = _grid.Rows[e.RowIndex].DataBoundItem as TaskItem;
            if (item is null) return;

            e.Value = item.Status switch
            {
                TaskStatusApp.Pending => "Pendiente",
                TaskStatusApp.InProgress => "En proceso",
                TaskStatusApp.Done => "Finalizada",
                _ => item.Status.ToString()
            };

            var style = _grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style;
            style.BackColor = item.Status switch
            {
                TaskStatusApp.Pending => Color.FromArgb(255, 250, 205),
                TaskStatusApp.InProgress => Color.FromArgb(224, 242, 255),
                TaskStatusApp.Done => Color.FromArgb(225, 245, 225),
                _ => Color.White
            };
            style.ForeColor = Color.Black;
            style.SelectionForeColor = Color.Black;

            e.FormattingApplied = true;
        }

        if (_grid.Columns[e.ColumnIndex].DataPropertyName == nameof(TaskItem.Priority))
        {
            var item = _grid.Rows[e.RowIndex].DataBoundItem as TaskItem;
            if (item is null) return;

            e.Value = item.Priority switch
            {
                TaskPriority.Low => "Baja",
                TaskPriority.Medium => "Media",
                TaskPriority.High => "Alta",
                _ => item.Priority.ToString()
            };

            var style = _grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style;
            style.BackColor = item.Priority switch
            {
                TaskPriority.High => Color.FromArgb(255, 230, 230),
                TaskPriority.Medium => Color.FromArgb(245, 245, 245),
                TaskPriority.Low => Color.FromArgb(235, 245, 255),
                _ => Color.White
            };
            style.ForeColor = Color.Black;
            style.SelectionForeColor = Color.Black;

            e.FormattingApplied = true;
        }
    }
    /// <summary>
    /// Crea una figura circular para cada celda de estado y prioridad según el valor de cada celda.
    /// Modifica el color de la fuente el background de la figura
    /// </summary>
    /// <param name="sender">
    /// Objeto que dispara el evento (normalmente el Button).
    /// </param>
    /// <param name="e">
    /// Datos del evento Click. No contiene información adicional.
    /// </param>
    private void Grid_CellPainting_AppChips(object? sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var grid = (DataGridView)sender!;
        var colName = grid.Columns[e.ColumnIndex].Name;
        if (colName != "_colStatus" && colName != "_colPriority") return;

        e.Handled = true;
        e.PaintBackground(e.ClipBounds, true);

        var text = Convert.ToString(e.FormattedValue) ?? "";
        Color back, fore, border;

        if (colName == "_colStatus")
        {
            if (text.Contains("Pendiente", StringComparison.OrdinalIgnoreCase))
                (back, fore, border) = (Color.FromArgb(255, 244, 229), Color.FromArgb(146, 83, 8), Color.FromArgb(255, 221, 179));
            else if (text.Contains("En Proceso", StringComparison.OrdinalIgnoreCase))
                (back, fore, border) = (Color.FromArgb(232, 240, 254), Color.FromArgb(26, 77, 170), Color.FromArgb(200, 220, 250));
            else
                (back, fore, border) = (Color.FromArgb(232, 247, 239), Color.FromArgb(30, 120, 70), Color.FromArgb(195, 235, 215));
        }
        else
        {
            if (text.Contains("Alta", StringComparison.OrdinalIgnoreCase))
                (back, fore, border) = (Color.FromArgb(255, 235, 238), Color.FromArgb(168, 26, 45), Color.FromArgb(255, 200, 208));
            else if (text.Contains("Media", StringComparison.OrdinalIgnoreCase))
                (back, fore, border) = (Color.FromArgb(244, 239, 255), Color.FromArgb(95, 55, 170), Color.FromArgb(225, 213, 255));
            else
                (back, fore, border) = (Color.FromArgb(240, 244, 248), Color.FromArgb(60, 70, 85), Color.FromArgb(220, 228, 238));
        }

        var g = e.Graphics;
        g!.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        var font = grid.DefaultCellStyle.Font ?? grid.Font;
        var textSize = TextRenderer.MeasureText(text, font);

        int padX = 10;
        int chipW = Math.Min(e.CellBounds.Width - 18, textSize.Width + padX * 2);
        int chipH = Math.Min(e.CellBounds.Height - 10, 26);

        int chipX = e.CellBounds.X + (e.CellBounds.Width - chipW) / 2;
        int chipY = e.CellBounds.Y + (e.CellBounds.Height - chipH) / 2;

        var chipRect = new Rectangle(chipX, chipY, chipW, chipH);

        using var bBack = new SolidBrush(back);
        using var pBorder = new Pen(border, 1);
        using var path = RoundedRect(chipRect, 12);

        g.FillPath(bBack, path);
        g.DrawPath(pBorder, path);

        TextRenderer.DrawText(
            g,
            text,
            font,
            chipRect,
            fore,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis
        );

        using var rowLine = new Pen(Color.FromArgb(235, 238, 242), 1);
        g.DrawLine(rowLine, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);

        if ((e.State & DataGridViewElementStates.Selected) != 0)
            ControlPaint.DrawFocusRectangle(g, e.CellBounds);
    }
    /// <summary>
    /// Crea un estilo moderno con borde circular para el gridView de tareas.
    /// </summary>
    private void GridCard_Paint(object? sender, PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        var rect = _gridCard.ClientRectangle;
        rect.Inflate(-1, -1);

        using var pen = new Pen(Color.FromArgb(230, 234, 240), 1);
        using var path = RoundedRect(rect, 16);
        g.DrawPath(pen, path);
    }

    #endregion

    #region Eventos del Grid (Usuarios)
    /// <summary>
    /// Doble click en el grid de usuarios abre el formulario de edición.
    /// </summary>
    private void UserGrid_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        _btnEditUser.PerformClick();
    }
    /// <summary>
    /// Crea un estilo moderno con borde circular para el gridView de usuarios.
    /// </summary>
    private void UserGridCard_Paint(object? sender, PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        var rect = _userGridCard.ClientRectangle;
        rect.Inflate(-1, -1);

        using var pen = new Pen(Color.FromArgb(230, 234, 240), 1);
        using var path = RoundedRect(rect, 16);
        g.DrawPath(pen, path);
    }

    #endregion

    #region Funciones privadas
    /// <summary>
    /// Verifica que haya una fila seleccionada al presionar un botón, obtiene los datos de la fila
    /// </summary>
    private TaskItem? GetSelected()
    {
        if (_grid.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleccioná una fila primero.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }
        return _grid.SelectedRows[0].DataBoundItem as TaskItem;
    }

    private TaskItem? GetSelectedSilent()
    {
        if (_grid.SelectedRows.Count == 0) return null;
        return _grid.SelectedRows[0].DataBoundItem as TaskItem;
    }
    /// <summary>
    /// Verifica que haya una fila seleccionada en el grid de usuarios.
    /// </summary>
    private UserItem? GetSelectedUser()
    {
        if (_userGrid.SelectedRows.Count == 0)
        {
            MessageBox.Show("Seleccioná una fila primero.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }
        return _userGrid.SelectedRows[0].DataBoundItem as UserItem;
    }

    private UserItem? GetSelectedUserSilent()
    {
        if (_userGrid.SelectedRows.Count == 0) return null;
        return _userGrid.SelectedRows[0].DataBoundItem as UserItem;
    }
    /// <summary>
    /// Cambia el estado Enable del botón según el estado de la fila seleccionada.
    /// </summary>
    private void UpdateActionButtons()
    {
        var item = GetSelectedSilent();
        var has = item is not null;

        _btnEdit.Enabled = has && item!.Status == TaskStatusApp.Pending;
        _btnDelete.Enabled = has && item!.Status != TaskStatusApp.InProgress;
        _btnToInProgress.Enabled = has && item!.Status == TaskStatusApp.Pending;
        _btnToDone.Enabled = has && item!.Status == TaskStatusApp.InProgress;
    }
    /// <summary>
    /// Cambia el estado Enable de los botones de usuario según si hay fila seleccionada.
    /// </summary>
    private void UpdateUserActionButtons()
    {
        var item = GetSelectedUserSilent();
        var has = item is not null;

        _btnEditUser.Enabled = has;
        _btnDeleteUser.Enabled = has;
    }

    private static System.Drawing.Drawing2D.GraphicsPath RoundedRect(Rectangle r, int radius)
    {
        var path = new System.Drawing.Drawing2D.GraphicsPath();
        int d = radius * 2;

        path.AddArc(r.X, r.Y, d, d, 180, 90);
        path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
        path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
        path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }

    #endregion

    #region Nested Types

    private sealed class ComboItem<T>
    {
        public T Value { get; }
        public string Text { get; }

        public ComboItem(T value, string text)
        {
            Value = value;
            Text = text;
        }

        public override string ToString() => Text;
    }

    #endregion
}