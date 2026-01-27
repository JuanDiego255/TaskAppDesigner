using TaskApp.Domain;

namespace TaskApp.WinForms;

/// <summary>
/// Formulario de edición/creación de usuarios.
/// Permite crear nuevos usuarios o editar usuarios existentes.
/// </summary>
public partial class UserEditForm : Form
{
    /// <summary>
    /// Modelo del usuario que se está editando o creando.
    /// </summary>
    public UserItem Model { get; private set; }

    /// <summary>
    /// Constructor del formulario de edición de usuarios.
    /// </summary>
    /// <param name="existing">
    /// Usuario existente a editar. Si es null, se crea un nuevo usuario.
    /// </param>
    public UserEditForm(UserItem? existing = null)
    {
        Model = existing is null
            ? new UserItem()
            : Clone(existing);

        InitializeComponent();
        ConfigureForm();
        SetEvents();
        LoadModelToUi();
    }

    #region Inicialización

    /// <summary>
    /// Configura el título del formulario según si es nuevo usuario o edición.
    /// </summary>
    private void ConfigureForm()
    {
        var isNew = Model.Id == 0;
        Text = isNew ? "Nuevo usuario" : "Editar usuario";
        _lblTitle.Text = isNew ? "Nuevo usuario" : "Editar usuario";
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
        _txtName.Text = Model.Name;
        _txtDescription.Text = Model.Description ?? "";
    }

    /// <summary>
    /// Lee los valores de los controles del formulario y los asigna al modelo.
    /// Valida que los campos requeridos estén completos.
    /// </summary>
    private bool TryReadUiToModel(out string error)
    {
        error = "";

        var name = _txtName.Text.Trim();

        if (string.IsNullOrWhiteSpace(name))
        {
            error = "El nombre es requerido.";
            return false;
        }

        Model.Name = name;
        Model.Description = string.IsNullOrWhiteSpace(_txtDescription.Text)
            ? ""
            : _txtDescription.Text.Trim();

        return true;
    }

    /// <summary>
    /// Crea una copia del objeto UserItem para edición.
    /// Evita modificar el objeto original hasta confirmar los cambios.
    /// </summary>
    private static UserItem Clone(UserItem x) => new()
    {
        Id = x.Id,
        Name = x.Name,
        Description = x.Description,
        CreatedAtUtc = x.CreatedAtUtc,
        UpdatedAtUtc = x.UpdatedAtUtc
    };

    #endregion
}