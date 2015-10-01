using System;
using EloBuddy;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Rendering;
using SharpDX;

namespace Trinket_Cooldown_Tracker
{
    public static class Program
    {
        private static Menu Config;

        public static Items.Item Warding_Totem = new Items.Item(3340, 600f);

        public static Items.Item Greater_Stealth_Totem = new Items.Item(3361, 600f);

        public static Items.Item Greater_Vision_Totem = new Items.Item(3362, 600f);

        public static Items.Item Sweeping_Lens = new Items.Item(3341, 600f);

        public static Items.Item Oracles_Lens = new Items.Item(3364, 600f);

        public static Items.Item Scrying_Orb = new Items.Item(3342, 600f);

        public static Items.Item Farsight_Orb = new Items.Item(3363, 600f);

        public static Obj_AI_Hero Player
        {
            get
            {
                return ObjectManager.Player;
            }
        }
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += OnGameLoad;
            Drawing.OnDraw += OnDraw;
        }

        private static void OnGameLoad(EventArgs args)
        {
            Game.PrintChat("Trinket Tracker by DanZ and Drunkenninja loaded");
            Config = new Menu("Trinket Tracker", "Trinket_Tracker", true);
            Config.AddSubMenu(new Menu("On", "On"));
            Config.SubMenu("On").AddItem(new MenuItem("On", "On")).SetValue(true);

            Config.AddToMainMenu();
            Game.OnUpdate += OnGameUpdate;
        }

        private static void OnDraw(EventArgs args)
        {
        }

        private static void OnGameUpdate(EventArgs args)
        {

            if (Config.Item("On").GetValue<bool>())
            {
                if (Warding_Totem.IsOwned())
                {
                    if (Warding_Totem.IsReady())
                    {

                        Drawing.DrawText(Player.HPBarPosition.X + 30, Player.HPBarPosition.Y - 30, Color.LawnGreen, "Trinket Up!");
                    }
                    else
                    {
                        Drawing.DrawText(Player.HPBarPosition.X + 30, Player.HPBarPosition.Y - 30, Color.Red, "Trinket Down!");
                    }
                }
            }
            {
                if (Greater_Stealth_Totem.IsOwned())
                {
                    if (Greater_Stealth_Totem.IsReady())
                    {

                        Drawing.DrawText(Player.HPBarPosition.X + 30, Player.HPBarPosition.Y - 30, Color.LawnGreen, "Trinket Up!");
                    }
                    else
                    {
                        Drawing.DrawText(Player.HPBarPosition.X + 30, Player.HPBarPosition.Y - 30, Color.Red, "Trinket Down!");
                    }
                }
            }
            {
                if (Greater_Vision_Totem.IsOwned())
                {
                    if (Greater_Vision_Totem.IsReady())
                    {

                        Drawing.DrawText(Player.HPBarPosition.X + 30, Player.HPBarPosition.Y - 30, Color.LawnGreen, "Trinket Up!");
                    }
                    else
                    {
                        Drawing.DrawText(Player.HPBarPosition.X + 30, Player.HPBarPosition.Y - 30, Color.Red, "Trinket Down!");
                    }
                }
            }
            {
                if (Sweeping_Lens.IsOwned())
                {
                    if (Sweeping_Lens.IsReady())
                    {

                        Drawing.DrawText(Player.HPBarPosition.X + 30, Player.HPBarPosition.Y - 30, Color.LawnGreen, "Trinket Up!");
                    }
                    else
                    {
                        Drawing.DrawText(Player.HPBarPosition.X + 30, Player.HPBarPosition.Y - 30, Color.Red, "Trinket Down!");
                    }
                }
            }
            {
                if (Oracles_Lens.IsOwned())
                {
                    if (Oracles_Lens.IsReady())
                    {

                        Drawing.DrawText(Player.HPBarPosition.X + 30, Player.HPBarPosition.Y - 30, Color.LawnGreen, "Trinket Up!");
                    }
                    else
                    {
                        Drawing.DrawText(Player.HPBarPosition.X + 30, Player.HPBarPosition.Y - 30, Color.Red, "Trinket Down!");
                    }
                }
            }
            {
                if (Scrying_Orb.IsOwned())
                {
                    if (Scrying_Orb.IsReady())
                    {

                        Drawing.DrawText(Player.HPBarPosition.X + 30, Player.HPBarPosition.Y - 30, Color.LawnGreen, "Trinket Up!");
                    }
                    else
                    {
                        Drawing.DrawText(Player.HPBarPosition.X + 30, Player.HPBarPosition.Y - 30, Color.Red, "Trinket Down!");
                    }
                }
            }
            {
                if (Farsight_Orb.IsOwned())
                {
                    if (Farsight_Orb.IsReady())
                    {

                        Drawing.DrawText(Player.HPBarPosition.X + 30, Player.HPBarPosition.Y - 30, Color.LawnGreen, "Trinket Up!");
                    }
                    else
                    {
                        Drawing.DrawText(Player.HPBarPosition.X + 30, Player.HPBarPosition.Y - 30, Color.Red, "Trinket Down!");
                    }
                }
            }
        }
    }
}