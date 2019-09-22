using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace UnionApp.ViewModels.Commands
{
    public class RegisterNavigationCommand : ICommand 
    { 
        private MainVM ViewModel;
        public event EventHandler CanExecuteChanged; 
        public RegisterNavigationCommand(MainVM viewModel)
        {
            ViewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.Navigate();
        }
    }
}
