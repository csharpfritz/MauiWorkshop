namespace MyNewsReader;

public partial class App : Application {
	public App() {
		InitializeComponent();

	}

	protected override Window CreateWindow(IActivationState activationState) {

		if (DeviceInfo.Current.Idiom == DeviceIdiom.Desktop) {

			return new Window(new AppShell()) {
				Width = 600
			};

		}

		return new Window(new AppShell());

	}
}
