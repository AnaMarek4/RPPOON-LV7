using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class LinearSearch : ISearch
    {
        private double number;

        public LinearSearch(double numberToSearch)
        {
            this.number = numberToSearch;
        }

        public bool Search(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
