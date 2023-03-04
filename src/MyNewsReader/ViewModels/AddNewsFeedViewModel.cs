using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyNewsReader.Services;
using System.Diagnostics;

namespace MyNewsReader.ViewModels;

public partial class AddNewsFeedViewModel : BaseViewModel {

	private readonly NewsFeedService _Service;

	public AddNewsFeedViewModel(NewsFeedService service) {

		_Service = service;

	}

	[ObservableProperty]
	string sourceUrl;

	[ObservableProperty]
	string title;

	partial void OnSourceUrlChanged(string value) {

		try {

			var rss = _Service.GetContentForFeed(value).ContinueWith(continuationFunction: r => Title = r.Result.channel.title);

		} catch (Exception ex) {

			Debug.WriteLine($"Unable to add the feed {ex.Message}");
			Shell.Current.DisplayAlert("Error while adding feed", ex.Message, "OK");

		}


	}

	[RelayCommand]
	async Task SaveFeedAsync() {

		if (IsBusy) return;

		try {

			IsBusy = true;
			await _Service.AddFeed(sourceUrl, title);

		}
		catch (Exception ex) {

			Debug.WriteLine($"Unable to add the feed {ex.Message}");
			await Shell.Current.DisplayAlert("Error while adding feed", ex.Message, "OK");

		}
		finally {

			IsBusy = false;

		}

		await Shell.Current.GoToAsync("///MainPage", true);

	}

	[RelayCommand]
	async Task Cancel() {

		await Shell.Current.GoToAsync("///MainPage", true);

	}

}