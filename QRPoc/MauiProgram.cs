
#if (ANDROID || IOS || MACCATALYST)
using ZXing.Net.Maui;
#endif

namespace QRPoc;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			#if (ANDROID || IOS || MACCATALYST)
            .UseBarcodeReader()
			#endif
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
