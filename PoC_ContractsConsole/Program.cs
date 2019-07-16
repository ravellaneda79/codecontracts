using PoC_Contracts;
using System;
using System.Collections.Generic;

namespace PoC_ContractsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var abbreviator = new PoC_Abbreviators();

            try
            {
                abbreviator.Change(string.Empty, new List<string>());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Caused exception: {e.Message}");
            }
        }
    }
}
