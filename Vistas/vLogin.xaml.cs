namespace dgalvezT2.Vistas;

public partial class vLogin : ContentPage
{
	string[] usuarios = { "Carlos", "Ana", "Jose" };
	string[] contrasenas = {"carlos123","ana123","jose123"};
	public vLogin()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
		string usuarioIngresado = txtUsario.Text;
		string contrasenaIngresada = txtContrasena.Text;

		bool credencialesValidas = false;

		for (int i = 0; i < usuarios.Length; i++)
		{
			if (usuarios[i] == usuarioIngresado && contrasenas[i] == contrasenaIngresada)
			{
				credencialesValidas = true;
				DisplayAlert("Bienvenid@ "+ usuarioIngresado, usuarioIngresado+ " Ingresaste corectamente al simulador de notas Uisrael ", "Aceptar");
				Navigation.PushAsync(new vNotas());
			}
		}
		if(!credencialesValidas)
		{
			DisplayAlert("Error", "Usuario o contraseña incorrectos", "Aceptar");
		}
			
    }
}