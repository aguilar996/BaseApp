using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using UnionApp.Models;
using UnionApp.ViewModels;

namespace UnionApp.ViewModel.Commands
{
    public class RegisterCommand : ICommand
    { 
        private RegisterVM viewModel;
        public event EventHandler CanExecuteChanged;
         
        public RegisterCommand(RegisterVM viewModel)
        {
            this.viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        { 
            User user = (User)parameter;
            if (user != null)
            {
                if (user.Password == user.ConfPassword)
                {
                    if (String.IsNullOrEmpty(user.Email) ||
                       String.IsNullOrEmpty(user.Password) ||
                       String.IsNullOrEmpty(user.ConfPassword))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                return false;
            }
                return false;
        }

        public void Execute(object parameter)
        {
            User user = (User)parameter;
            viewModel.Register(user);
        }
    }
}
