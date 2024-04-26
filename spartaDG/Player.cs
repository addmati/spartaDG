internal class Player
{
    public string Name { get; }
    public string Job { get; }
    public int Level { get; }
    public int Atk { get; }
    public int Def { get; }
    public int HP { get; }
    public int Gold { get; set; }

    public Player(string name, string job, int level, int atk, int def, int HP, int gold)
    {
        Name = name;
        Job = job;
        Level = level;
        Atk = atk;
        Def = def;
        HP = HP;
        Gold = gold;
    }
}

