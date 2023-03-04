using MyNewsReader.ViewModels;

namespace MyNewsReader;

public partial class ArticleContent : ContentPage
{
	public ArticleContent(ArticleViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}