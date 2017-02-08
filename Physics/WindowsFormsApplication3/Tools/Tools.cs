using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace WindowsFormsApplication3.Tools
{
    class Tools
    {
        static public bool t( TextBox tb)
        {
            double par;
            return double.TryParse(tb.Text, out par);
        }
    }
}
