namespace AppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
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
}