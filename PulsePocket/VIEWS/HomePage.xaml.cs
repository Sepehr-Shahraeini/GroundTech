using DevExpress.CodeParser;
using $safeprojectname$.Services;
using $safeprojectname$.ViewModels;
using System.Windows.Input;
namespace $safeprojectname$.Views;

public partial class HomePage : ContentPage
{

    
	public HomePage()
	{
		InitializeComponent();
        BindingContext = new HomeViewModel();

    }


    private void GoToLibrary(object sender, EventArgs e)
    {
       ((MainPage)App.Current.MainPage).SwitchtoTab(2);
    }
   
    private void NavigateToForms(object sender, EventArgs e)
    {
        ((MainPage)App.Current.MainPage).SwitchtoTab(4);
    }
      private void NavigateToLibrary(object sender, EventArgs e)
    {
        ((MainPage)App.Current.MainPage).SwitchtoTab(2);
    }

}