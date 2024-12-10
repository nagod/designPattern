using Design_Pattern.O;
using ShoppingList = Design_Pattern.O.ShoppingList;

namespace Design_Pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        /* S
        ShoppingList emptyShoppingList = ShoppingList.Empty;

        emptyShoppingList.AddItemToShoppingList("Apfel", 2);
        emptyShoppingList.AddItemToShoppingList("Birne", 4);


        Console.WriteLine("----Deine ShoppingList-----");
        Console.WriteLine(emptyShoppingList);

        try
        {
            const string FILE_NAME = @"/Users/denizd/Desktop/shoppinlist.txt";

            ShoppingList loadedShoppingList = ShoppingList.LoadShoppingList(FILE_NAME);
            Console.WriteLine("---Loaded ShoppingList");
            Console.WriteLine(loadedShoppingList);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        */

        Product apple = new Product("apple", 199, ProductType.Allgemein);
        Product banana = new Product("banana", 2500, ProductType.Allgemein);
        Product milk = new Product("milk", 1.99, ProductType.MilchProdukt);
       

        ShoppingList shoppingList = ShoppingList.Create([apple, banana, milk]);
        Product bread = new Product("schwarzbrot", 0.99, ProductType.Backware);
        shoppingList.AddProduct(bread);

        ShoppingList filterByType = shoppingList.GetItemsByType(ProductType.Allgemein);
        ShoppingList filterByPrice = shoppingList.GetItemsByPrice(200);

        Console.WriteLine(shoppingList);
        Console.WriteLine();
        Console.WriteLine(filterByType);
        Console.WriteLine();
        Console.WriteLine(filterByPrice);
    }
}