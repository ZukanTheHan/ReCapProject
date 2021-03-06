using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
     public class RentalDetailsDto :IDto
    {
        public int RentalId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }

       
        public string Model { get; set; }

        public string UserName { get; set; }

        public string CustomerName { get; set; }

        public decimal AmountPayable { get; set; }

    }
}
