namespace MauiExample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnMenuSelectionChanged(object? sender, SelectionChangedEventArgs e)
	{
		if (e.CurrentSelection == null || e.CurrentSelection.Count == 0)
			return;

		var selected = e.CurrentSelection[0] as string;
		if (string.IsNullOrEmpty(selected))
			return;

		switch (selected)
		{
			case "Credit Card":
				await Shell.Current.GoToAsync(nameof(CreditCardPage));
				break;
			case "Number Pad":
				await Shell.Current.GoToAsync(nameof(NumberPadPage));
				break;
		}

		if (sender is CollectionView cv)
		{
			cv.SelectedItem = null;
		}
	}
}
