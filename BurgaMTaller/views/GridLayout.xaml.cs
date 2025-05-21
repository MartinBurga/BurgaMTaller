namespace BurgaMTaller.views;

public partial class GridLayout : ContentPage
{
	public GridLayout()
	{
		InitializeComponent();
	}

    private void StackButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new StackPage());

    }
}