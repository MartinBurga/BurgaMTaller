namespace BurgaMTaller.views;

public partial class FlexPage : ContentPage
{
	public FlexPage()
	{
		InitializeComponent();
	}

    private void AbsolutePage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteLayoutPage());

    }
}