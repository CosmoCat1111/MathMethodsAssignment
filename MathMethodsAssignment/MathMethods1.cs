using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethodsAssignment
{
    public class MathMethods1
    {
        //2 methods that take one integer parameter and return an integer
        public void DivideByTwo(int number) //method divides and shows result
        {
            int result = number / 2;
            Console.WriteLine("result of divide: " + result);
        }

        public void DivideByTwo(int number, out int result) //method overload, uses output parameters
        {
            result = number / 2;
        }
    }
}
