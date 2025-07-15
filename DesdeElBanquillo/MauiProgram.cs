using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using DesdeElBanquillo.Services;
using DesdeElBanquillo.ViewModels;

namespace DesdeElBanquillo
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            // Registro de servicios
            builder.Services.AddSingleton<MockDataService>();

            // Registro de ViewModels
            builder.Services.AddSingleton<MainViewModel>();

            // Registro de Views
            builder.Services.AddSingleton<Views.MainPage>();

            return builder.Build();
        }
    }
}