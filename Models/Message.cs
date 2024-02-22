using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetBot.Models;

public class Message : TimeMixin
{
    public int Id { get; set; }
    public int SenderId { get; set; }
    public int ReceiverId { get; set; }
    public string Text { get; set; }
    public string? Group { get; set; }  // NRP: optional reference type property, requires constructor to suppress compiler warnings

    public Message(string text, string? group = null)
    {
        Text = text;
        Group = group;
    }
}

public class MessageEntityTypeConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.Property(m => m.SenderId).IsRequired();
        builder.Property(m => m.ReceiverId).IsRequired();
        builder.Property(m => m.Text).IsRequired();
    }
}
