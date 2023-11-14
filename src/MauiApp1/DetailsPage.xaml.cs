using Mindscape.Raygun4Net;
using Raygun4Maui;

namespace MauiApp1;

public partial class DetailsPage : ContentPage
{
    public DetailsPage()
    {
        InitializeComponent();
        RaygunMauiClient.Current.SendInBackground(new RaygunMessage {Details = new RaygunMessageDetails {Error = new RaygunErrorMessage {Message = "Init details"}}});
    }

    private async void OnNavClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void Chat_OnSendMessageSendMessage(object? sender, EventArgs e)
    {
        throw new NotImplementedException("Yup an unhandled thing");
    }
}