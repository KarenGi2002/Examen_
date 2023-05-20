using System.ComponentModel.DataAnnotations;

namespace universidades.Models;

public class country{
    [Key]
    public Guid id{get;set;}
    [Required]
public string country_name{get;set;}


}