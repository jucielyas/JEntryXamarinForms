using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JEntryXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void JEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                var entry = (JEntry)sender;
                var stack = entry.Parent as StackLayout;
                var childs = stack.Children;
                var label = childs[0] as Label;

                if ((entry.Text != null) && (entry.Text.Length > 0))
                    label.IsVisible = true;
                else
                    label.IsVisible = false;

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
