using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals__HUD_v1._2_
{
    class Program
    {
        static string weapon;
        static int health = 100;
        static string healthStatus;
        static int damage;
        static int hp;
        static int weaponPickUp;


        static void Main(string[] args)
        {
            
            ShowHUD();

            Console.ReadKey(true);

            damage = 10;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Player has taken " + damage + " damage.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            TakeDamage(damage);

            ShowHUD();

            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.Blue;
            weaponPickUp = weaponPickUp + 1;
            Console.WriteLine("Player picked up a new weapon!");//+weapon
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            

            ShowHUD();

            Console.ReadKey(true);

            damage = 30;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Player has taken " + damage + " damage.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            TakeDamage(damage);

            ShowHUD();

            Console.ReadKey(true);

            
            Console.ForegroundColor = ConsoleColor.Green;
            hp = 100;
            Console.WriteLine("The Player used a Max Potion and healed " + hp + " Health Points.");
            Heal(hp);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            
            ShowHUD();


            Console.ReadKey(true);

            damage = 40;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Player has taken " + damage + " damage.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            TakeDamage(damage);

            ShowHUD();

            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Player picked up a new weapon!");//+weapon
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            weaponPickUp = weaponPickUp + 1;

            ShowHUD();

            Console.ReadKey(true);

            damage = 20;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Player has taken " + damage + " damage.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            TakeDamage(damage);

            ShowHUD();

            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Player picked up a new weapon!");//+weapon
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            weaponPickUp = weaponPickUp + 1;

            ShowHUD();

            Console.ReadKey(true);

            damage = 30;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Player has taken " + damage + " damage.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            TakeDamage(damage);

            ShowHUD();

            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Player picked up a new weapon!");//+weapon
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            weaponPickUp = weaponPickUp + 1;

            ShowHUD();

            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.Green;
            hp = 20;
            Console.WriteLine("The Player used a Medical Herb and healed " + hp + " Health Points.");
            Heal(hp);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            ShowHUD();


            Console.ReadKey(true);

            damage = 25;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Player has taken " + damage + " damage.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            TakeDamage(damage);

            ShowHUD();

            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Player picked up a new weapon!");//+weapon
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            weaponPickUp = weaponPickUp + 1;

            ShowHUD();

            Console.ReadKey(true);

            damage = 40;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Player has taken " + damage + " damage.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            TakeDamage(damage);

            ShowHUD();

            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("The Game Is Over");

            Console.ReadKey(true);

        }

        static void ShowHUD()

        {
            Console.WriteLine("///////////////////////////////////////////");


            if (health == 100)
            {
                healthStatus = "Perfect Health";
            }
            else if (health >= 75)
            {
                healthStatus = "Healthy";
            }
            else if (health > 50)
            {
                healthStatus = "Hurt";
            }
            else if (health >= 11)
            {
                healthStatus = "Badly Hurt";
            }
            else if (health == 0)
            {
                healthStatus = "Dead";
               
            }
            else if (health <= 10)
            {
                healthStatus = "Imminent Danger";
            }


            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Health Status: " + healthStatus);
            
            
            
            ChangeWeapon(weaponPickUp);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine();
        }
        static void ChangeWeapon(int weaponPickUp)
        {
            if (weaponPickUp >= 6)
            {
                weaponPickUp = 5;
            }
            if (weaponPickUp < 0)
            {
                weaponPickUp = 0;
            }

            

            if (weaponPickUp == 0)
            {
                Console.WriteLine("Weapon: Pistol");
            }
            else if (weaponPickUp == 1)
            {
                Console.WriteLine("Weapon: Shotgun");
            }
            else if (weaponPickUp == 2)
            {
                Console.WriteLine("Weapon: Spreader");
            }
            else if (weaponPickUp == 3)
            {
                Console.WriteLine("Weapon: Laser");
            }
            else if (weaponPickUp == 4)
            {
                Console.WriteLine("Weapon: Sniper");
            }
            else if (weaponPickUp == 5)
            {
                Console.WriteLine("Weapon: BFG");
            }
        }
        static void TakeDamage(int damage)
        {
            health = health - damage;
            if (health < 0)
            {
                health = 0;
            }
        }
        static void Heal(int hp)
        {
            health = health + hp;
            if (health > 100)
                health = 100;
        }
    }
}
