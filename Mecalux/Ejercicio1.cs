public class Ejercicio1
{
    public interface IElement
    {
        Guid AddDate(DateTime date);
        DateTime GetDate(Guid id);
    }


    public class ElementService
    {
        private readonly IElement iElement;

        public ElementService(IElement iElement)
        {
            this.iElement = iElement;
        }

        public Guid AddElement(Guid id)
        {
            return iElement.AddDate(DateTime.Now);
        }
        public DateTime GetElement(Guid id)
        {
            return iElement.GetDate(id);
        }
    }

    public class Element : IElement
    {
        private readonly IDictionary<Guid, DateTime> dates = new Dictionary<Guid, DateTime>();

        public Guid AddDate(DateTime date)
        {
            Guid id = Guid.NewGuid();
            this.dates.Add(id, date);
            return id;
        }

        public DateTime GetDate(Guid id)
        {
            return this.dates[id];
        }
    }
}



////Posibilidad de implementar un patron factory
//public interface IElementFactory
//{
//    IElement CreateElement();
//}

//public class ElementFactory : IElementFactory
//{
//    public IElement CreateElement()
//    {
//        return new Element(); 
//    }
//}