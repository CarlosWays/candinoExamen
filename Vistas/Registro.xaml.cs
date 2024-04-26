namespace candinoExamen.Vistas;

public partial class Registro : ContentPage
{

    string usuarioResumen;
    double costocurso = 1500;
    double cuatroporciento = 60;
    double montoPagoMensual;
    double montoInicial;
    double pagototal;

    public Registro(string usuario)
	{
		InitializeComponent();
        DisplayAlert("Alerta", "Bienvenido/a " + usuario, "Cerrar");
        lblUsuario.Text = "Usuario conectado: " + usuario;
        usuarioResumen = usuario;
    }

    private void btnCalcularPM_Clicked(object sender, EventArgs e)
    {
        montoInicial = Convert.ToDouble(txtMontoInicial.Text);
        if (montoInicial <= 0 || montoInicial > costocurso)
        {
            DisplayAlert("Alerta", "Ingrese correctamente los valores", "Salir");
        }
        else
        {
            double montoCalculo = costocurso - montoInicial;
            double montoDividido = montoCalculo / 4;
            montoPagoMensual = montoDividido + cuatroporciento;
            txtPagoMensual.Text = montoPagoMensual.ToString();
            pagototal = (montoPagoMensual * 4) + montoInicial;
        }
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        int edad = Convert.ToInt32(txtEdad.Text);
        DateTime fecha = dpFecha.Date;
        string ciudad = pkCiudad.SelectedItem.ToString();
        string pais = pkPais.SelectedItem.ToString();

        Resumen resumenPage = new Resumen(usuarioResumen, nombre, apellido, edad, fecha, ciudad, pais, montoInicial, montoPagoMensual, pagototal);

        Navigation.PushAsync(resumenPage);
    }
}