using System.Text.Json;

namespace Design_Pattern.S;

public class ShoppingList
{
    private readonly Dictionary<string, int> _shoppingItems;
    
    private ShoppingList()
    {
        _shoppingItems = new Dictionary<string, int>();
    }
    private ShoppingList(Dictionary<string, int> inputList)
    {
        _shoppingItems = inputList;
    }

    public static ShoppingList Create(Dictionary<string, int> shoppingItems) => new ShoppingList(shoppingItems);

    public static ShoppingList Empty => new ShoppingList();
    
    public void AddItemToShoppingList(string itemName, int amount)
    {
        if (string.IsNullOrWhiteSpace(itemName))
            throw new ArgumentException("Item name cannot be null or empty.", nameof(itemName));
    
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero.");
        
        if (_shoppingItems.TryGetValue(itemName, out int currentAmount))
        {
            _shoppingItems[itemName] = currentAmount + amount;
        }
        else
        {
            _shoppingItems[itemName] = amount;
        }
    }

    public void RemoveItemFromShoppingList(string itemName, int amount)
    {
        if (string.IsNullOrWhiteSpace(itemName))
            throw new ArgumentException("Item name cannot be null or empty.", nameof(itemName));
    
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero.");       
        
        if (!_shoppingItems.TryGetValue(itemName, out int currentAmount))
            return;
        
        int newAmount = currentAmount - amount;
        
        if (newAmount < 1)
        {
            _shoppingItems.Remove(itemName);
        }
        else
        {
            _shoppingItems[itemName] = newAmount;
        }
    }
    
    public static ShoppingList LoadShoppingList(string fileName)
    {
        if (!File.Exists(fileName))
            throw new FileNotFoundException("The file does not exists");

        string rawInput = File.ReadAllText(fileName);

        Dictionary<string,int>? deserialize = JsonSerializer.Deserialize<Dictionary<string, int>>(rawInput);
        return deserialize != null ? Create(deserialize) : Empty;
    }

    public void SaveToFile(string fileName, bool overwrite = true)
    {
        string serialize = JsonSerializer.Serialize(_shoppingItems);

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
    
    /// <inheritdoc />
    public override string ToString()
    {
        return string.Join(Environment.NewLine, _shoppingItems);
    }
}