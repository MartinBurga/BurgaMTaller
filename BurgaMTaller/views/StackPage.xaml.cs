namespace BurgaMTaller.views;

public partial class StackPage : ContentPage
{

    public StackPage()
    {
        InitializeComponent();
    }
    private void FlexButton_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new FlexPage());
	}

    private void Home_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

    
}