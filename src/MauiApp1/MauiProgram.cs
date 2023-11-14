using Telerik.Maui.Controls.Compatibility;
using Raygun4Maui;

namespace MauiApp1
{
    public static class MauiProgram
    {
        private const string ApiKey = "YOUR KEY HERE";

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .AddRaygun4Maui(ApiKey)
                .UseTelerik()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
#if DEBUG
           builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
