using System.Runtime.InteropServices;

List<Product> products = new List<Product>() {

     new Product() {
        Name = "Magic Wand",
        Price = 20.00M,
        Avaiable = false,
        DaysOnShelf = new DateTime( 2015, 3, 15),
        ProductTypeId = "1"
     },

     new Product() {
        Name = "Health Potion",
        Price = 30.00M,
        Avaiable = true,
        DaysOnShelf = new DateTime ( 1980, 4, 13),
        ProductTypeId = "2"
     },

     new Product() {
        Name ="Wizard Robe",
        Price = 50.00M,
        Avaiable = true,
        DaysOnShelf= new DateTime ( 1800, 7, 7),
        ProductTypeId = "3"
     },

     new Product() {
        Name = "Magical Mirror",
        Price = 100.00M,
        Avaiable = true,
        DaysOnShelf = new DateTime ( 1400, 4, 13),
        ProductTypeId = "4"
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
while (option != "0")
{



    Console.WriteLine(@"1.View all products
                     2.Select a category
                     3.Add a product
                     4.Delete a product
                     5.Update a product");
    option = Console.ReadLine();
    if (option == "1")
    {
        ProductList();
    }
    else if (option == "2")
    {
        Console.WriteLine($"Pick a Category");
        CategoryList();

        PickCategory();
    }
    else if (option == "3") {
        AddProduct();
    }


}
void ProductList()
{
    List<Product> items = products.Select(item => item).ToList();
    foreach (Product product in products)
    {
        Console.WriteLine(product.Name);
    }

}

void CategoryList()
{
    List<ProductType> productCategory = productTypes.Select(category => category).ToList();
    foreach (ProductType product in productTypes)
    {
        // this list our categories
        Console.WriteLine(product.Id + ". " + product.Name);
    }
}

void PickCategory()
//where trying to get to pick a category and display the matching product
{
    string selectedTypeId = Console.ReadLine();

    // get all the products with the id selected
    List<Product> selectedType = products.Where(p => p.ProductTypeId == selectedTypeId).ToList();

    // display the ones that match
    foreach (Product type in selectedType)
        Console.WriteLine(type.Name);
}

void AddProduct() 
{
    Console.WriteLine("Enter name of Product");
    string Name = Console.ReadLine();

    Console.WriteLine("Enter cost of price with decimal");
    string Price = Console.ReadLine();
    decimal priceInput =  0;
    try 
    {
        priceInput = decimal.Parse(Price);
    }
     catch {
        Console.WriteLine("Enter a price with a decimal");
        return;
     }
    
    Console.WriteLine("Is product avaiable? (true/false)");
    string Avaiable = Console.ReadLine();
    bool Avaiablity = false;
    if(Avaiable == "true") {
        Avaiablity = true;
    }
    else if (Avaiable == "false") {
        Avaiablity = false;
    }

    Console.WriteLine("Enter Date format (yyyy/m/d)");
    string DaysOnShelf = Console.ReadLine();
    DateTime  shelfDate;
    try {
        shelfDate = DateTime.Parse(DaysOnShelf);
    }
    catch {
        Console.WriteLine("Please write date (yyyy/m/d)");
        return;
    }


    Console.WriteLine("Enter a category");
    CategoryList();
    string productTypeId = Console.ReadLine();

    Product newProduct = new Product() {
        Name = Name,
        Price = priceInput,
        Avaiable = Avaiablity,
        DaysOnShelf = shelfDate,
        ProductTypeId = productTypeId
    };
    products.Add(newProduct);

}


