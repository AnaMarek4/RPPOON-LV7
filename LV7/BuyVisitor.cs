using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class BuyVisitor : IVisitor
    {
        private const double DVDTax = 0.18;
        private const double VHSTax = 0.10;
        private const double BOOKTax = 0.10;

        public double Visit(DVD DVDItem)
        {
            return DVDItem.Price * (1 + DVDTax);
        }

        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * (1 + DVDTax);
        }

        public double Visit(Book bookItem)
        {
            return bookItem.Price * (1 + BOOKTax);
        }
    }
}
