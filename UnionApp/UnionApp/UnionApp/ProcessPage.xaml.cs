﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnionApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProcessPage : ContentPage
    {
        public ProcessPage()
        {
            InitializeComponent();
        }

        private void Matriculacion_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MatriculacionPage());
        }

        private void RegistroM_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistroMateriaPage());
}

        private void ReclamoM_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReclamoMateriaPage());
        }
    }
}