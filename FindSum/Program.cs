using System;
using System.Linq;
using System.Collections.Generic;

namespace FindSum
   {
   class Program
   {
      static void Main(string[] args)
      {
         IEnumerable<string> lines = System.IO.File.ReadLines("../input.txt");

         List<int> values =
            System.IO.File.ReadLines("../input.txt")
            .Select(line => int.Parse(line))
            .ToList();

         Console.WriteLine(new Sum().Result(values));
      }
   }
}
