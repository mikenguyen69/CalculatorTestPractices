using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Calculator
    {
        public static object Plus(object a, object b)
        {
            if (a is string || b is string) return "Invalid input for a or b";

            if (a is int && b is int)
                return (int)a + (int)b;

            if (a is double && b is int)
            {
                return (double)a + (int)b;
            }
            else if (a is int & b is double)
            {
                return (int)a + (double)b;
            }
            else
            {
                return (double)a + (double)b;
            }

        }

        internal static object Multiplier(object a, object b)
        {
            if (a is string || b is string)
                return "Invalid input for a or b";

            if (a is int && b is int)
                return (int)a * (int)b;

            if (a is double && b is int)
            {
                return (double)a * (int)b;
            }
            else if (a is int & b is double)
            {
                return (int)a * (double)b;
            }
            else
            {
                return (double)a * (double)b;
            }
        }

        internal static object Divide(object a, object b)
        {
            if (a is string || b is string)
                return "Invalid input for a or b";

            if (b is int && (int)b == 0)
                return "Can't divide 0";

            if (a is int && b is int)
            {
                return (int)a / (double)((int)b);
            }

            if (a is double && b is int)
            {
                return (double)((double)a / (int)b);
            }
            else if (a is int & b is double)
            {
                return (double)((int)a / (double)b);
            }
            else
            {
                return (double)((double)a / (double)b);
            }
        }

    }
}
