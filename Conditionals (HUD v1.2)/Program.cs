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
        static void Main(string[] args)
        {
            ShowHUD();
            Console.ReadKey(true);
        }
        static void ShowHUD()
        {
            Console.WriteLine("Weapon: " + weapon);
            Console.WriteLine("Health: " + health);
        }
        static void ChangeWeapon(int weaponPickUp)
        {

        }
        static void TakeDamage(int damage)
        {
            health = health - damage;
        }
        static void Heal(int hp)
        {
            health = health + hp;
        }
    }
}
