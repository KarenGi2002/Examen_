using System.ComponentModel.DataAnnotations;

namespace universidades.Models;

public class ranking_system{
    [Key]
    public Guid id{get;set;}

    [Required]
    [MaxLength(250)]
public string? nombre{get;set;}

}