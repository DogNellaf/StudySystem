using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach_klient.Models
{
    public class Publisher:Model
    {
        public string Address { get; private set; }
        public string UrAddress { get; private set; }
        public string Name { get; private set; }
        public string Requisites { get; private set; }
        public int Mobile { get; private set; }
        public Publisher(int id): base(id)
        {

        }
    }
}
