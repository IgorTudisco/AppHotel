
using AppHotel.Models;
using System.Collections;

namespace AppHotel;

public partial class App : Application
{
    public List<Quarto> lista_quartos = new List<Quarto>
    {
        new Quarto
        {
            Descricao = "Super Suite Luxo",
            ValorDiariaAdulto = 110.0,
            ValorDiariaCrianca = 55.0,
        },
        new Quarto
        {
            Descricao = "Suite Luxo",
            ValorDiariaAdulto = 90.0,
            ValorDiariaCrianca = 45.0,
        },
        new Quarto
        {
            Descricao = "Suite",
            ValorDiariaAdulto = 70.0,
            ValorDiariaCrianca = 35.0,
        }
    };

    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {

        var window = base.CreateWindow(activationState);

        window.Width = 400;
        window.Height = 700;

        return window;
    }

}
