using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach_klient.Models
{
    public class Teacher: Model
    {
        public string Kafedra { get; private set; }
        public string FirstName { get; private set; }
        public string SecondName { get; private set; }
        public bool IsPublicated { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public Teacher(int id) : base(id)
        {

        }             
    }
}
