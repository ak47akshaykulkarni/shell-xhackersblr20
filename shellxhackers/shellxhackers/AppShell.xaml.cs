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

            string navTo;
            switch (whereTo)
            {
                case "Cats":
                    navTo = $"//animals/domestic/cats";
                    break;
                case "Dogs":
                    navTo = $"//animals/domestic/dogs";
                    break;
                case "about":
                    navTo = $"//about";
                    break;
                default:
                    navTo = $"//animals/bears";
                    break;
            }
            string para = $"?whereto={navTo}&from={Shell.Current.CurrentState.Location.OriginalString}";
            await Shell.Current.GoToAsync($"{navTo}{para}");

        }

        private void Shell_Navigated(object sender, ShellNavigatedEventArgs e)
        {
            if (Shell.Current is null) return;
            Shell.Current.FlyoutIsPresented = false;
        }
    }
}