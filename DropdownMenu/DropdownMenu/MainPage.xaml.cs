using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DropdownMenu
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();

            this.Detail = new NavigationPage(new Detail());
            this.Master = new Master();
            App.MasterDetail = this;
		}
	}
}
