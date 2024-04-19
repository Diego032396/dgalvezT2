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
				DisplayAlert("bienvenido", "ingresaste corectamento" + usuarioIngresado, "ok");
				Navigation.PushAsync(new MainPage());
			}
		}
		if(!credencialesValidas)
		{
			DisplayAlert("Error", "usuario o contraseña incorrectos", "ok");
		}
		
		
    }
}