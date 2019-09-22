using System;
using System.Collections.Generic;
using System.Text;
using UnionApp.ViewModel.Commands;

namespace UnionApp.ViewModel
{
    public class HomeVM
    {
       
        public NavegationCommand NavCommand { get; set; }

        public HomeVM()
        {
            NavCommand = new NavegationCommand(this);
        }

        public async void Navigate()
        {
           // await App.Current.MainPage.Navigation.PushAsync(new NewTravelPage());
        }
    }
}
