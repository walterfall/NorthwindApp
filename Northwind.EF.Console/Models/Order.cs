using System.ComponentModel.DataAnnotations;

namespace Northwind.EF.Console.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [StringLength(40)]
        public string ShipName { get; set; }
    }
}
