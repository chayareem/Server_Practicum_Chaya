using ProjectPracticom.Repositories.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPracticom.WebAPI.Models
{
    public class ChildModel
    {
        public string ChildId { get; set; }

        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int ParentId { get; set; }

    }
}
