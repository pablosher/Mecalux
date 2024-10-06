public class Ejercicio4
{
    public class Component
    {
        public string Name { get; private set; }

        public Element ParentElement { get; private set; }

        private Component(string name, Element parentElement)
        {
            Name = name;
            ParentElement = parentElement;
        }

        public static Component Create(string name, Element parentElement)
        {
            return new Component(name, parentElement);
        }
    }

    public class Element
    {
        public DateTime? ElementDate;

        private Queue<Component> _components = new Queue<Component>();

        public IEnumerable<Component> Components => _components;

        public Component AddComponent(string componentName)
        {
            Component newComponent = Component.Create(componentName, this);

            _components.Enqueue(newComponent);

            return newComponent;
        }
    }

}

