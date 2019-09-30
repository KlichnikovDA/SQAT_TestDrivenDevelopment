using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSE.SQAT.CalculatorApp
{
    public class Calculator
    {
        double currentValue = 0;
        string operation = "=";
        public double Display { get; set; }
        public void PressEnter()
        {
            Calculate();
            operation = "=";
        }
        public void PressDisplay(double value)
        {
            switch (operation)
            {
                case "+":
                    currentValue += value;
                    break;
                case "-":
                    currentValue -= value;
                    break;
                case "*":
                    currentValue *= value;
                    break;
                case "/":
                    currentValue /= value;
                    break;
                default:
                    currentValue = value;
                    break;
            }
            
        }
        public void PressPlus()
        {
            operation = "+";
        }
        public void PressMinus()
        {
            operation = "-";
        }
        public void PressMultiply()
        {
            operation = "*";
        }
        public void PressDivide()
        {
            operation = "/";
        }
        void Calculate()
        {
            Display = currentValue;
        }
    }
}