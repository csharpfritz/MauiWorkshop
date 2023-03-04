using CommunityToolkit.Mvvm.Input;
using MyNewsReader.Models;
using MyNewsReader.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyNewsReader.ViewModels;

public partial class NewsFeedListViewModel : BaseViewModel {

	private readonly NewsFeedService _Service;

	public ObservableCollection<NewsFeed> NewsFeeds { get; } = new();

	public NewsFeedListViewModel(NewsFeedService service) {
		_Service = service;
		GetFeedsAsync();
	}


	[RelayCommand]
	async Task GoToNewsFeed(NewsFeed feed) {

		if (feed == null) return;

		await Shell.Current.GoToAsync(nameof(FeedContent), true, new Dictionary<string, object> {
			{ "Feed", feed }
		});

	}

	[RelayCommand]
	async Task AddFeed() {

		await Shell.Current.GoToAsync(nameof(AddNewsFeed), true);

	}

	[RelayCommand]
	async Task GetFeedsAsync()
	{

		if (IsBusy) return;

		try {
			IsBusy = true;
			var feeds = await _Service.GetFeeds();

			if (NewsFeeds.Count != 0) NewsFeeds.Clear();

			foreach (var feed in feeds) {
				NewsFeeds.Add(feed);
			}

		} catch (Exception ex) {

			Debug.WriteLine($"Unable to get the feeds {ex.Message}");
			await Shell.Current.DisplayAlert("Error while fetching feeds", ex.Message, "OK");

		} finally {

			IsBusy = false;

		}
		

	}
	

}
