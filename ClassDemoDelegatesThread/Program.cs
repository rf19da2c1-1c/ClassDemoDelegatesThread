using System;

namespace ClassDemoDelegatesThread
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateWorker  worker = new DelegateWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
