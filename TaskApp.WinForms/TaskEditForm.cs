using TaskApp.Domain;

namespace TaskApp.WinForms;

/// <summary>
/// Formulario de edición/creación de tareas.
/// Permite crear nuevas tareas o editar tareas existentes en estado Pendiente.
/// </summary>
public partial class TaskEditForm : Form
{
    /// <summary>
    /// Modelo de la tarea que se está editando o creando.
    /// </summary>
    public TaskItem Model { get; private set; }

    /// <summary>
    /// Constructor del formulario de edición de tareas.
    /// </summary>
    /// <param name="existing">
    /// Tarea existente a editar. Si es null, se crea una nueva tarea.
    /// </param>
    public TaskEditForm(TaskItem? existing = null)
    {
        Model = existing is null
            ? new TaskItem { DueDate = DateOnly.FromDateTime(DateTime.Today.AddDays(1)) }
            : Clone(existing);

        InitializeComponent();
        ConfigureForm();
        SetComboBoxPriority();
        SetEvents();
        LoadModelToUi();
    }

    #region Inicialización

    /// <summary>
    /// Configura el título del formulario según si es nueva tarea o edición.
    /// </summary>
    private void ConfigureForm()
    {
        var isNewTask = Model.Id == 0;
        Text = isNewTask ? "Nueva tarea" : "Editar tarea";
        _lblTitle.Text = isNewTask ? "Nueva tarea" : "Editar tarea";
    }

    /// <summary>
    /// Inicializa el combobox de prioridades con los valores disponibles.
    /// </summary>
    private void SetComboBoxPriority()
    {
        _cmbPriority.Items.Add(new ComboItem<TaskPriority>(TaskPriority.Low, "Baja"));
        _cmbPriority.Items.Add(new ComboItem<TaskPriority>(TaskPriority.Medium, "Media"));
        _cmbPriority.Items.Add(new ComboItem<TaskPriority>(TaskPriority.High, "Alta"));
    }

    /// <summary>
    /// Establece los eventos de los botones del formulario.
    /// </summary>
    private void SetEvents()
    {
        _btnOk.Click += BtnOk_Click;
        _btnCancel.Click += BtnCancel_Click;
    }

    #endregion

    #region Eventos de los botones

    /// <summary>
    /// Maneja el evento Click del botón "Guardar".
    /// Valida los campos y guarda los datos en el modelo.
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento.</param>
    /// <param name="e">Datos del evento Click.</param>
    private void BtnOk_Click(object? sender, EventArgs e)
    {
        if (!TryReadUiToModel(out var err))
        {
            MessageBox.Show(err, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        DialogResult = DialogResult.OK;
        Close();
    }

    /// <summary>
    /// Maneja el evento Click del botón "Cancelar".
    /// Cierra el formulario sin guardar cambios.
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento.</param>
    /// <param name="e">Datos del evento Click.</param>
    private void BtnCancel_Click(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    #endregion

    #region Funciones de datos

    /// <summary>
    /// Carga los datos del modelo en los controles del formulario.
    /// </summary>
    private void LoadModelToUi()
    {
        _txtDescription.Text = Model.Description;
        _txtUser.Text = Model.AssignedUser;
        _dtDue.Value = Model.DueDate.ToDateTime(TimeOnly.MinValue);

        // Selecciona la prioridad correspondiente en el combobox
        for (int i = 0; i < _cmbPriority.Items.Count; i++)
        {
            if (_cmbPriority.Items[i] is ComboItem<TaskPriority> ci && ci.Value == Model.Priority)
            {
                _cmbPriority.SelectedIndex = i;
                break;
            }
        }

        // Si no se encontró la prioridad, selecciona Media por defecto
        if (_cmbPriority.SelectedIndex < 0) _cmbPriority.SelectedIndex = 1;

        _txtNotes.Text = Model.Notes ?? "";
    }

    /// <summary>
    /// Lee los valores de los controles del formulario y los asigna al modelo.
    /// Valida que los campos requeridos estén completos.
    /// </summary>
    /// <param name="error">Mensaje de error en caso de validación fallida.</param>
    /// <returns>True si la validación fue exitosa, false en caso contrario.</returns>
    private bool TryReadUiToModel(out string error)
    {
        error = "";

        var desc = _txtDescription.Text.Trim();
        var usr = _txtUser.Text.Trim();

        if (string.IsNullOrWhiteSpace(desc))
        {
            error = "La descripción es requerida.";
            return false;
        }
        if (string.IsNullOrWhiteSpace(usr))
        {
            error = "El usuario es requerido.";
            return false;
        }

        var pr = (_cmbPriority.SelectedItem as ComboItem<TaskPriority>)?.Value ?? TaskPriority.Medium;

        Model.Description = desc;
        Model.AssignedUser = usr;
        Model.Priority = pr;
        Model.DueDate = DateOnly.FromDateTime(_dtDue.Value.Date);
        Model.Notes = string.IsNullOrWhiteSpace(_txtNotes.Text) ? null : _txtNotes.Text.Trim();

        return true;
    }

    /// <summary>
    /// Crea una copia del objeto TaskItem para edición.
    /// Evita modificar el objeto original hasta confirmar los cambios.
    /// </summary>
    /// <param name="x">Objeto de la tarea a clonar.</param>
    /// <returns>Nueva instancia de TaskItem con los mismos valores.</returns>
    private static TaskItem Clone(TaskItem x) => new()
    {
        Id = x.Id,
        Description = x.Description,
        AssignedUser = x.AssignedUser,
        Status = x.Status,
        Priority = x.Priority,
        DueDate = x.DueDate,
        Notes = x.Notes,
        CreatedAtUtc = x.CreatedAtUtc,
        UpdatedAtUtc = x.UpdatedAtUtc
    };

    #endregion

    #region Nested Types

    /// <summary>
    /// Clase auxiliar para representar items en un ComboBox con valor y texto.
    /// </summary>
    /// <typeparam name="T">Tipo del valor del item.</typeparam>
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
