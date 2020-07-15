using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EnsoulSharp;
using EnsoulSharp.SDK;
using EnsoulSharp.SDK.MenuUI.Values;

namespace OlympusAIO.Helpers
{
    class ManaManager
    {
        public static bool HaveNoEnoughMana(MenuSlider menu)
        {
            if (OlympusAIO.MainMenu["DisableManaManagerIfBlueBuff"].GetValue<MenuBool>().Enabled && OlympusAIO.objPlayer.HasBuff("crestoftheancientgolem"))
            {
                return false;
            }

            return OlympusAIO.objPlayer.ManaPercent < menu.GetValue<MenuSlider>().Value;
        }
    }
}
