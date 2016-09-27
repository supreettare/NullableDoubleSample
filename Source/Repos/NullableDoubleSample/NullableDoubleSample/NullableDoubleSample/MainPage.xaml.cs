using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NullableDoubleSample
{
    public partial class MainPage : ContentPage
    {
        private Person selectedPerson;

        public Person SelectedPerson
        {
            get { return selectedPerson; }
            set { selectedPerson = value;
                OnPropertyChanged(""); 
            }
        }

        public MainPage(Person _person)
        {
            InitializeComponent();
            this.SelectedPerson = _person; 
            this.BindingContext = this.SelectedPerson;

            
        }

        private async void OnClick(object sender, EventArgs e)
        {
            await DisplayAlert("details", $"Person Name= {this.SelectedPerson.Name}, Age= {this.SelectedPerson.Age}, Marks= {this.SelectedPerson.Marks}", "Okay"); 
        }
    }
}
