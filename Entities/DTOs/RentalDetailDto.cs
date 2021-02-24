using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int Id { get; set; }
        public string CarDescription { get; set; }
        public string CarBrandName { get; set; }
        public string  CarColorName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCompanyName { get; set; }
        public DateTime RentDate { get; set; }
        public Nullable<DateTime> ReturnDate { get; set; }
    }
}
