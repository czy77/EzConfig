using System;
using System.Windows.Input;

namespace EzConfig.Command
{
    public class DelegateCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            if (CanExecuteFunc == null)
            {
                return true;
            }

            return CanExecuteFunc?.Invoke(parameter) == true;
        }

        public void Execute(object parameter)
        {
            this.ExecuteAction?.Invoke(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public Action<object> ExecuteAction;

        public Func<object, bool> CanExecuteFunc;
    }
}