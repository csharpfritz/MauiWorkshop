using MyNewsReader.Models;
using SQLite;
using System.Net.Http.Headers;

namespace MyNewsReader.Services;

public class NewsFeedService
{

	private Dictionary<NewsFeed, Rss> _Feeds = new()  {
		{ new NewsFeed("https://devblogs.microsoft.com/landingpage/", "Microsoft Dev Blogs", null, null), null },
		{  new NewsFeed("http://feeds.feedburner.com/FritzOnTheWeb", "Jeff Fritz's Blog", null, null), null },
		{ new NewsFeed("https://www.rollingstone.com/feed/", "Rolling Stone", null, null), null },
		{ new NewsFeed("https://dev.to/feed/tag/dotnet", "Dev.To - #dotnet tag", null, null), null }
	};
	
	private HttpClient _Client;

	public NewsFeedService() {
		_Client = new HttpClient();
		var header = new ProductHeaderValue("MyNewsReader");
		var userAgent = new ProductInfoHeaderValue(header);
		_Client.DefaultRequestHeaders.UserAgent.Add(userAgent);
	}

	public async Task<IEnumerable<NewsFeed>> GetFeeds()
	{

		await Init();
		return await Database.Table<NewsFeed>().ToListAsync();

		//return _Feeds.Select(f => f.Key).ToArray();

	}

	public async Task AddFeed(string sourceUrl, string title)
	{

		await Init();
		var newFeed = new NewsFeed(sourceUrl, title, null, null);
		await Database.InsertAsync(newFeed);

	}

	public async Task<Rss> GetContentForFeed(string sourceUrl)
	{

		//if (_Feeds.Any(f => f.Key.SourceUrl.Equals(sourceUrl, StringComparison.InvariantCultureIgnoreCase)) && _Feeds.First(f => f.Key.SourceUrl.Equals(sourceUrl, StringComparison.InvariantCultureIgnoreCase)).Value != null) {
		//	return _Feeds.First(f => f.Key.SourceUrl.Equals(sourceUrl, StringComparison.InvariantCultureIgnoreCase)).Value;
		//}

		var response = await _Client.GetAsync(sourceUrl);
		if (!response.IsSuccessStatusCode) return new Rss();
		var content = Rss.Deserialize(await response.Content.ReadAsStringAsync());

		var newFeed = new NewsFeed {
			SourceUrl = sourceUrl,
			Title = content.channel.title,
			LastFetched = DateTimeOffset.Now,
			LastUpdated = string.IsNullOrEmpty(content.channel.lastBuildDate) ? DateTimeOffset.Now : DateTimeOffset.Parse(content.channel.lastBuildDate)
		};

		_Feeds[newFeed] = content;

		return content;
	}

	SQLiteAsyncConnection Database;

	async Task Init() {
		if (Database is not null)
			return;

		Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
		var result = await Database.CreateTableAsync<NewsFeed>();
	}



}