
using ProductoMVVMSQLite.ViewModels;

namespace ProductoMVVMSQLite.Views;

public partial class PersonaPage : ContentPage
{
	public PersonaPage()
	{
		InitializeComponent();
		this.BindingContext = new PersonaViewModel();
    }
}