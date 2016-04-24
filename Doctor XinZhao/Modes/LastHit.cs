using System;
using System.Linq;
using EloBuddy;
using EloBuddy.SDK;
using SettingsMana = XinZhao.Config.ManaManagerMenu;

namespace XinZhao.Modes
{
    public sealed class LastHit : ModeBase
    {

        public override bool ShouldBeExecuted()
        {
            return false;
            //return Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.LastHit);
        }

        public override void Execute()
        {
           
        }
    }
}
