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
    [QueryProperty("From", "from")]
    public partial class DynamicallyRegisterd : ContentPage
    {
        private string from;
        public string From
        {
            get => from;
            set
            {
                from = value;
                OnPropertyChanged();
            }
        }
        public DynamicallyRegisterd()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}