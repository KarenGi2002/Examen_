using System.ComponentModel.DataAnnotations;

namespace universidades.Models;

public class Country{
    [Key]
    public Guid id{get;set;}

    [Required]
    [MaxLength(250)]
public string? nombre{get;set;}

}