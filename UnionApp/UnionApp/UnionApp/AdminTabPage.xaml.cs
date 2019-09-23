using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnionApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminTabPage : ContentPage
    {
        public AdminTabPage()
        {
            InitializeComponent();
        }

        private void Procesos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProcessPage());
        }

        private void Calendario_Clicked(object sender, EventArgs e)
        {

        }

        private void Beneficios_Clicked(object sender, EventArgs e)
        {

        }

        private void Descuentos_Clicked(object sender, EventArgs e)
        {

        }
    }
}