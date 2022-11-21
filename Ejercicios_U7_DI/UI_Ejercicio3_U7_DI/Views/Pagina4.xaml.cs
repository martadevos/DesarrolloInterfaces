using Entidades_Ejercicios_U7_DI;

namespace UI_Ejercicio3_U7_DI.Views;

public partial class Pagina4 : ContentPage
{
	public Pagina4(clsPersona persona)
	{
		InitializeComponent();
		lblNombre.Text = persona.Nombre;
        lblApellidos.Text = persona.Apellidos;
    }
}