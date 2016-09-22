using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public class VMLocator
    {
        static MyViewModel _myViewModel = new MyViewModel();

        public static MyViewModel MyViewModel1
        {
            get
            {
                return _myViewModel;
            }

            set
            {
                _myViewModel = value;
            }
        }
    }
}
