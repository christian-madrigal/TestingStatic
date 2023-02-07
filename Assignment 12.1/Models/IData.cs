using System.Collections.Generic;
namespace Assignment_12._1.Models
{
    public interface IData
    {
        List<Product> Products { get; set; }
        List<Product> InitializeData();
        Product GetProduct(int? id);
    }
}
