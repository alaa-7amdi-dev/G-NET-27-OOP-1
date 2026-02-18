using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAssignment1
{
    internal class Ticket
    {
        public string MovieName { get; set; }
        public TiketType Type { get; set; }
        public SeatLocation SeatLocation { get; set; }
        private double Price { get; set; }

        public Ticket(string name,TiketType type, SeatLocation seat,double price)
        {
            this.MovieName = name;
            this.Type = type;
            this.SeatLocation = seat;
            this.Price = price;
            
        }
        public Ticket(string name) : this(name, TiketType.Standard,new SeatLocation('A',1), 50) { }

        public double CalcTotal(double taxPercentage)
        {
          return Price + (Price * taxPercentage/100);
        }

        public void ApplyDiscount(double discount)
        {
            if (discount > 0 && discount < Price )
            {
                Price -= discount;
         
            }
          
        }

        public void PrintTicket(double taxPercentage) 
        {
            Console.WriteLine($"Movie : {MovieName}");
            Console.WriteLine($"Type : {Type}");
            Console.WriteLine($"Seat : {SeatLocation}");
            Console.WriteLine($"Price : {Price}");
            Console.WriteLine($"Total ({taxPercentage}/tax): {CalcTotal(taxPercentage)}");
        }
    }
}
