using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace GeoRestApi
{
    public class DelegateCommand : ICommand
    {

        Action<object> execute;
        Predicate<object> canExecute;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action<object> execute, Predicate<object> canExecute) 
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
        public DelegateCommand(Action<object> execute)
        {
            this.execute = execute;
            this.canExecute = CanAlwaysExecute;
        }

        public void Execute(object parameter) 
        {
            execute(parameter);
        }
        public bool CanExecute(object parameter) 
        {
            return canExecute(parameter);
        }
        public bool CanAlwaysExecute(object param)
        {
            return true;
        }


        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
