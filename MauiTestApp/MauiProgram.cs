using Microsoft.Extensions.Logging;

namespace MauiTestApp;


// Implement this: https://www.syncfusion.com/blogs/post/sleep-patterns-with-net-maui-toolkit?utm_source=alvinashcraft&utm_medium=email&utm_campaign=alvinashcraft_blog_edmmar25

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

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
