using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shellxhackers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            var whereTo = await DisplayActionSheet("Where to?", "Nope", "oh okay", new string[] {"Cats", "Dogs", "about" });

            switch (whereTo)
            {
                case "Cats":
                    await Shell.Current.GoToAsync("//animals/domestic/cats");
                    break;
                case "Dogs":
                    await Shell.Current.GoToAsync("//animals/domestic/dogs");
                    break;
                case "about":
                    await Shell.Current.GoToAsync("//about");
                    break;
                default:
                    await Shell.Current.GoToAsync("//animals/bears");
                    break;
            }

        }

        //private void Shell_Navigated(object sender, ShellNavigatedEventArgs e)
        //{
        //    if(Shell.Current is null) return;
        //    Shell.Current.FlyoutIsPresented = false;
        //}
    }
}