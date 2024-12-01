using Microsoft.Maui.Controls;

namespace MauiApp1_JOSUECEVALLOS;

public partial class ContactPage : ContentPage
{
    public ContactPage()
    {
        InitializeComponent();
    }

    private async void OnSendMessageClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Mensaje Enviado", "Gracias por contactarnos. Te responderemos pronto.", "OK");
    }
}
