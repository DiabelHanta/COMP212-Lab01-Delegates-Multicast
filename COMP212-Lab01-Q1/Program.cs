using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP212_Lab01_Q1
{
    class CalculateDelegate
    {
        //Global Delegate Variable
        public delegate void CalculateDel(double num1, double num2);

        //Delegate Methods (Operations)
        //HELP: Do I make it a VOID or a DOUBLE return?
        public double Add(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }

        public double Subtract(double num1, double num2)
        {
            double difference = num1 - num2;
            return difference;
        }

        public double Multiply(double num1, double num2)
        {
            double product = num1 * num2;
            return product;
        }

        public double Divide(double num1, double num2)
        {
            double quotient = num1 / num2;
            return quotient;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Delegate Variables
            //CalculateDel addDel, subDel, multDel, divDel;

            //Instance Variables

        }
    }
}
