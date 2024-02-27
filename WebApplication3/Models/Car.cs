using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarManagement.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string PlateNumber { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public byte State { get; set; } = 1;
        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; } = DateTime.Now;
        [DataType(DataType.DateTime)]
        public DateTime? Modified { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
