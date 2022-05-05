namespace StudySystem.Models
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
        public Publisher(object[] items) : base((int)items[0])
        {
            Address = (string)items[1];
            UrAddress = (string)items[2];
            Name = (string)items[3];
            Requisites = (string)items[4];
            Mobile = (int)items[5];
        }
    }
}
