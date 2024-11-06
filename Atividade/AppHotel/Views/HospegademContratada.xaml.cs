namespace AppHotel.Views;

public partial class HospegademContratada : ContentPage
{
	public HospegademContratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

		try
		{

            App.Current.MainPage = new ContratacaoHospedagem();

        } catch (Exception ex)
		{
			DisplayAlert("Erro", ex.Message, "Ok");
		}

    }
}