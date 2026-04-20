using System.ComponentModel.DataAnnotations;

namespace Northwind.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public string CustomerId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        [Required]
        public string ShipAddress { get; set; }

        [Required]
        public string ShipCity { get; set; }

        [Required]
        public string ShipRegion { get; set; }

        [Required]
        public string ShipPostalCode { get; set; }

        [Required]
        public string ShipCountry { get; set; }
    }
}
