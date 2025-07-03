# MauiExtensionBinding
Demonstrates the new C#14 Extension Properties with MVVM bindings. Really a bit of a hack, because I just call OnPropertyChange() for each extension property that changes when a standard property is changed.
See ExtensionModelViewModel for relevant code. Notice I am not using [ObservableObject], but coding the generated source within the class.
