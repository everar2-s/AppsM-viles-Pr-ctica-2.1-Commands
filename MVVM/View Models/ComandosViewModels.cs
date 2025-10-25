using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PracticaComandos.MVVM.View_Models {
   public class ComandosViewModels {

        public ICommand ClickCommand =>
            new Command(Alert);

        private void Alert() {
            App.Current.MainPage.DisplayAlert("Comando", "Has pulsado el botón que ejecuta un comando", "Aceptar");
        }
    }
  
}