// File: ViewModels/BindingExtensionModeViewModel.cs
// This file defines the ViewModel for our application, using CommunityToolkit.Mvvm.

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace MauiExtensionBinding;

/// <summary>
/// ViewModel for the BindingExtensionMode model.
/// Inherits from ObservableObject to provide INotifyPropertyChanged implementation.
/// </summary>
public partial class ExtensionModelViewModel : ObservableObject
{
    private readonly ExtensionModel _extensionModel;

    /// <summary>
    /// Initializes a new instance of the <see cref="ExtensionModelViewModel"/> class.
    /// Sets the initial status to Unknown.
    /// </summary>
    public ExtensionModelViewModel()
    {
        _extensionModel = new ExtensionModel
        { 
            Status = StatusType.Inactive 
        };
    }

    public StatusType Status
    {
        get => _extensionModel.Status;
        set
        {
            SetProperty(_extensionModel.Status, value, _extensionModel, (model, newStatus) => model.Status = newStatus);
            OnPropertyChanged(nameof(Status));
            OnPropertyChanged(nameof(StatusColor));
            OnPropertyChanged(nameof(this.StatusViewModelColor));
            //OnPropertyChanged(nameof(StatusViewModelColor)); //Compile Error: The name 'StatusViewModelColor' does not exist in the current context
        }
    }
     

    public string StatusColor
    {
        get => _extensionModel.StatusColor; 
    }

    /// <summary>
    /// A command to update the status of the BindingExtensionMode.
    /// The [RelayCommand] attribute automatically generates the
    /// UpdateStatusCommand property and hooks it up to the OnUpdateStatus method.
    /// </summary>
    [RelayCommand]
    private void OnUpdateStatus()
    {
        // Logic to cycle through the statuses
        Status = Status switch
        {
            StatusType.Suspended => StatusType.Active,
            StatusType.Active => StatusType.Inactive,
            StatusType.Inactive => StatusType.Suspended,
            _ => StatusType.Inactive // Default case
        };

        // Optional: You could add more complex logic here, e.g., calling a service.
        Debug.WriteLine($"StatusColor updated to: {StatusColor}");
        Debug.WriteLine($"StatusViewModelColor updated to: {this.StatusViewModelColor}");
    }
}
