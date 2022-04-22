using System.ComponentModel.DataAnnotations;

namespace NguyenTrongNgoc.Models
{
    public class Comments {
        public int ID { get; set; }
        [Required]
        public string Author { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; }
    }
}