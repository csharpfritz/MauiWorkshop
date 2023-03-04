using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyNewsReader.Models;

namespace MyNewsReader.ViewModels;


[QueryProperty(nameof(Content), "Content")]
public partial class ArticleViewModel : BaseViewModel
{

	[ObservableProperty]
	rssChannelItem content;

}
