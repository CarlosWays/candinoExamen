namespace candinoExamen.Vistas;

public partial class Resumen : ContentPage
{
	public Resumen(string usuario, string nombre, string apellido, int edad, DateTime fecha, string ciudad,
        string pais, double montoinicial, double pagomensual, double pagototal)
	{
		InitializeComponent();
        lblUsuario.Text = usuario;
        txtNombreR.Text = nombre;
        txtApellidoR.Text = apellido;
        txtEdadR.Text = edad.ToString();
        txtFechar.Text = fecha.ToString();
        txtCiudadR.Text = ciudad.ToString();
        txtPaisR.Text = pais.ToString();
        txtMInicialR.Text = montoinicial.ToString();
        txtPMensualR.Text = pagomensual.ToString();
        txtPagoTotalR.Text = pagototal.ToString();

    }

    private void btnCerrarSesion_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Login());
    }
}