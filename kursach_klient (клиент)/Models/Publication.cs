using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach_klient.Models
{
    public class Publication:Model
    {
        public string Id { get; private set; }
        public string Title { get; private set; }
        public DateTime Date { get; private set; }
        public string Theme { get; private set; }
        public int Size { get; private set; }
        public Publication(int id) : base(id)
        {
            
        }
    }
}
