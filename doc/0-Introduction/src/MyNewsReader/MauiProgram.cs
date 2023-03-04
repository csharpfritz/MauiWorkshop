using Microsoft.Extensions.Logging;
using MyNewsReader.Services;
using MyNewsReader.ViewModels;

namespace MyNewsReader;

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

		builder.Services
			.AddSingleton<NewsFeedService>()
			
			.AddSingleton<NewsFeedListViewModel>()
			.AddSingleton<MainPage>()

			.AddSingleton<NewsFeedViewModel>()
			.AddSingleton<FeedContent>()

			.AddSingleton<AddNewsFeedViewModel>()
			.AddSingleton<AddNewsFeed>()

			.AddSingleton<ArticleViewModel>()
			.AddSingleton<ArticleContent>()
		;

		return builder.Build();
	}
}
