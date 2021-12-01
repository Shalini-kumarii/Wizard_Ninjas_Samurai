using System;

namespace Wizard
{
public class Ninja:Wizards
{
    // public string Name;
    // public int Strength;
    // public int Intelligence;
    // public int Dexterity;
    // private int health;
    //  
    // public int Health
    // {
    //     get { return health; }
    // }
     
    public Ninja(string name,int str,int intell,int hth)
    {
        Name = name;
        Strength = str;
        Intelligence =intell;
        Dexterity = 175;
        health = hth;
    }

    public override int Attack()
    {
        int dmg = Dexterity * 5;
        health -= dmg;
        Console.WriteLine($"{Name} did {dmg} damage!");
        Random rnd = new Random();
        int result = rnd.Next(1,100);
        Console.WriteLine("result is:"+result);
        // this has %20 chance of happening
        if(result<=20)
        {
    // if you need to get a number up to 10 use mod
        health -=10;
}   
Console.WriteLine($"After {Name} did {dmg} damage!");
        return health;
    }

    public void Steal(Human target)
    {
        target.Health -=5;
        this.health +=5;
        Console.WriteLine($"{Name} health increased by 5 now its :"+ health);
        Console.WriteLine($"{target.Name} decreased by 5 now its :"+ target.Health);
    }
}
}