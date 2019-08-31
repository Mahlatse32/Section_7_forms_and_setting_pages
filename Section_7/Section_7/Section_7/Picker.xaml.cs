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
	public partial class Picker : ContentPage
	{
		public Picker ()
		{
			InitializeComponent ();

            foreach (var method in GetContactMethods())
                contactMethods.Items.Add(method.Name);

        }

        private IList<ContactMethod> _contactMethods;
        private void ContactMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = contactMethods.Items[contactMethods.SelectedIndex];
            //var contactMethod = _contactMethods.Single(cm => cm.Name == name);
            DisplayAlert("Selection", name, "OK");
        }

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod{ Id = 1, Name = "SMS"},
                new ContactMethod{ Id = 2, Name = "Email"}
            };
        }
    }
}