using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] valid1 = new string[2] { "a", "b" };
            string[] valid2 = new string[3] { "a", "b", "c" };
            try
            {
                while (true)
                {
                    Console.WriteLine("For damage, do you prefer \n(a)Martial \n(b)Spell Casting \n(c)Mix of both? ");
                    while (!validResponse((input = Console.ReadLine()), valid2))
                    {
                        Console.WriteLine("Invalid response, input a, b, or c: ");
                    }
                    if (input == "a")//martial
                    {
                        Console.WriteLine("For weapons, do you prefer \n(a)Ranged \n(b)Melee? ");
                        while (!validResponse((input = Console.ReadLine()), valid1))
                        {
                            Console.WriteLine("Invalid response, input a or b: ");
                        }
                        if (input == "a") //ranged
                        {
                            Console.WriteLine("For ranged, do you prefer \n(a)Bows/Crossbows \n(b)Thrown Weapons \n(c)Guns? ");
                            while (!validResponse((input = Console.ReadLine()), valid2))
                            {
                                Console.WriteLine("Invalid response, input a, b, or c: ");
                            }
                            if (input == "a")//bows/crossbows
                            {
                                FighterRouge();
                            }
                            else if (input == "b")//thrown weapons
                            {
                                StrengthDexterity();
                            }
                            else
                            {
                                Console.WriteLine("You are a Gunslinger.");
                            }
                        }
                        else if (input == "b") //melee
                        {
                            Console.WriteLine("Are you edgy? \n(a)Yes \n(b)No");
                            while (!validResponse((input = Console.ReadLine()), valid1))
                            {
                                Console.WriteLine("Invalid response, input a or b: ");
                            }
                            if (input == "a") //Edgy
                            {
                                Console.WriteLine("You are a Blood Hunter.");
                            }
                            else //Not Edgy
                            {
                                Console.WriteLine("Do you want to dual wield? \n(a)Yes \n(b)No");
                                while (!validResponse((input = Console.ReadLine()), valid1))
                                {
                                    Console.WriteLine("Invalid response, input a or b: ");
                                }
                                if (input == "a") //Dual wield
                                {
                                    StrengthDexterity();
                                }
                                else //Not dualwield
                                {
                                    FighterBarbarian();
                                }
                            }
                        }
                    }
                    else if (input == "b")//spellcasting
                    {
                        Console.WriteLine("Where does your magic come from \n(a)Arcane power\n(b)Divine power");
                        while (!validResponse((input = Console.ReadLine()), valid1))
                        {
                            Console.WriteLine("Invalid response, input a or b: ");
                        }
                        if (input == "a") //Arcane spellcasting
                        {
                            Console.WriteLine("Where does your magic come from? \n(a)Pact Magic\n(b)Prepared Spells \n(c)Spontaneous spells");
                            while (!validResponse((input = Console.ReadLine()), valid2))
                            {
                                Console.WriteLine("Invalid response, input a, b, or c: ");
                            }
                            if (input == "a") //pact
                            {
                                Console.WriteLine("You are a Warlock.");
                            }
                            else if (input == "b") // prepared
                            {
                                Console.WriteLine("You are a Wizard.");
                            }
                            else //spontaneous
                            {
                                Console.WriteLine("Do you want to be \n(a)Support\n(b)a Glass Cannon");
                                while (!validResponse((input = Console.ReadLine()), valid1))
                                {
                                    Console.WriteLine("Invalid response, input a or b: ");
                                }
                                if (input == "a") //support
                                {
                                    Console.WriteLine("You are a Bard.");
                                }
                                else //glass cannon
                                {
                                    Console.WriteLine("You are a Sorcerer.");
                                }
                            }
                        }
                        else //Divine Spellcasting
                        {
                            Console.WriteLine("Where does your magic come from \n(a)Nature\n(b)Gods");
                            while (!validResponse((input = Console.ReadLine()), valid1))
                            {
                                Console.WriteLine("Invalid response, input a or b: ");
                            }
                            if (input == "a") //Nature
                            {
                                Console.WriteLine("You are a Druid.");
                            }
                            else //Gods
                            {
                                Console.WriteLine("You are a Cleric.");
                            }
                        }
                    }
                    else//mixed
                    {
                        Console.WriteLine("Where does your magic come from \n(a)Arcane power\n(b)Divine power");
                        while (!validResponse((input = Console.ReadLine()), valid1))
                        {
                            Console.WriteLine("Invalid response, input a or b: ");
                        }
                        if (input == "a") //Arcane Mixed
                        {
                            Console.WriteLine("What are you interested in?\n(a)Science \n(b)Spell Sword \n(c)Infiltrator Mage");
                            while (!validResponse((input = Console.ReadLine()), valid2))
                            {
                                Console.WriteLine("Invalid response, input a, b, or c: ");
                            }
                            if (input == "a") //Science
                            {
                                Console.WriteLine("You are a Artificer.");
                            }
                            else if (input == "b")//Spell Sword
                            {
                                Console.WriteLine("You are a Eldrich Knight.");
                            }
                            else //Infultrator Mage
                            {
                                Console.WriteLine("You are a Rouge.");
                            }
                        }
                        else //Divine Mixed
                        {
                            Console.WriteLine("Where does your magic come from \n(a)Nature\n(b)Gods");
                            while (!validResponse((input = Console.ReadLine()), valid1))
                            {
                                Console.WriteLine("Invalid response, input a or b: ");
                            }
                            if (input == "a") //Nature
                            {
                                Console.WriteLine("You are a Ranger.");
                            }
                            else //Gods
                            {
                                Console.WriteLine("You are a Paladin.");
                            }
                        }
                    }
                    Console.WriteLine("============\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You barbarian, you broke the code! \n" + e);
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }

        static bool validResponse(string response, string[] valid)
        {
            for(int i = 0; i < valid.Length; i++)
            {
                if (response == valid[i])
                    return true;
            }
            return false;
        }

        static void FighterBarbarian()
        {
            string input;
            string[] valid = new string[2] { "a", "b" };
            Console.WriteLine("Do you prefer \n(a)Versitility \n(b)A tank with high damage output? ");
            while (!validResponse((input = Console.ReadLine()), valid))
            {
                    Console.WriteLine("Invalid response, input a or b,: ");
            }
            if (input == "a")
                Console.WriteLine("You are a Fighter.");
            else
                Console.WriteLine("You are a Barbarian.");
        }

        static void FighterRouge()
        {
            string input;
            string[] valid = new string[2] { "a", "b" };
            Console.WriteLine("Do you prefer \n(a)Multi-attack \n(b)Precision Weapon Tossing? ");
            while (!validResponse((input = Console.ReadLine()), valid))
            {
                Console.WriteLine("Invalid response, input a or b: ");
            }
            if (input == "a")
                Console.WriteLine("You are a Fighter.");
            else
                Console.WriteLine("You are a Rouge.");
        }

        static void StrengthDexterity()
        {
            string input;
            string[] valid = new string[2] { "a", "b" };
            Console.WriteLine("What characteristic do you like more? \n(a)Strength \n(b)Dexterity? ");
            while (!validResponse((input = Console.ReadLine()), valid))
            {
                Console.WriteLine("Invalid response, input a or b: ");
            }
            if (input == "a") //strength
            {
                FighterBarbarian();
            }
            else //dexterity
            {
                FighterRouge();
            }
        }
    }
}
