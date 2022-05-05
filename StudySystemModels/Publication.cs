using System;

namespace StudySystem.Models
{
    public class Publication : Model
    {
        public string Title { get; private set; }
        public DateTime Date { get; private set; }
        public string Theme { get; private set; }
        public int Size { get; private set; }
        public Publication(int id) : base(id)
        {
            
        }
        public Publication(object[] items) : base((int)items[0])
        {
            Title = (string)items[1];
            Date = DateTime.Parse((string)items[2]);
            Theme = (string)items[3];
            Size = (int)items[4];
        }
    }
}
