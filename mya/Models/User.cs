using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mya.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Patronimic { get; set; }        
        public string Email { get; set; }        
        public string Password { get; set; }
        public string Phone { get; set; }
        public string? Photo { get; set; }
        public char Gender { get; set; }
        public Role Role { get; set; }
    }
}
