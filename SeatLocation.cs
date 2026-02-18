using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAssignment1
{
    internal struct SeatLocation
    {
        public char SeatRow;
        public int SeatNumber;

        public SeatLocation(char row,int number)
        {
          this.SeatRow= char.ToUpper(row);
           this.SeatNumber= number;
        }
        public override string ToString()
        {
            return $"{SeatRow}{SeatNumber}";
        }
    }
}
