using System;

namespace Wizard
{
public class Samurai: Wizards
{
//     public string Name;
//     public int Strength;
//     public int Intelligence;
//     public int Dexterity;
//     private int health;
//      
//     public int Health
//     {
//         get { return health; }
//     }
//      
    public Samurai(string name,int str,int intell,int dex)
    {
        Name = name;
        Strength = str;
        Intelligence =intell;
        Dexterity = dex;
        health = 200;
    }

    public override int Attack()
    {
        base.Attack();
        int dmg = Dexterity * 5;
        health -= dmg;
        if(health < 50)
        {
        health =0;
        }
        //Console.WriteLine($"{Name} attacked {dmg} damage!");
        return health;
    }

    public void Meditade()
    {
        health=200;
        Console.WriteLine($"After Meditation healed full health"+health);
    }
}
}
