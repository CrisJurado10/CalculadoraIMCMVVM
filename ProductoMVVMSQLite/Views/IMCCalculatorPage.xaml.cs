using ProductoMVVMSQLite.ViewModels;

namespace ProductoMVVMSQLite.Views;

public partial class IMCCalculatorPage : ContentPage
{
	public IMCCalculatorPage()
	{
		InitializeComponent();
		this.BindingContext = new IMCCalculatorPageViewModel();
	}
}