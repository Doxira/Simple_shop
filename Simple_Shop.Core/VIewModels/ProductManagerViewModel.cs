using Simple_Shop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Shop.Core.VIewModels
{
    public class ProductManagerViewModel
    {
       public Product Product { get; set; }   
       public IEnumerable<ProductCategory> ProductCategories { get; set; }  
        
    }
}
