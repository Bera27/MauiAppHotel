using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> quartos = new List<Quarto>()
        {
            new Quarto()
            {
                Descricao = "Suíte de Luxo",
                ValorDiariaAdulto = 110.0M,
                ValorDiariaCrianca = 55.0M
            },
            new Quarto()
            {
                Descricao = "Suíte Comum",
                ValorDiariaAdulto = 80.0M,
                ValorDiariaCrianca = 40.0M
            },
            new Quarto()
            {
                Descricao = "Suíte Simples",
                ValorDiariaAdulto = 25.0M,
                ValorDiariaCrianca = 12.0M
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
}