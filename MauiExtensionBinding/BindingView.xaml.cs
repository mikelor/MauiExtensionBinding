namespace MauiExtensionBinding;

public partial class BindingView : ContentPage
{
	public BindingView(ExtensionModelViewModel viewModel)
	{
        InitializeComponent();

        // Set the BindingContext of the page to the injected ViewModel.
        // This allows the XAML to bind directly to properties and commands
        // exposed by the ViewModel.
        BindingContext = viewModel;
    }
}