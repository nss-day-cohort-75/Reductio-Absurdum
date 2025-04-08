List<Product> products = new List<Product> () {
     
     new Product() {
        Name = "Magic Wand",
        Price = 20.00M,
        Avaiable = false,
        DaysOnShelf = new DateTime( 2015, 3, 15),
        ProductTypeId = 1
     },

     new Product() {
        Name = "Health Potion",
        Price = 30.00M,
        Avaiable = true,
        DaysOnShelf = new DateTime ( 1980, 4, 13),
        ProductTypeId = 2
     },

     new Product() {
        Name ="Wizard Robe",
        Price = 50.00M,
        Avaiable = true,
        DaysOnShelf= new DateTime ( 1800, 7, 7),
        ProductTypeId = 3
     },

     new Product() {
        Name = "Magical Mirror",
        Price = 100.00M,
        Avaiable = true,
        DaysOnShelf = new DateTime ( 1400, 4, 13),
        ProductTypeId = 4
     }
};

List<ProductType> productTypes = new List<ProductType>() {

    new ProductType() {
        Id = 1,
        Name = "Wands"
    },

    new ProductType() {
        Id = 2,
        Name = "Potions"
    },

    new ProductType() {
        Id = 3,
        Name = "Apparel"
    },

    new ProductType() {
        Id = 4,
        Name = "Enchanted Objects"
    }
};

string option = null;
while(option != "0")

Console.WriteLine(@"1.View all products
                     2.Select a category
                     3.Add a product
                     4.Delete a product
                     5.Update a product");
option = Console.ReadLine();
if(option == "1") {
    ProductList();
}


void ProductList() {
    List<Product> =>
    Product.Select(item => item.ToList())
        foreach (string Product in products)

}