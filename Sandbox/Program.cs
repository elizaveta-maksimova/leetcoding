﻿using System;
using Azure.Storage.Queues;
using Azure.Storage.Sas;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumSubArray.Execute();
            Console.ReadKey();
        }
    }
}