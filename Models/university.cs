using System.ComponentModel.DataAnnotations;
namespace universidades.Models;
public class University{
    [Key]
    public Guid id{get;set;}

    [Required]
    [MaxLength(250)]
public string? nombre{get;set;}

}