using System.ComponentModel.DataAnnotations;

namespace CarManagement.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public byte State { get; set; } = 1;
        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; } = DateTime.Now;
        [DataType(DataType.DateTime)]
        public DateTime? Modified { get; set; }

        public ICollection<Car>? Cars { get; set; }
    }
}
