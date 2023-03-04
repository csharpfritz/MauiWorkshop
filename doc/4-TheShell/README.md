### Part 4 - The .NET MAUI Shell

The [.NET MAUI Shell](https://learn.microsoft.com/dotnet/maui/fundamentals/shell) reduces the complexity of app development by providing the fundamental features that most apps require, including:

- A single place to describe the visual hierarchy of an app.
- A common navigation user experience.
- A URI-based navigation scheme that permits navigation to any page in the app.
- An integrated search handler.

In the sample code provided, the application is started with a root object in `App.xaml` that initializes the application and hands off controls to `AppShell.xaml` where the Shell is defined:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<Shell xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="MyNewsReader.AppShell"
             FlyoutBehavior="Disabled">

	<Shell.Resources>
		<ResourceDictionary>
			<Style x:Key="BaseStyle" TargetType="Element">
				<Setter Property="Shell.BackgroundColor" Value="{StaticResource Primary}" />
				<Setter Property="Shell.ForegroundColor" Value="{OnPlatform WinUI={StaticResource Primary}, Default=White}" />
				<Setter Property="Shell.TitleColor" Value="White" />
			</Style>
			<Style BasedOn="{StaticResource BaseStyle}" TargetType="ShellItem" ApplyToDerivedTypes="True" />
		</ResourceDictionary>
	</Shell.Resources>


	<ShellContent
        Title="Home"
        ContentTemplate="{DataTemplate local:MainPage}"
        Route="MainPage" />

</Shell>				
```

The shell defines the resources to be used in the application and the behavior of the navigation in the application.  The `Shell.Resources` markup defines the styles to be applied to the contents of the Shell.

The `ShellContent` element abstractly references the `MainPage` of our application using the `ContentTemplate` attribute and declaring that this content should be presented.  A Route is assigned as well, so that we can navigate around the application.

Check out the `Shell.NavBarIsVisible` attribute declaring that the navigation elements and title should be visible when the MainPage is displayed.

