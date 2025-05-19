namespace BurgaMTaller;

public partial class Testpage : ContentPage
{
	public Testpage()
	{
		InitializeComponent();
	}

    private void HomeButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PopToRootAsync();
		
    }
}