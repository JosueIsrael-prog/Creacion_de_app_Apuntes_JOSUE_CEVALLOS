using Microsoft.Maui.Controls;

namespace MauiApp1_JOSUECEVALLOS;

public partial class InfoPage : ContentPage
{
    public InfoPage()
    {
        InitializeComponent();
    }

    private async void OnNavigateToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}
