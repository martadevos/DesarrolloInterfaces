namespace UI_Ejercicio4_U7_DI.Views.MenuFlyout;

public partial class FlyoutPageNavigation : FlyoutPage
{
	public FlyoutPageNavigation()
	{
		InitializeComponent();
        flyoutPage.collectionView.SelectionChanged += OnSelectionChanged;
    }

    void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var item = e.CurrentSelection.FirstOrDefault() as clsFlyoutPageItem;
        if (item != null)
        {
            Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
        }
    }
}