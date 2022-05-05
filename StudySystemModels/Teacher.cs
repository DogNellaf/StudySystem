namespace StudySystem.Models
{
    public class Teacher: Model
    {
        public string Kafedra { get; private set; }
        public string FirstName { get; private set; }
        public string SecondName { get; private set; }
        public bool IsPublicated { get; private set; }
        public int PublicationsCount { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public Teacher(int id) : base(id)
        {

        }
        public Teacher(object[] items): base((int)items[0])
        {
            Kafedra = (string)items[1];
            FirstName = (string)items[2];
            SecondName = (string)items[3];
            IsPublicated = (bool)items[4];
            PublicationsCount = (int)items[5];
            UserName = (string)items[6];
            Password = (string)items[7];
        }

        public override string InsertData => "INSERT INTO dbo.Teacher (kafedra, firstname, secondname, ispublicated, publicationscount, username, password) VALUES ({})";
    }
}
