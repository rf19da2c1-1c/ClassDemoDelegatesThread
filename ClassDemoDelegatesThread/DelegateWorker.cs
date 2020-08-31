using System;
using System.Threading.Tasks;

namespace ClassDemoDelegatesThread
{
    internal class DelegateWorker
    {
        // define delegate
        public delegate void MyMethodPointer(int i, int j);

        // method reference
        private MyMethodPointer myMethodPointer;


        /*
         * Predefined delegates
         *
         * Action - alle sammen void retur type
         * forskellige parametre
         * Action => void X(); -- ingen parametre
         * Action<int> => void X(int i) -- een parameter
         *
         *
         * Func - alle sammen en retur værdi
         * Func<string> => string X()
         * Func<int, string> => string X(int x)
         *
         *
         */

        private Action<int, int> MyPointer2; 

        public DelegateWorker()
        {
        }

        public void Start()
        {
            myMethodPointer = (i, i1) => { Console.WriteLine($"ADD {i} og {i1} = {(i + i1)}"); };



            // call myMethodPointer
            myMethodPointer(5, 10);

            myMethodPointer = Sub;
            myMethodPointer(5, 10);


            MyPointer2 = Sub;
            MyPointer2(7, 11);



            // eksempel på en tråd
            Task.Run(
                // metode i tråden
                () =>
                {
                    for (int i = 0; i < 45; i++)
                    {
                        Console.WriteLine("tal er "+ i);
                    }
                }
                
                );
            Task.Run(
                // metode i tråden
                () =>
                {
                    for (int i = 0; i < 45; i++)
                    {
                        Console.WriteLine("nummer er " + i);
                    }
                }

            );
            Console.WriteLine("fra main thread");
        }

        private void Sub(int i, int j)
        {
            Console.WriteLine($"SUB {i} minus {j} = {i - j}");
        }
    }
}