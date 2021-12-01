using System;

namespace Wizard
{
    class Program
    {
        static void Main(string[] args)
        {
        Human humanname1 = new Human("Kumari");

            Human humanname = new Human("shalini",3,3,3,100);
        Console.WriteLine($"The name is{humanname1.Name}  {humanname1.Strength} {humanname1.Intelligence}{humanname1.Dexterity} {humanname1.Health}");
        Console.WriteLine(humanname.Name);
        Console.WriteLine(humanname.Strength);
        Console.WriteLine(humanname.Intelligence);
        Console.WriteLine(humanname.Dexterity);
        Console.WriteLine(humanname.Health);
        Human h = new Human("kumari");
        h.Attack(humanname);
        Console.WriteLine("After attack health"+humanname.Health);

        Wizards wizard = new Wizards("Wizard",1,1);
        Console.WriteLine($"The name is : {wizard.Name} strength {wizard.Strength} intelligence {wizard.Intelligence} Dexterity {wizard.Dexterity} Health {wizard.Health}");
        wizard.Attack();
        Console.WriteLine("After attack health is: "+wizard.Health);
        Console.WriteLine("After attack Intelligence is :"+wizard.Intelligence);
        wizard.Heal(humanname);
        Console.WriteLine("After Heal health is: "+humanname.Health);


        Ninja ninja = new Ninja("Ninja",1,1,10);
        Console.WriteLine($"The name is : {ninja.Name} strength {ninja.Strength} intelligence {ninja.Intelligence} Dexterity {ninja.Dexterity} Health {ninja.Health}");
        ninja.Steal(humanname);
        ninja.Attack();

        Samurai samurai = new Samurai("Samurai",1,1,10);
        samurai.Attack();
        Console.WriteLine($"The name is : {samurai.Name} strength {samurai.Strength} intelligence {samurai.Intelligence} Dexterity {samurai.Dexterity} Health {samurai.Health}");
        samurai.Meditade();

        }
    }
}
