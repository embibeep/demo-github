namespace Todo.Models;
using System.ComponentModel.DataAnnotations;
public class Todo
{
    //Creator, author
    //title | lable
    //content | main
    //time
    //isDone

    [Required(ErrorMessage = "Lỗi")] //bawcs buoc pphai co
    [MaxLength(5, ErrorMessage = "ten tac gia phai nho hon 5 ki tu")] //do dai lon nhat ten tacs giar
    [MinLength(2)]
    public int Id { get; set; }
    [Required]
    public string Author { get; set; } = string.Empty;
    [Required]
    [MinLength(10)]
    public string Title { get; set; } = string.Empty;
    [Required]
    [MinLength(20)]
    public string Content { get; set; } = string.Empty;
    [Required]
    public DateTime Time { get; set; }
    [Required]

    public bool isDone { get; set; }
    



}