using System.Collections.Generic;
using Xunit;

namespace FindSum.Tests
{
   public class UnitTest1
   {
      [Fact]
      public void CalculatesResult()
      {
         Sum sum = new Sum();

         int result = sum.Result(new List<int> {
            1721,
            979,
            366,
            299,
            675,
            1456
         });

         Assert.Equal(514579, result);
      }
   }
}
