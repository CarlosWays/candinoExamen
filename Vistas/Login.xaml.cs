namespace candinoExamen.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string[] strUsuarios = {"estudiante2024", "examen1", "NombreEstudiante"};
        string[] strContrase�as = { "uisrael2024", "parcial1", "2024"};

        if(txtUsuario.Text == strUsuarios[0] && txtcontrase�a.Text == strContrase�as[0])
        {
            Navigation.PushAsync(new Registro(strUsuarios[0]));
        }
        else if (txtUsuario.Text == strUsuarios[1] && txtcontrase�a.Text == strContrase�as[1])
        {
            Navigation.PushAsync(new Registro(strUsuarios[1]));
        }
        else if (txtUsuario.Text == strUsuarios[2] && txtcontrase�a.Text == strContrase�as[2])
        {
            Navigation.PushAsync(new Registro(strUsuarios[2]));
        }
        else
        {
            DisplayAlert("Atenci�n", "Usuario/Contrase�a incorrectos", "Cerrar");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AcercaDe());
    }
}