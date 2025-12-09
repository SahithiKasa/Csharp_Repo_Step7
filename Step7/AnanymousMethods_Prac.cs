using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods_Prac
{
    public delegate void MyDelegate(string message);


    class Program1
    {
        static void Main(string[] args)
        {
            MyDelegate del = delegate (string msg)
            {

                Console.WriteLine("Message received:" + msg);

            };

            del("Hello from Ananymous Method:");
        }
    }
}

