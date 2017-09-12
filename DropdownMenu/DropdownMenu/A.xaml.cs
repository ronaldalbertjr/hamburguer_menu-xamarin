using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace DropdownMenu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class A : ContentPage
	{
		public A ()
		{
            DependencyService.Get<IDependencyService>().SendNotification("Página A", "Você visitou a página A");
			InitializeComponent ();
        }
	}
}