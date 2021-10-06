using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UI.MVVM.VM;

namespace UI.Commands
{
    public class ImageToDB_CMD
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public event Action<Good> UploadEvent;

        public ImageToDB_CMD()
        {
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (UploadEvent != null)
                UploadEvent(parameter as Good);
        }
    }
}
