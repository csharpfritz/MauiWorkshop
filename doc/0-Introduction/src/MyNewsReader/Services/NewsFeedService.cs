using MyNewsReader.Models;
using SQLite;
using System.Net.Http.Headers;

namespace MyNewsReader.Services;

public class NewsFeedService
{

	//private Dictionary<NewsFeed, Rss> _Feeds = new()  {
	//	{ new NewsFeed("https://devblogs.microsoft.com/landingpage/", "Microsoft Dev Blogs"), null },
	//	{  new NewsFeed("http://feeds.feedburner.com/FritzOnTheWeb", "Jeff Fritz's Blog"), null },
	//	{ new NewsFeed("https://www.rollingstone.com/feed/", "Rolling Stone"), null },
	//	{ new NewsFeed("https://dev.to/feed/tag/dotnet", "Dev.To - #dotnet tag"), null }
	//};
	
	private HttpClient _Client;

	public NewsFeedService() {
		_Client = new HttpClient();
		var header = new ProductHeaderValue("MyNewsReader");
		var userAgent = new ProductInfoHeaderValue(header);
		_Client.DefaultRequestHeaders.UserAgent.Add(userAgent);
	}


}