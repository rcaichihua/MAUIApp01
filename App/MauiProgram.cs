using Microsoft.Extensions.Logging;

namespace App;

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
			})
			.Services.AddSingleton<IRogerDavy, RogerDavy>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
public interface IRogerDavy { }

public class RogerDavy : IRogerDavy { }

