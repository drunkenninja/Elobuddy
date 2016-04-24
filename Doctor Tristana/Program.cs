using System;
using System.Drawing;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;

namespace Tristana
{
    public static class Program
    {
        public const string ChampName = "Tristana";

        public static void Main(string[] args)
        {
            Loading.OnLoadingComplete += OnLoadingComplete;
        }

        private static void OnLoadingComplete(EventArgs args)
        {
            if (Player.Instance.ChampionName != ChampName)
            {
                return;
            }
            Config.Initialize();
            SpellManager.Initialize();
            ModeManager.Initialize();
            Events.Initialize();
            WelcomeMsg();
        }

        private static void WelcomeMsg()
        {
            Chat.Print("Doctor{0} Loaded. Good Luck!", Color.LightGoldenrodYellow, ChampName);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Doctor{0} Loaded. Good Luck!", ChampName);
            Console.ResetColor();
        }
    }
}
