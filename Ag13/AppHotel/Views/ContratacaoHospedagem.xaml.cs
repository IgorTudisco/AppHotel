namespace AppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private void Button_ClickedSobre(object sender, EventArgs e)
    {

        App.Current.MainPage = new Sobre();


    }
}