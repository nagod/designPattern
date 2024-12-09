namespace Design_Pattern;

internal class Program
{
    private static void Main(string[] args)
    {
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
    }
}