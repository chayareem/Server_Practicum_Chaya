using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPracticom.Repositories.Entities;

public partial class Child
{
    [Required]
    public int Id { get; set; }
    [StringLength(9)]
    public string ChildId { get; set; }
    [Required]
    public string FullName { get; set; }
    [Required]

    public DateTime DateOfBirth { get; set; }

    public int ParentId { get; set; }

    public virtual User Parent { get; set; }

}
