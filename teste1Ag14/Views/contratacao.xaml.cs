namespace teste1Ag13.Views;

public partial class contratacao : ContentPage
{
    App PropriedadesApp;
    public contratacao()
    {
        InitializeComponent();
   
        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quarto;

        dtpck_checkin.MinimumDate = DateTime.Today;
        dtpck_checkin.MaximumDate = DateTime.Today.AddMonths(1);

        dtpck_checkout.MinimumDate = DateTime.Today.AddDays(1);
        dtpck_checkout.MaximumDate = DateTime.Today.AddMonths(6);

       
       

    }


    private void Button_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new Views.sobre());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new contrato());
        }
        catch (Exception ex) { 
            DisplayAlert("Erro", ex.Message, "OK"); 
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;


        dtpck_checkout.MinimumDate = ((DateTime)elemento.Date).AddDays(1);
        dtpck_checkout.MaximumDate = ((DateTime)elemento.Date).AddMonths(6);
    }
}