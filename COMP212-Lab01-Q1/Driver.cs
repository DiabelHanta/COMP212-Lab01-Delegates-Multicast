using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP212_Lab01_Q1
{
    //Delgate Declared
    public delegate void CalculateDel(double number);

    class Driver
    {
        //Static Double
        static double staticNum = 10;

        //Methods (Operations)
        public static double Add(double num)
        {
            staticNum = staticNum + num;
            return staticNum;
        }

        //Methods (Operations)
        public static double Subtract(double num)
        {
            staticNum = staticNum - num;
            return staticNum;
        }

        public static double Multiply(double num)
        {
            staticNum = staticNum * num;
            return staticNum;
        }

        public static double Divide(double num)
        {
            if (num == 0)
            {
                Console.WriteLine("Error! Can't divide by 0!");
            }
            else
            {
                staticNum = staticNum / num;
            }
            return staticNum;
        }

        static void Main(string[] args)
        {
            //Delegate Instances Created
            CalculateDel multiCastDel = new CalculateDel(addDel, addDel, multDel, divDel);

            CalculateDel addDel = new CalculateDel(Add);
            CalculateDel subDel = new CalculateDel(Subtract);
            CalculateDel multDel = new CalculateDel(Multiply);
            CalculateDel divDel = new CalculateDel(Divide);

            //User Prompt
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the first number: \nEnter the second number: ", num1, num2);

            
        }
    }
}