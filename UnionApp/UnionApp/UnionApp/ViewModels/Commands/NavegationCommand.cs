﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace UnionApp.ViewModel.Commands
{
    public class NavegationCommand : ICommand
    {
        public HomeVM HomeViewModel { get; set; }
        public NavegationCommand(HomeVM homeVM)
        {
            HomeViewModel = homeVM;
        }

    
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            HomeViewModel.Navigate();
        }
    }
}
