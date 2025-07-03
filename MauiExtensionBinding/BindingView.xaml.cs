namespace MauiExtensionBinding;
using System.Diagnostics;

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

    protected override void OnAppearing()
    {
        base.OnAppearing();
        // This method is called when the page appears.
        // You can add any additional logic here if needed.
        ExtensionModelViewModel viewModel = BindingContext as ExtensionModelViewModel;
        if (viewModel == null)
        {
            Debug.WriteLine("BindingContext is not set or is not of type ExtensionModelViewModel.");
            return;
        }
        Debug.WriteLine($"BindingView has appeared with Status: {viewModel.Status} and StatusColor: {viewModel.StatusColor} and StatusViewModelColor: {viewModel.StatusViewModelColor}");
        lblStatusViewModelColor.Text = viewModel.StatusViewModelColor;

    }
}