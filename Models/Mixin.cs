using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetBot.Models;

public abstract class TimeMixin
{
    [Required]
    public virtual DateTime CreatedAt { get; set; }
    [Required]
    public virtual DateTime UpdatedAt { get; set; }
}
