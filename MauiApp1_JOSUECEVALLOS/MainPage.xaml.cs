using Microsoft.Maui.Controls;

namespace MauiApp1_JOSUECEVALLOS;

public partial class MainPage : ContentPage
{
    private int clickCount = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        clickCount++;
        ClickLabel.Text = $"Has hecho clic {clickCount} {(clickCount == 1 ? "vez" : "veces")}.";
    }

    private async void OnNavigateToInfoPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//InfoPage");
    }
}
