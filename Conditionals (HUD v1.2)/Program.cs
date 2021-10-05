using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals__HUD_v1._2_
{
    class Program
    {
        static int weapon = 0;
        static int health = 100;
        static string healthStatus;
        static int damage;
        static int hp;
        static int weaponPickUp;

        static void Main(string[] args)
        {
            ShowHUD();
            damage = 100;
            TakeDamage(damage);
            //hp = 200;
            //Heal(hp);
            weaponPickUp = 1;
            ShowHUD();


            weaponPickUp = 1;
            

            Console.ReadKey(true);
        }
        static void ShowHUD()

        {
            // Console.WriteLine("Weapon: " + weapon);
            // Console.WriteLine("Health: " + health);


            if (health == 100)
            {
                healthStatus = "Perfect Health";
            }
            else if (health >= 75)
            {
                healthStatus = "Healthy";
            }
            else if (health >= 50)
            {
                healthStatus = "Hurt";
            }
            else if (health >= 50)
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


            Console.WriteLine("Health: " + health + " Health Status: " + healthStatus);
            ChangeWeapon(weaponPickUp);
        }
        static void ChangeWeapon(int weaponPickUp)
        {
            if (weapon >= 6)
            {
                weapon = 5;
            }
            if (weapon < 0)
            {
                weapon = 0;
            }

            weapon = weapon + weaponPickUp;

            if (weapon == 0)
            {
                Console.WriteLine("Weapon: Pistol");
            }
            else if (weapon == 1)
            {
                Console.WriteLine("Weapon: Shotgun");
            }
            else if (weapon == 2)
            {
                Console.WriteLine("Weapon: Spreader");
            }
            else if (weapon == 3)
            {
                Console.WriteLine("Weapon: Laser");
            }
            else if (weapon == 4)
            {
                Console.WriteLine("Weapon: Sniper");
            }
            else if (weapon == 5)
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
