namespace UI_Ejercicio1_U6_DI;

public partial class MainPage : ContentPage
{
    bool btnBoton3Creado = false;
	public MainPage()
	{
		InitializeComponent();
	}

	private void btnBoton2_Clicked(object sender, EventArgs e)
	{
        if (!btnBoton3Creado)
        {
            Button btnBoton3 = new Button
            {
                Text = "Boton3",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Colors.Blue,
                HeightRequest = 70,
                WidthRequest = 200,
                FontSize = 16,
                FontAttributes = FontAttributes.Bold,
                BorderColor = Colors.Yellow,
                Margin = 30
            };
            btnBoton3.Clicked += (sender, args) =>
            {
                btnBoton2.Text = "Crear controles en tiempo de ejecución mola";
                btnBoton2.WidthRequest = 450;
                vslBtns.Children.Remove(btnBoton1);
            };
            vslBtns.Add(btnBoton3);
            btnBoton3Creado = true;
        }
        else
        {
            DisplayAlert("ERROR", $"El botón 3 ya existe", "OK");
        }
    }
}

