using Microsoft.Extensions.DependencyInjection;
using teste1Ag13.models;

namespace teste1Ag13
{
    public partial class App : Application
    {
        public List<quarto> lista_quarto = new List<quarto>
        {
            new quarto ()
            {
                Descricao = "Quarto simples",
                VDAdulto = 100.00,
                VDCrianca = 50.00
            },
            new quarto () {
                Descricao = "Quarto Luxo",
                VDAdulto = 200.00,
                VDCrianca = 100.00
            },
            new quarto () {
                Descricao = "Quarto Premium",
                VDAdulto = 300.00,
                VDCrianca = 150.00
            }
        };
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Views.contratacao());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow (activationState);

            window.Width = 400;
            window.Height = 700;

            return window;
        }
    }
}