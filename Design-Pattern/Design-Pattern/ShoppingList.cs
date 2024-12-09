using System.Text.Json;

namespace Design_Pattern;

public class ShoppingList
{
    /*
     * key = name des items
     * value = Anzahl der zu Kaufenden items
     * _shoppingItems = { {key: "Apfel", value: 3}, {key: "Birne", value:12}, ....}
     */
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

    /// <summary>
    /// Adds item name and amount to dictionary
    /// </summary>
    /// <param name="itemName"></param>
    /// <param name="amount"></param>
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
        //_shoppingItems[itemName] = _shoppingItems.TryGetValue(itemName, out int currentAmount2) ? currentAmount2 + amount : amount;
    }

    public void RemoveItemFromShoppingList(string itemName, int amount)
    {
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

    /// <inheritdoc />
    public override string ToString()
    {
        return string.Join(Environment.NewLine, _shoppingItems);
    }

    public static ShoppingList LoadShoppingList(string fileName)
    {
        if (!File.Exists(fileName))
            throw new FileNotFoundException("The file does not exists");

        string rawInput = File.ReadAllText(fileName);

        Dictionary<string,int>? deserialize = JsonSerializer.Deserialize<Dictionary<string, int>>(rawInput);
        if (deserialize != null)
            return ShoppingList.Create(deserialize);

        return Empty;
    }

    public void SaveToFile(string fileName, bool overwrite = true)
    {
        string serialize = JsonSerializer.Serialize(_shoppingItems);

        if (overwrite || !File.Exists(fileName))
        {
            File.WriteAllText(fileName, serialize);
            Console.WriteLine($"Successfully saved to {fileName}");
        }
        else
        {
            Console.WriteLine("File already exists. Enter a new name or set overwrite to true");
        }
            
    }
}