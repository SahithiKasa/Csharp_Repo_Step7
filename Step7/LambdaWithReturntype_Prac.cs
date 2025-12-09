using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step7
{
    public delegate double CalculationDiscount(double amt);

    class Program3
    {
        static void Main()
        {
            CalculationDiscount discount =(double amount) =>
            {
                if (amount > 1000)
                    return amount * 0.10;
                return amount * 0.05;
            };

            double result = discount(1500);
            Console.WriteLine(result);
        }
    }
}
    

