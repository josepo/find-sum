using System.Collections.Generic;

namespace FindSum
{
   public class Sum
   {
      public int Result(List<int> values)
      {
         int i = 0, j, k;
         int p = 0, q = 0, r = 0;
         bool found = false;

         while (!found && i < values.Count)
         {
            j = i + 1;

            while (!found && j < values.Count)
            {
               k = j + 1;
               
               while (!found && k < values.Count)
               {
                  p = values[i];
                  q = values[j];
                  r = values[k];

                  if (p + q + r == 2020)
                     found = true;

                  k++;
               }

               j++;
            }

            i++;
         }

         return p * q * r;
      }
   }
}