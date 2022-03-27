using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class BasketManager
    {
        //naming convention

        public static void AddBasket(Product product)
        {
            Console.WriteLine($"ID-si {product.Id} olan {product.Name}  sebete elave olundu!");
            Console.WriteLine("====================");
        }

        public static void AddBasketTwo(string name, double price, bool isStock) 
        {
            Console.WriteLine($"mehsul adi: {name}, qiymeti: {price}Azn, satisda movcuddur? : {isStock} ");
        }
    }
}
