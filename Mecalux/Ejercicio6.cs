public class Ejercicio6
{
    public interface IAnimal
    {
        string NombreCientifico();
    }

    public abstract class Animal : IAnimal
    {
        public abstract string NombreCientifico();

        public void Dormir()
        {
            Console.WriteLine("El animal se va a dormir");
        }
    }

    public abstract class Mammals : Animal
    {
        public void MetodoMamifero()
        {
            //Hace algo de mamiferos.
        } 
    }

    public class Cabra : Mammals
    {
        public override string NombreCientifico()
        {
            return "La cabra cientifica";
        }
    }
}
