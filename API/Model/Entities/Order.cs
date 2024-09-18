using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public double Amount { get; set; }
        public int OrderStatus { get; set; }
        public int TotalQuantity { get; set; }
        public DateTime OrderedDate { get; set; } = DateTime.UtcNow;
        public User Users { get; set; }

    }
}
