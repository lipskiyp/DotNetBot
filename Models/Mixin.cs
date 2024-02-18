using System;

namespace DotNetBot.Models;

public abstract class TimeMixin
{
    public virtual DateTime CreatedAt { get; set; }
    public virtual DateTime UpdatedAt { get; set; }
}
