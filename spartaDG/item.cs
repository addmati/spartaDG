
public enum ItemType
{
    WEAPON,
    ARMOR
}

internal class Item
{
    public string Name { get; }
    public string Desc { get; }

    private ItemType Type;

    public int Atk { get; }
    public int Def { get; }
    public int HP { get; }

    public int Price { get; }

    public bool IsEquipped { get; private set; }
    public bool IsPurchased { get; private set; }

    public Item(string name, string desc, ItemType type, int atk, int def, int hp, int price, bool isEquipped = false, bool isPurchased = false)
    {
        Name = name;
        Desc = desc;
        Type = type;
        Atk = atk;
        Def = def;
        HP = hp;
        Price = price;
        IsEquipped = isEquipped;
        IsPurchased = isPurchased;
    }

    internal void PrintItemStatDescription(bool withNumber = false, int idx = 0)
    {
        Console.Write("- ");
        if (withNumber)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"{idx} ");
            Console.ResetColor();
        }
        if (IsEquipped)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("E");
            Console.ResetColor();
            Console.Write("]");
            Console.Write(ConsoleUtility.PadRightForMixedText(Name, 9));
        }
        else Console.Write(ConsoleUtility.PadRightForMixedText(Name, 12));

        Console.Write(" | ");

        if (Atk != 0) Console.Write($"공격력 {(Atk >= 0 ? "+" : "")}{Atk} ");
        if (Def != 0) Console.Write($"방어력 {(Atk >= 0 ? "+" : "")}{Def} ");
        if (HP != 0) Console.Write($"체  력 {(Atk >= 0 ? "+" : "")}{HP} ");

        Console.Write(" | ");

        Console.WriteLine(Desc);

    }


    public void PrintStoreItemDescription(bool withNumber = false, int idx = 0)
    {
        Console.Write("- ");
        
        if (withNumber)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("{0} ", idx);
            Console.ResetColor();
        }
        else Console.Write(ConsoleUtility.PadRightForMixedText(Name, 12));

        Console.Write(" | ");

        if (Atk != 0) Console.Write($"공격력 {(Atk >= 0 ? "+" : "")}{Atk} ");
        if (Def != 0) Console.Write($"방어력 {(Def >= 0 ? "+" : "")}{Def} ");
        if (HP != 0) Console.Write($"체  력 {(HP >= 0 ? "+" : "")}{HP}");

        Console.Write(" | ");

        Console.Write(ConsoleUtility.PadRightForMixedText(Desc, 12));

        Console.Write(" | ");

        if (IsPurchased)
        {
            Console.WriteLine("구매완료");
        }
        else
        {
            ConsoleUtility.PrintTextHighlights("", Price.ToString(), " G");
        }
    }

    internal void ToggleEquipStatus()
    {
        IsEquipped = !IsEquipped;
    }

    internal void Purchase()
    {
        IsPurchased = true;
    }
}