using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyNewsReader.Models;
using MyNewsReader.Services;

namespace MyNewsReader.ViewModels;

[QueryProperty(nameof(Feed), "Feed")]
public partial class NewsFeedViewModel : BaseViewModel {

	private readonly NewsFeedService _Service;

	public NewsFeedViewModel(NewsFeedService service) {
		_Service = service;
	}

	[ObservableProperty]
	NewsFeed feed;

	[ObservableProperty]
	Rss content;

	Task feedLoading;
	partial void OnFeedChanged(NewsFeed value) {

		Content = new();
		IsBusy = true;

		feedLoading = _Service.GetContentForFeed(value.SourceUrl).ContinueWith(r => {
			Content = r.Result;
			IsBusy = false;
		});


	}


	[RelayCommand]
	async Task GoToContent(rssChannelItem item) {

		if (item == null) return;

		await Shell.Current.GoToAsync(nameof(ArticleContent), true, new Dictionary<string, object> {
			{ "Content", item }
		});

	}



}
