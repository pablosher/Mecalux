public class Ejercicio7
{
    public class Component
    {
        public string Name { get; set; }
    }

    public class ComponentCollection
    {
        //Optamos por un diccionario al poder acceder por nombre de manera más rápida que una búsqueda mediante una List
        private Dictionary<string, Component> _components = new Dictionary<string, Component>();


        public void AddComponent(Component component)
        {
            if (component == null)
            {
                Console.WriteLine("El componente no puede ser nulo.");
                return;
            }

            if (_components.ContainsKey(component.Name))
            {
                Console.WriteLine($"Ya existe un componente con el nombre '{component.Name}'.");
                return;
            }

            _components[component.Name] = component;
        }

        public Component GetComponentByName(string name)
        {
            _components.TryGetValue(name, out var component);
            return component;
        }
    }
}

