using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condidionals_HUD_V1._2
{
    internal class Program
    {
        static float maxHealth = 100f;
        static float health;
        static float maxShield = 50;
        static float shield;
        static int maxLives = 2;
        static int lives;
        static int score;
        static int CurrentScore;
        static bool isDead = false;
        static ConsoleColor Originalcolor;
        static ConsoleColor TextColor = ConsoleColor.DarkMagenta;
        static ConsoleColor HUDColor = ConsoleColor.DarkGreen;
        static ConsoleColor DamageColor = ConsoleColor.DarkRed;
        static ConsoleColor HealingColor = ConsoleColor.DarkBlue;
        static ConsoleColor WeaponSwitchColor = ConsoleColor.DarkYellow;
        static int Pistol = 0;
        static int Rifle = 1;
        static int Shotgun = 2;
        static int Sniper = 3;
        static int Nailgun = 4;
        static void Main(string[] args)
        {
            
            health = maxHealth;
            CurrentScore = score;   
          //  shield = MaxShield;
            lives = maxLives;

            Console.ForegroundColor = TextColor;
            ShowHUD();
            Console.ReadKey(true);
            Console.Clear();
            TakeDamage(200);
            Console.ReadKey(true);
            Console.Clear();
            ShowHUD();
            Console.ReadKey(true);
            Console.Clear();
            Revive();
            Console.ReadKey(true);
            Console.Clear();
            ShowHUD();
            Console.ReadKey(true);
            Console.Clear();
            Heal(100);
            Console.ReadKey(true);
            Console.Clear();
            ShowHUD();
            Console.ReadKey(true);
            Console.Clear();
            Console.ForegroundColor = Originalcolor;
        }
        static void ShowHUD()
        {
            Console.ForegroundColor = HUDColor;
            Console.WriteLine("========================");
            Console.WriteLine("Health - " + health);
            //Console.WriteLine("Shield - " + CurrentShield);
            Console.WriteLine("Lives - " + lives);
            Console.WriteLine("Score - " + CurrentScore);
            Console.WriteLine("========================");
            Console.ForegroundColor = TextColor;          
        }
        static void HealthStatus()
        {
            if (health == 100)
            {
                Console.WriteLine("Is Healthy" + health);
            }
            if (health > 75)
            {
                Console.WriteLine("Healthy" + health);
            }
            if (health > 50)
            {
                Console.WriteLine("Fine" + health);
            }
            if (health == 25)
            {
                Console.WriteLine("Not Fine" + health);
            }
            if (health < 0)
            {
                Console.WriteLine("Is Dead" + health);
                isDead = true;
            }
        }
        static void TakeDamage(float Damage)
        {
            health -= Damage;
            //if (CurrentShield > 0)
            //{
            //    CurrentShield -= Damage;
            //}
            //else if (Shield == 0 & Damage > 0)
            //{
            //    CurrentShield = 0;
            //    CurrentHealth -= Damage;
            //}
            if (health < 0)
            {
                health = 0;
                Console.Write("NOOOOoooohohho, HE'S ALREADY DEAD :(");
            }
            else if (health > 100)
            {
                health = 100;
            }

            Console.ForegroundColor = DamageColor;
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("You Took Damage!" + Damage);
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.ForegroundColor = TextColor;
        }
        static void Heal(float Healing)
        {
            health += Healing;
            Console.ForegroundColor = HealingColor;
            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine("You Healed + " + Healing);
            Console.WriteLine("++++++++++++++++++++++++");
            Console.ForegroundColor = TextColor;        
            
            if (health > 100)
            {
                health = 100;
                Console.WriteLine("You are Healthy");
            }
            else if (health < 0)
            {
                health = 0;
                Console.WriteLine("You are Dead!");
            }
        }
        static void Revive()
        {
            if (lives > 0)
            {
                lives--;
                health = 50f;
                Console.WriteLine("Revived");
            }
            else if (lives <= 0)
            {
                Console.WriteLine("No More Lives!");
            }
        }
        static void SwitchWeapon()
        {
            Console.ForegroundColor = WeaponSwitchColor;
            Console.WriteLine("Weapon Switched!"  );
            Console.ForegroundColor = TextColor;
        }
    }
}
