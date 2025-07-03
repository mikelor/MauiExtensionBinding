using Microsoft.Extensions.Logging;

namespace MauiExtensionBinding
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

                // Register the ViewModel for Dependency Injection.
                // AddTransient means a new instance of the ViewModel will be created
                // every time it's requested. This is generally suitable for ViewModels.
                builder.Services.AddTransient<BindingView>();
                builder.Services.AddTransient<ExtensionModelViewModel>();
                


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
