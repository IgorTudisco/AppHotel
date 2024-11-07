namespace AppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{

    App PropriedadesApp;

	public ContratacaoHospedagem()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MinimumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);


	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {

            App.Current.MainPage = new HospegademContratada();

        }
        catch (Exception ex)
        {

            DisplayAlert("Deu ruim!", ex.Message, "Ok");

        }
    }

    private void Button_ClickedSobre(object sender, EventArgs e)
    {
        App.Current.MainPage = new Sobre();
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime dataSelecionadaCheckin = elemento.Date;

        dtpck_checkout.MinimumDate = dataSelecionadaCheckin.AddDays(1);
        dtpck_checkout.MaximumDate = dataSelecionadaCheckin.AddMonths(6);

    }
}