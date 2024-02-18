using System;

namespace DotNetBot.Models;

public class Message : TimeMixin
{
    public int Id { get; set; }
    public int SenderId { get; set; }
    public int ReceiverId { get; set; }
    public string Text { get; set; }

    public Message()
    {
    }
}
