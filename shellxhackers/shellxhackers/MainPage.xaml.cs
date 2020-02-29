using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace shellxhackers
{
    [DesignTimeVisible(false)]
    [QueryProperty("From", "from")]
    [QueryProperty("WhereTo", "whereto")]
    public partial class MainPage : ContentPage
    {
        private string from, whereTo;

        public string From 
        {
            get => from;
            set
            {
                from = value;
                OnPropertyChanged();
            }
        }
        public string WhereTo 
        { 
            get => whereTo;
            set 
            {
                whereTo = value;
                OnPropertyChanged();
            } 
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
        }
    }
}
