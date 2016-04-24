using System;
using System.Drawing;
using EloBuddy;
using EloBuddy.SDK.Events;

namespace XinZhao
{
    public static class Program
    {
        public const string ChampName = "XinZhao";

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
            Chat.Print("Dr{0} Loaded. Good Luck!", Color.LightBlue, ChampName);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Dr{0} Loaded. Good Luck!", ChampName);
            Console.ResetColor();
        }
    }
}
