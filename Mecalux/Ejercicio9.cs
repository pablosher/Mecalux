public class Ejercicio9
{
    public class Product
    {
        public string ProductCode { get; set; }
    }

    public List<Product> UniqueProducts(List<Product> firstList, List<Product> secondList)
    {
        //Utilizamos un HashSet para minimizar las iteraciones respecto a un "Union" y "Except" 
        HashSet<string> productCodes = new HashSet<string>();
        List<Product> uniqueProducts = new List<Product>();

        foreach (var product in firstList)
        {
     
            if (productCodes.Add(product.ProductCode)) 
            {
                uniqueProducts.Add(product); 
            }
        }

        foreach (var product in secondList)
        {
            //Si ya lo hemos añadido previamente, retorna false
            if (productCodes.Add(product.ProductCode))
            {
                uniqueProducts.Add(product);
            }
        }

        return uniqueProducts;
    }
}
