
namespace MyNewsReader;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		RegisterForRoute<FeedContent>();
		RegisterForRoute<ArticleContent>();
		RegisterForRoute<AddNewsFeed>();

	}

	protected void RegisterForRoute<T>()
	{

		Routing.RegisterRoute(typeof(T).Name, typeof(T));

	}
	
}


