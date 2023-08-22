namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void Button_OnClicked(object sender, EventArgs e)
	{
		leftPanel.IsVisible = !leftPanel.IsVisible;
	}
}

