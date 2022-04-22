using System.ComponentModel.DataAnnotations;

namespace NguyenTrongNgoc.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = string.Empty;
        public List<News> News { get; set; }
    }
}