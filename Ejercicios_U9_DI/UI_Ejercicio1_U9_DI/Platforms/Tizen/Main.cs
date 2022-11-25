using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace UI_Ejercicio1_U9_DI;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
