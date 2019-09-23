using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnionApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnionApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactTabPage : ContentPage
    {
        ContactVM viewModel;
        public ContactTabPage()
        {
            InitializeComponent();
            viewModel = new ContactVM();
            BindingContext = viewModel;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing(); 
            viewModel.GetContactos();
            ContactosView.ItemsSource = viewModel.ContactList;
        }

        
    }
}