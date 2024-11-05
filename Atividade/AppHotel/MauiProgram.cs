using Microsoft.Extensions.Logging;

namespace AppHotel
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
                    fonts.AddFont("AlegreyaSC-Black.ttf", "AlegreyaSCBlack");
                    fonts.AddFont("AlegreyaSC-BlackItalic.ttf", "AlegreyaSCBlackItalic");
                    fonts.AddFont("AlegreyaSC-Bold", "AlegreyaSCBold");
                    fonts.AddFont("AlegreyaSC-BoldItalic.ttf", "AlegreyaSCBoldItalic");
                    fonts.AddFont("AlegreyaSC-Italic", "AlegreyaSCItalic");
                    fonts.AddFont("AlegreyaSC-Medium.ttf", "AlegreyaSCMedium");
                    fonts.AddFont("AlegreyaSC-MediumItalic.ttf", "AlegreyaSCMediumItalic");
                    fonts.AddFont("AlegreyaSC-Regular.ttf", "AlegreyaSC");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
