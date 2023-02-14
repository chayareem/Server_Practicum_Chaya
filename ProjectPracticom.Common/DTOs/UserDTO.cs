using ProjectPracticom.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPracticom.Common.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string UserId { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public string maleOrFemale { get; set; } = null!;

        public string Hmo { get; set; } = null!;

        public virtual ICollection<Child> Children { get; } = new List<Child>();
    }
}
