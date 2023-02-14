using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectPracticom.Repositories.Entities;

public partial class User
{
    public int Id { get; set; }
    [Required]
    public string UserId { get; set; } = null!;
    [Required]

    public string FirstName { get; set; } = null!;
    [Required]

    public string LastName { get; set; } = null!;
    [Required]

    public DateTime DateOfBirth { get; set; }
    [Required]

    public string maleOrFemale { get; set; } = null!;
    [Required]

    public string Hmo { get; set; } = null!;

    public virtual ICollection<Child> Children { get; } = new List<Child>();
}
