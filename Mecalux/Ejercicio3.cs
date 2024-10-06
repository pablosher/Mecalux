using System.Data.Entity;
using System.Diagnostics;

public class Ejercicio3
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Owner> Owners { get; set; }
    }

    public class Product
    {
        public string ProductCode { get; set; }

        public Owner Owner { get; set; }
    }

    public class Owner
    {
        public string OwnerCode { get; set; }

        public IEnumerable<Product> Products { get; }
    }

    public class ProductService
    {
        private readonly AppDbContext context;

        public ProductService(AppDbContext context)
        {
            context = context;
        }

        //Tras hacer unas pruebas de rendimiento, la consulta directa sobre la entidad Products resulta más eficiente
        //que consultar los Owners y buscar el producto.
        public Product GetProduct(string ownerCode, string productCode)
        {
            var product = context.Products
                .Include(p => p.Owner) 
                .FirstOrDefault(p => p.ProductCode == productCode &&
                                     p.Owner.OwnerCode == ownerCode);

            return product;
        }
    }
}


