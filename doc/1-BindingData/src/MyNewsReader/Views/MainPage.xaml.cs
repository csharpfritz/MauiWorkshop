using MyNewsReader.ViewModels;

namespace MyNewsReader;

public partial class MainPage : ContentPage
{

	public MainPage(NewsFeedListViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

}

