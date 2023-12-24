using System;

namespace Tutor
{
    class Hero
    {
        public string name;
        public string role;
        public int hp;
        public int attack;
        public int xp;

        public Hero(string _name, string _role)
        {
            name = _name;
            role = _role;
            if (role == "marksman")
            {
                hp = 150;
                attack = 300;
            }
            else if (role == "fighter")
            {
                hp = 400;
                attack = 200;
            }
            else
            {
                hp = 250;
                attack = 250;
            }
            xp = 0;
        }

        public void Skill1(Hero hero)
        {
            hero.hp -= 100;
            Console.WriteLine(name + " attacks " + hero.name + " with his first skill. Now " + hero.name + " hp is " + hero.hp);
        }

        public void Skill2(Hero hero)
        {
            hero.hp -= 150;
            Console.WriteLine(name + " attacks " + hero.name + " with his second skill. Now " + hero.name + " hp is " + hero.hp);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hero layla = new Hero("Layla", "marksman");
            Hero alucard = new Hero("Alucard", "fighter");

            Console.WriteLine("WELCOME TO BATTLE ARENA!");
            layla.Skill1(alucard);
            layla.Skill2(alucard);
            alucard.Skill1(layla);
        }
    }
}