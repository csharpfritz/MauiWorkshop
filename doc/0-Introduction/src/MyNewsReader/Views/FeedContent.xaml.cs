using MyNewsReader.ViewModels;

namespace MyNewsReader;

public partial class FeedContent : ContentPage
{
	public FeedContent(NewsFeedViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}