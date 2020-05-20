using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class Visitor : IVisitor
    {
        public double Visit(DVD DVDItem)
        {
            if(DVDItem.Type == DVDType.SOFTWARE)
            {
                return (double.NaN);
            }
            return DVDItem.Price * 0.9;
        }

        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * 0.9;
        }

        public double Visit(Book bookItem)
        {
            return bookItem.Price * 0.9;
        }
    }
}
