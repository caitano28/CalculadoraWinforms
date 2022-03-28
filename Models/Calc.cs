using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Calc
    {
        public static decimal Plus (decimal valueA, decimal valueB)
        {
            return valueA + valueB;
        }
        public static decimal Minus(decimal valueA, decimal valueB)
        {
            return valueA - valueB;
        }
        public static decimal Times(decimal valueA, decimal valueB)
        {
            return valueA * valueB;
        }
        public static decimal Divide(decimal valueA, decimal valueB)
        {
            if (valueB == 0)
            {
                return 0;
            }
            return valueA / valueB;
        }

        public static decimal Percent(OperationType firstOperation, decimal valueA, decimal valueB)
        {
            valueB /= 100;
            decimal result = 0;
            switch (firstOperation)
            {
                case OperationType.Plus:
                    result = (valueA * valueB) + valueA;
                    break;
                case OperationType.Minus:
                    result = valueA - (valueA * valueB);
                    break;
                case OperationType.Times:
                    result = (valueA * valueB);
                    break;
                case OperationType.Divide:
                    result = (valueA / valueB);
                    break;
            }
            return result;
        }
       
    }
}
