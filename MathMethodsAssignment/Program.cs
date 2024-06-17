using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating class
            MathMethods1 mathMethods1 = new MathMethods1();

            Console.WriteLine("Please enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //calls method DivideByTwo from the class above 
            mathMethods1.DivideByTwo(userInput);

            int outputResult; //output parameter
            mathMethods1.DivideByTwo(userInput, out outputResult);
            Console.WriteLine("Output result: " + outputResult);
            Console.ReadLine();

        }
    }
}
