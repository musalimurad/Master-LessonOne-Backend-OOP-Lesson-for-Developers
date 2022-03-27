using Methods;

Product productOne = new()
{
    Id = 1,
    Name = "Iphone 13 Pro Max",
    Description = "256gb 8ram black",
    Price = 3500
};


Product productTwo = new()
{
    Id = 2,
    Name = "Samsung galaxy S21 Ultra",
    Description = "128gb 6ram blue",
    Price = 1700
};



Product[] products = new[] { productOne, productTwo };

//type safe = tip guvenlidir c#
foreach (Product product in products)
{
    Console.WriteLine(product.Name);
   
}

//Methods

Console.WriteLine("============================ Methods ========================");

// new instance 
BasketManager basketManager = new();

//Encapsulation
global::Methods.BasketManager.AddBasket(productOne);
global::Methods.BasketManager.AddBasket(productTwo);

//===================================================
global::Methods.BasketManager.AddBasketTwo("Xiaomi", 600, true);


