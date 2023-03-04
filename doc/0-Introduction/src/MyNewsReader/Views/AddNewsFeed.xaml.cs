using MyNewsReader.ViewModels;

namespace MyNewsReader;

public partial class AddNewsFeed : ContentPage
{
	public AddNewsFeed(AddNewsFeedViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

}