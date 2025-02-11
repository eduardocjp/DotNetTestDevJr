using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int StockQuantity { get; set; }
}

public static class Repository
{
    public static List<Product> Products = new List<Product>
    {
        new Product { Id = 1, Name = "Produto A", StockQuantity = 0 },
        new Product { Id = 2, Name = "Produto B", StockQuantity = 5 },
        new Product { Id = 3, Name = "Produto C", StockQuantity = 10 },
        new Product { Id = 4, Name = "Produto D", StockQuantity = 0 },
        new Product { Id = 5, Name = "Produto E", StockQuantity = 2 }
    };
}

public class Task7
{
    /*
     * Desenvolva um método que retorne o nome dos produtos que estão com estoque zerado
     */
    public static List<string> GetProductsOutOfStock()
    {
        return Repository.Products
            .Where(p => p.StockQuantity == 0) 
            .Select(p => p.Name) 
            .ToList(); 
    }

    /*
     * Desenvolva um método que retorne a soma total das quantidades de estoque dos itens
     */
    public static int GetSumStock()
    {
        return Repository.Products
            .Sum(p => p.StockQuantity); 
    }

    /*
     * Crie um método que verifique, dado Id e quantidade solicitada do produto,
     * se o mesmo possui quantidade em estoque para venda
     */
    public static bool IsSalePossible(int productId, int orderQuantity)
    {
        var product = Repository.Products
            .FirstOrDefault(p => p.Id == productId); 

        if (product == null)
        {
            return false; 
        }

        return product.StockQuantity >= orderQuantity; 
    }
}

