using System.ComponentModel.DataAnnotations;

namespace universidades.Models;

public class criteria{
    [Key]
    public Guid id{get;set;}

  [Required]
    [MaxLength(250)]
public int system_id{get;set;}

    [Required]
    [MaxLength(250)]
public string? nombre{get;set;}

}