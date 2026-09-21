using System.Net.Http.Json;

namespace ApiNaruto.WinForms;

public partial class Form1 : Form
{
    private const string ApiBaseUrl = "https://tarea5-clientes-fvd2fjdhfpd7g0au.mexicocentral-01.azurewebsites.net/";

    private static readonly HttpClient _http = new()
    {
        BaseAddress = new Uri(ApiBaseUrl)
    };

    public Form1()
    {
        InitializeComponent();
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        await CargarPersonajesAsync();
    }

    private async void btnActualizar_Click(object sender, EventArgs e)
    {
        await CargarPersonajesAsync();
    }

    private async void btnGuardar_Click(object sender, EventArgs e)
    {
        await GuardarPersonajeAsync();
    }

    private async Task CargarPersonajesAsync()
    {
        try
        {
            SetOcupado(true, "Cargando personajes...");

            var personajes = await _http.GetFromJsonAsync<List<Personaje>>("api/Personajes");

            dvgPersonajes.DataSource = personajes;
            lblEstado.Text = $"{personajes?.Count ?? 0} personajes cargados.";
        }
        catch (Exception ex)
        {
            lblEstado.Text = "Error al cargar.";
            MessageBox.Show($"No se pudo cargar la lista:\n{ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            SetOcupado(false);
        }
    }

    private async Task GuardarPersonajeAsync()
    {
        
        if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtClan.Text) ||
            string.IsNullOrWhiteSpace(txtAldea.Text) ||
            string.IsNullOrWhiteSpace(txtTipoChakra.Text))
        {
            MessageBox.Show("Completa todos los campos.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var nuevo = new Personaje
        {
            Nombre = txtNombre.Text.Trim(),
            Clan = txtClan.Text.Trim(),
            Aldea = txtAldea.Text.Trim(),
            TipoChakra = txtTipoChakra.Text.Trim()
        };

        try
        {
            SetOcupado(true, "Guardando...");

            var respuesta = await _http.PostAsJsonAsync("api/Personajes", nuevo);
        
            string cuerpo = await respuesta.Content.ReadAsStringAsync();

            if (respuesta.IsSuccessStatusCode)
            {
                LimpiarCampos();
                await CargarPersonajesAsync();
                lblEstado.Text = cuerpo;
            }
            else
            {
                MessageBox.Show($"La API respondió {(int)respuesta.StatusCode}:\n{cuerpo}",
                    "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"No se pudo conectar con la API:\n{ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            SetOcupado(false);
        }
    }

    private void LimpiarCampos()
    {
        txtNombre.Clear();
        txtClan.Clear();
        txtAldea.Clear();
        txtTipoChakra.Clear();
        txtNombre.Focus();
    }

    private void SetOcupado(bool ocupado, string? mensaje = null)
    {
        btnGuardar.Enabled = !ocupado;
        btnActualizar.Enabled = !ocupado;
        UseWaitCursor = ocupado;
        if (mensaje != null) lblEstado.Text = mensaje;
    }
}