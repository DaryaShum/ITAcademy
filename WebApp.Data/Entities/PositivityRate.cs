using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Data.Entities;

public class PositivityRate
{
    public Guid Id { get; set; }
    public Guid ArticleId { get; set; }
    public Article Article { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
}
