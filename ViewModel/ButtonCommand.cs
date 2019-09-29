using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WhatsMVVM.ViewModel
{
    public class ButtonCommand : ICommand
    {
        Action waht;
        Func<bool> when;

        public ButtonCommand(Action what, Func<bool> when)
        {
            this.waht = what;
            this.when = when;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return when();
        }

        public void Execute(object parameter)
        {
            waht();
        }
    }
}
