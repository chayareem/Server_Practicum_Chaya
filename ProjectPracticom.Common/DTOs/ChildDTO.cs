using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPracticom.Repositories.Entities;

namespace ProjectPracticom.Common.DTOs
{
    public class ChildDTO
    {
        public int Id { get; set; }

        public string? ChildId { get; set; }

        public string? FullName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [ForeignKey("Parent")]
        public int? ParentId { get; set; }

        public virtual User Parent { get; set; }

    }
}
