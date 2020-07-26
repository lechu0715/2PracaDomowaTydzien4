using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien4Lekcja12
{
    class FizzBuzz
    {
        public string Game(int value)
        {
            
            if (value % 3 == 0 && value % 5 == 0)
            {
                return "FizBuz";
            }
            else if (value % 3 == 0)
            {
                return "Fizz";
            }
            else if (value % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return value.ToString();
            }
        }
    }

    

}
