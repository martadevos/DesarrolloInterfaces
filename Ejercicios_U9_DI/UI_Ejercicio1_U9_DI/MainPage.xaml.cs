namespace UI_Ejercicio1_U9_DI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void Entry_TextChanged(object sender, TextChangedEventArgs e)
	{
		if (!int.TryParse(e.NewTextValue, out int n)){
			entryFontSize.Text = e.OldTextValue;
		}
	}
}

