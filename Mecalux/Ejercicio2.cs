public class Ejercicio2
{
    public class Element
    {
        public Component? Component { get; set; }
    }

    public class Component
    {
        public DateTime? ComponentDate { get; set; }
    }

    public List<Element> ElementsFiltered(List<Element> elements, int year)
    {
        return elements.Where(x => x.Component?.ComponentDate != null
                                && x.Component.ComponentDate.Value.Year >= year).ToList();
    }

    //El acceso a los elementos vendría de una capa "Repository" con su contexto de BBDD
}


  