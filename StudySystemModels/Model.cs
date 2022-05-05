
namespace StudySystem.Models
{
   public class Model
    {
        public int Id { get; private set; }
        public Model(int id)
        {
            Id = id;
        }
        public Model(object[] items)
        {
            Id =(int)items[0];
        }

        public virtual string InsertData => throw new System.Exception("Попытка добавить в базу шаблон модели");
    }
}
