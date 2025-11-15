namespace teste1Ag13.Views;

public partial class contrato : ContentPage
{
    public contrato()
    {
        InitializeComponent();
    }


    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", ex.Message, "OK");
        }
    }
}
