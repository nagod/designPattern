namespace Design_Pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        
        const string FILE_NAME = @"/Users/denizd/Desktop/shoppinlist.txt";
        ShoppingList emptyShoppingList = ShoppingList.Empty;
        
        ShoppingList loadedShoppingList = ShoppingList.LoadShoppingList(FILE_NAME);
        
        emptyShoppingList.AddItemToShoppingList("Apfel", 2);
        emptyShoppingList.AddItemToShoppingList("Birne", 4);
    
        
        Console.WriteLine("----Deine ShoppingList-----");
        Console.WriteLine(emptyShoppingList.ToString());
        
        Console.WriteLine("---Loaded ShoppingList");
        Console.WriteLine(loadedShoppingList.ToString());
    }
}