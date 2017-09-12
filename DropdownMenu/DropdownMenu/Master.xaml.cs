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
	public partial class Master : ContentPage
	{
		public Master ()
		{
			InitializeComponent ();

            buttonA.Clicked += async (sender, e) => 
            {
                App.MasterDetail.IsPresented = false;
                await App.MasterDetail.Detail.Navigation.PushAsync(new A());

                DependencyService.Get<IDependencyService>().SendNotification("Página A", "Você visitou a página A");
            };

            buttonB.Clicked += async (sender, e) =>
            {
                App.MasterDetail.IsPresented = false;
                await App.MasterDetail.Detail.Navigation.PushAsync(new B());

                DependencyService.Get<IDependencyService>().SendNotification("Página B", "Você visitou a página B");
            };
		}
	}
}