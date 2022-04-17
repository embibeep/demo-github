using System.ComponentModel.DataAnnotations;

namespace NguyenTrongNgoc.Models
{
    public class News
    {
        public int ID { get; set; }
        [StringLength(200, MinimumLength = 50)]
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string ImageUrl { get; set; } = string.Empty;
        [StringLength(500, MinimumLength = 100)]
        [Required]
        public string Content { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; }

    }
}