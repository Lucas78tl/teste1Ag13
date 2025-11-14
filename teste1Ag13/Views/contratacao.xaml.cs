namespace teste1Ag13.Views;

public partial class contratacao : ContentPage
{
    public contratacao()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new Views.sobre());
    }
}