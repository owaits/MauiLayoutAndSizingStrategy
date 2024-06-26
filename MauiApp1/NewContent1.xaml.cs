using System.Diagnostics;

namespace MauiApp1;

public partial class NewContent1 : ContentView
{
	private static int instances = 0;

	public NewContent1()
	{
		instances++;

		InitializeComponent();

		Trace.WriteLine($"Instances Plus: {instances}");
	}

	~NewContent1()
	{
        instances--;
        Trace.WriteLine($"Instances Minus: {instances}");
    }
}