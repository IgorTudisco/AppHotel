namespace AppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private void Button_ClickedVoltar(object sender, EventArgs e)
    {
        App.Current.MainPage = new ContratacaoHospedagem();
    }
}