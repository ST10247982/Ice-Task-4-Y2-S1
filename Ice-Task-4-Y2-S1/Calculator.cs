using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_4_Y2_S1
{
    public  class Calculator
    {
        //delegate to store method references
        public delegate void OperationEventHandler(double num1, double num2);

        public event OperationEventHandler OperationPerformed;

        //Methods for calculator
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            //raising the event
            OperationPerformed(num1, num2);
            return result;
        }

        public double Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            //raising the event
            OperationPerformed(num1, num2);
            return result;
        }

        public double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            //raising the event
            OperationPerformed(num1, num2);
            return result;
        }

        public double Divide(double num1, double num2)
        {
            double result = num1 / num2;
            //raising the event
            OperationPerformed(num1, num2);
            return result;
        }
    }
}
