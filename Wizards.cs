using System;

namespace Wizard
{
public class Wizards
{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    protected int health;
     
    public int Health
    {
        get { return health; }
        set { health = value; }
    }
    
    public Wizards() {}
    public Wizards(string name,int str,int dex)
    {
        Name = name;
        Strength = str;
        Intelligence =25;
        Dexterity = dex;
        health = 50;
    }

    public Wizards(string name,int str,int intell, int dex)
    {
        Name = name;
        Strength = str;
        Intelligence =25;
        Dexterity = dex;
        health = 50;
    }

    public virtual int Attack()
    {
        int dmg = Intelligence * 5;
        health += dmg;
        Intelligence -=dmg;
        //Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return health;
    }

    public int  Heal( Human target)
    {
        int dmg = Intelligence * 10;
        target.Health += dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }
     
}
}