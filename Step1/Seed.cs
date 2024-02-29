using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awalé
{
    public class Seeds
    {
        public int Count { get; set; }

        public Seeds(int count)
        {
            Count = count;
        }
        /// <summary>
        /// yigiygiyhgiy
        /// </summary>
        /// <param name="additionalSeeds"></param>
        
        public void AddSeeds(int additionalSeeds)
        {
            Count += additionalSeeds;
        }

        public void RemoveAllSeeds()
        {
            Count = 0;
        }
    }

}
