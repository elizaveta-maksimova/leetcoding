using System;
using Azure.Storage.Queues;
using Azure.Storage.Sas;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveDuplicatesFromArray.Execute();
            Console.ReadKey();
        }
    }
}