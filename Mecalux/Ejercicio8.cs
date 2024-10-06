public class Ejercicio8
{
    public void FileRead()
    {
        string filePath = "laRutaDelArchivo.txt";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                //Optamos por leer linea a linea para no usar la memoria leyendo el fichero completo.
                string line;
                while ((line = reader.ReadLine()) != null)
                {                
                    //Segun lo que queramos hacer con el fichero, aquí solo lo pintamos en pantalla.
                    Console.WriteLine(line);
                }
            }

            //Alternativa C# >= 6.0 
            //foreach (var line in File.ReadLines(filePath))
            //{
            //    Console.WriteLine(line);
            //}
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"El archivo no fue encontrado: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Ocurrió un error al leer el archivo: {ex.Message}");
        }
    }
}
