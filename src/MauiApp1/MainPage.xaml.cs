using Raygun4Maui;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private int _count;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            _count++;

            CounterBtn.Text = _count == 1 ? $"Clicked {_count} time" : $"Clicked {_count} times";


            try
            {
                if (_count == 4)
                {
                    throw new Exception("Oh no! I clicked the button too many times");
                }
            }
            catch (Exception ex)
            {
                  RaygunMauiClient.Current.SendInBackground(ex);
            }

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void OnNavClicked(object sender, EventArgs e)
        {
            CounterBtn.Text = $"WTF";
            await Navigation.PushAsync(new DetailsPage());
        }
    }
}
