using System.Text.Json;

namespace Design_Pattern.S;

public class PersistanceService
{
    public ShoppingList LoadShoppingList(string fileName)
    {
        if (!File.Exists(fileName))
            throw new FileNotFoundException("The file does not exists");

        string rawInput = File.ReadAllText(fileName);

        Dictionary<string,int>? deserialize = JsonSerializer.Deserialize<Dictionary<string, int>>(rawInput);
        return deserialize != null ? ShoppingList.Create(deserialize) :ShoppingList.Empty;
    }
    
    public void SaveToFile(Dictionary<string,int> shoppingItems,string fileName, bool overwrite = true)
    {
        string serialize = JsonSerializer.Serialize(shoppingItems);

        if (overwrite || !File.Exists(fileName))
        {
            File.WriteAllText(fileName, serialize);
            Console.WriteLine($"Shopping list successfully saved to {fileName}");
        }
        else
        {
            File.AppendAllText(fileName, serialize);
            Console.WriteLine("Shopping list successfully added to an existing file");
        }
    }
}