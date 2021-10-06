using UI.MVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UI.MVVM.VM
{
    public enum DockingPosition
    {
        None,
        Left,
        Right,
    }
    public class VMimp : IVM
    {

        public VMimp(Window window)
        {
            goodModel = new GoodModel();
        }

        public void Init()
        {
            goodModel.Init();
        }




        private GoodModel goodModel;




    }
}
