using Microsoft.Extensions.Logging;
using SignupApp.Pages;
using SignupApp.ViewModels;

namespace SignupApp;

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
        builder.Services.AddTransient<SignupPage>();
        builder.Services.AddTransient<SignupPageViewModel>();
        builder.Services.AddTransient<ProfilePage>();
        builder.Services.AddTransient<ProfilePageViewModel>();

        return builder.Build();
	}
}
