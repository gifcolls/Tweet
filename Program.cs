using System;
using GiselleF_301215601.Models;

namespace GiselleF_301215601
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("++++++++++++++++TEST HARNESS++++++++++++++\n");
            TweetManager.ShowAll();
            Console.WriteLine("\n");
            TweetManager.ShowAll("Jays");
            
        }
    }
}

