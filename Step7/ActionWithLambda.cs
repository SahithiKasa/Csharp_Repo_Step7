using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Step7
{
    class Program6
    {
        static void Main()
        {
            Action<string, int> repeat = (word, count) =>
            {
                for (int i = 0; i < count; i++)
                    Console.WriteLine(word);

            };
            repeat("Hello Sahithi", 5);





            Action confirmOrder1 = () =>
            {
                Console.WriteLine($"Waiter: Order for 'Pasta' confirmed.");
            };

            confirmOrder1();



            Action<string> confirmOrder2 = (string orderName) =>
            {
                Console.WriteLine($"Waiter: Order for {orderName} confirmed.");
            };

            confirmOrder2("Coffee");


            Action<string, string> confirmOrder3 = (string orderName, string orderDetail) =>
            {
                Console.WriteLine($"Waiter: Order for {orderName} confirmed. Details: {orderDetail}");
            };
            confirmOrder3("Pasta", "Extra Cheese");


            Action<string, string, decimal> confirmOrder4 = (string orderName, string orderDetail, decimal Price) =>
            {
                Console.WriteLine($"Waiter: Order for {orderName} confirmed. Details: {orderDetail} and Price is {Price}");
            };
            confirmOrder4("Pasta", "Extra Cheese", 100.99m);



            //16 paramerts



            Action<int, string> StudentDetails = (int id, string name) =>
                {
                    Console.WriteLine($"Student id is {id} and name is {name}");

                };
            StudentDetails(1, "Sahithi");



            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            Action<int> print = n => Console.WriteLine(n);

            numbers.ForEach(print);


        /*    🔍 Line - by - Line Explanation


-- -
 
✅ 1.List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            You are creating a List of integers.


The list contains:

            1, 2, 3, 4, 5


This is the collection we want to loop through.




-- -
 
✅ 2.Action<int> print = n => Console.WriteLine(n);

            This line creates an Action delegate with a lambda expression.


Breakdown:
 
✔ Action<int>

Means:
A delegate that accepts one int parameter
and returns void(nothing).
 
 
✔ n => Console.WriteLine(n)


This is a lambda expression.

n is the input parameter.

Console.WriteLine(n) is the action (code to run).
 
 
✔ So this means:


> “Take an integer n and print it.”
 
 
 
Example:

            If n = 3, then Console.WriteLine(3) runs.
            



            -- -
 
✅ 3.numbers.ForEach(print);

            ForEach will loop through each element in the list.


For each element, it will call the Action delegate (print).



Internally ForEach works like:
 
foreach (int number in numbers)
            {
                print(number);
            }*/



        }
    }
}    
            