using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condidionals_HUD_V1._2
{
    internal class Program
    {
        static float Health = 100f;
        static float CurrentHealth;
        static float Shield = 50;
        static float CurrentShield;
        static int Lives = 2;
        static int CurrentLives;
        static int Score;
        static int CurrentScore;
        static bool IsDead = false;
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
            
            CurrentHealth = Health;
            CurrentScore = Score;   
            CurrentShield = Shield;
            CurrentLives = Lives;

            Console.ForegroundColor = TextColor;
            ShowHUD();
            Console.ReadKey(true);
            Console.Clear();
            TakeDamage(60);
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
            Console.WriteLine("Health - " + CurrentHealth);
            Console.WriteLine("Shield - " + CurrentShield);
            Console.WriteLine("Lives - " + CurrentLives);
            Console.WriteLine("Score - " + CurrentScore);
            Console.WriteLine("========================");
            Console.ForegroundColor = TextColor;          
        }
        static void HealthStatus()
        {
            if (CurrentHealth == 100)
            {
                Console.WriteLine("Is Healthy");
            }
            if (CurrentHealth > 75)
            {
                Console.WriteLine("Healthy");
            }
            if (CurrentHealth > 50)
            {
                Console.WriteLine("Fine");
            }
            if (CurrentHealth == 25)
            {
                Console.WriteLine("Not Fine");
            }
            if (CurrentHealth < 0)
            {
                Console.WriteLine("Is Dead");
                IsDead = true;
            }
        }
        static void TakeDamage(float Damage)
        {
            if (CurrentShield > 0)
            {
                CurrentShield -= Damage;
            }
            else if (Shield == 0 & Damage > 0)
            {
                CurrentShield = 0;
                CurrentHealth -= Damage;
            }
            Console.ForegroundColor = DamageColor;
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("You Took Damage!" + Damage);
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.ForegroundColor = TextColor;
        }
        static void Heal(float Healing)
        {
            Console.ForegroundColor = HealingColor;
            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine("You Healed + " + Healing);
            Console.WriteLine("++++++++++++++++++++++++");
            Console.ForegroundColor = TextColor;            
            if (CurrentHealth == 100)
            {
                CurrentHealth = 100;
                Console.WriteLine("You are Healthy");
            }
        }
        static void Revive()
        {
            if (Lives > 0)
            {
                Lives--;
                CurrentHealth = 100f;
                Console.WriteLine("Revived");
            }
            else if (Lives <= 0)
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
