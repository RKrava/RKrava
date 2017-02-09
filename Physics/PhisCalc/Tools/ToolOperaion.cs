using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace PhisCalc.Tools
{
    class ToolOperaion
    {
        static double q = 4980000;

        static public bool checkInput( TextBox tb)
        {
            return double.TryParse(tb.Text, out double par);
        }

        static public List<double> getResult(List<string> inputs, bool checkOtop,
            bool checkAvoton, bool checkOffice)
        {
            List<double> par = new List<double>();
            List<double> res = new List<double>() { 0, 0, 0, 0, 0, 0 };
            foreach (string str in inputs)  
            {
                if (double.TryParse(str, out double input))
                {
                    par.Add(double.Parse(str));
                }
                else
                {
                    par.Add(0);
                }
            }
           res[0] = checkAvoton ? q * 0.7168 * par[2] * (checkOtop ? 1 : 6) : par[3] * 1163.9;
            res[1] = par[4] * (checkOffice ? 3 : (183 / 2) * 0.25);
            res[2] = 1.6 * par[5] * par[6] * par[7];
            res[3] = Math.Abs(par[0] - par[1]);
            res[4] = res[0] + res[1] + res[2];
            res[5] = (res[3] + res[4]) / par[8];
            return res;
        }
    }
}
