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
        static void Main(string[] args)
        {
            ShowHUD();
            damage =10;
            TakeDamage(damage);
            //hp = 200;
            //Heal(hp);
            ShowHUD();
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
            else if (health >= 100)
            {
                healthStatus = "Healthy";
            }
            else if (health >= 75)
            {
                healthStatus = "Hurt";
            } 
            else if (health >= 50)
            {
                healthStatus = "Badly Hurt";
            }
            else if (health >=10)
            {
                healthStatus = "Imminent Danger";
            }
            else
            {
                healthStatus = "Dead";
            }
            Console.WriteLine("Health: " + health + " Health Status: " + healthStatus);
        }
        static void ChangeWeapon(int weaponPickUp)
        {
            weapon = weaponPickUp;

            if (weapon == 0)
            {
                
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
