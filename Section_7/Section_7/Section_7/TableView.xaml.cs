using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Section_7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TableView : ContentPage
	{
		public TableView ()
		{
			InitializeComponent ();
		}

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            var page = new ContactMethodsPage();
            page.ContactMethods.ItemSelected += (source, args) => {
                contactMethod.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };

            Navigation.PushAsync(page);
        }
    }
}