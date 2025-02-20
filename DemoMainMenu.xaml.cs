namespace FLEX_LAYOUTDEMO_ARFR;

public partial class DemoMainMenu : ContentPage
{
	public DemoMainMenu()
	{
        InitializeComponent();
	}
    private async void _stackDemo_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StackLayoutDemo());
    }

    private async void _absoDemo_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayoutDemo());
    }
    
    private async void _gridDemo_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridDemo());
    }

    private async void _flexDemo_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexLayoutDemo());
    }

}