using PracticaComandos.MVVM.Views;

namespace PracticaComandos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ComandosView();
        }
    }
}
