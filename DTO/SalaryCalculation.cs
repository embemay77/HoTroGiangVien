using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SalaryCalculation
    {
        public int CalculationId { get; set; }
        public int UserId { get; set; }
        public DateTime Month { get; set; }
        public decimal TotalHours { get; set; }
        public decimal TotalEarnings { get; set; }
    }

}
