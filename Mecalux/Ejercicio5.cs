public class Ejercicio5
{
    public interface IDataContainer
    {
        string Data { get; set; }
    }

    public static class DataContainerHandler
    {
        public static void DoWork(object obj)
        {
            if (obj is IDataContainer dataContainer)
            {
                Console.WriteLine(dataContainer.Data);
            }
        }
    }
}
