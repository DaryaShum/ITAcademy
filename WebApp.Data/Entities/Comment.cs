using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Data.Entities;

public class Comment
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public string Content { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? DeactivationDate { get; set; }
    public bool Actvity { get; set; }
}
