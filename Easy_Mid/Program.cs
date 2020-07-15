﻿using Easy_Mid.Champions;
using EnsoulSharp;
using EnsoulSharp.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Mid
{
    class Program
    {
        static void Main(string[] args)
        {
            GameEvent.OnGameLoad += On_LoadGame;
        }
        private static void On_LoadGame()
        {
            //try { Update.Check(); }
            //catch { }
            if (ObjectManager.Player.CharacterName == "Brand")
            {
                Brand.OnLoad();
            }
            if (ObjectManager.Player.CharacterName == "Diana")
            {
                Diana.OnLoad();
                Game.Print("This script is a Port of ElDiana (Code of jQuery)");
            }
        }
    }
}
