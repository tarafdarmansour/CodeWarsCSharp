using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCSharp
{
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems
                .Where(o => o.GetType() == typeof(int))
                .Select(o => (int)o)
                .AsEnumerable();
        }
    }
}
