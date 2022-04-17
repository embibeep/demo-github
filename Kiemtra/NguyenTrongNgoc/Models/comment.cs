using System.ComponentModel.DataAnnotations;

namespace NguyenTrongNgoc.Models
{
    public class comment
    {
        public int ID { get; set; }
        public string Author { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; }
    }
}