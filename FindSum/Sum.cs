using System.Collections.Generic;

namespace FindSum
{
   public class Sum
   {
      public int Result(List<int> values)
      {
         int i = 0, j;
         int p = 0, q = 0;
         bool found = false;

         while (!found && i < values.Count)
         {
            j = i + 1;

            while (!found && j < values.Count)
            {
               p = values[i];
               q = values[j];

               if (p + q == 2020)
                  found = true;

               j++;
            }

            i++;
         }

         return p * q;
      }
   }
}