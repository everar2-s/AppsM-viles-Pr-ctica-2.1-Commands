using PracticaComandos.MVVM.View_Models;

namespace PracticaComandos.MVVM.Views;

public partial class ComandosView : ContentPage
{
	public ComandosView()
	{
		InitializeComponent();
		BindingContext = new ComandosViewModels();
    }

    private void Button_Clicked(object sender, EventArgs e) {

    }
}