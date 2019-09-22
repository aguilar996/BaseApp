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
	public partial class HomePage : TabbedPage
	{
        //HomeVM viewModel;
		public HomePage ()
		{
			InitializeComponent ();
           // viewModel = new HomeVM();
           // BindingContext = viewModel;
		}


    }
}