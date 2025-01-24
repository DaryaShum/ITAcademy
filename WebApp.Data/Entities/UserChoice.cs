using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Data.Entities;

public class UserChoice
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public int MinPositivityRate { get; set; }
    public int MaxPositivityRate { get; set; }
}
