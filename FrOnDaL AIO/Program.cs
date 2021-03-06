﻿using System;
using EnsoulSharp;
using EnsoulSharp.SDK;
using FrOnDaL_AIO.Champions;

namespace FrOnDaL_AIO
{
    internal class Program
    {
        // ReSharper disable once UnusedParameter.Local
        private static void Main(string[] args)
        {
            GameEvent.OnGameLoad += OnLoadingComplete;
        }
        private static void OnLoadingComplete()
        {
            try
            {
                switch (GameObjects.Player.CharacterName)
                {
                    case "Ashe":
                        Ashe.GameOn();
                        Game.Print("FrOnDaL AIO " + ObjectManager.Player.CharacterName + " Loaded <font color='#1dff00'>by FrOnDaL</font>");
                        Console.WriteLine("FrOnDaL AIO " + ObjectManager.Player.CharacterName + " loaded");
                        break;
                    case "Katarina":
                        Katarina.GameOn();
                        Game.Print("FrOnDaL AIO " + ObjectManager.Player.CharacterName + " Loaded <font color='#1dff00'>by FrOnDaL</font>");
                        Console.WriteLine("FrOnDaL AIO " + ObjectManager.Player.CharacterName + " loaded");
                        break;
                    case "Orianna":
                        Orianna.GameOn();
                        Game.Print("FrOnDaL AIO " + ObjectManager.Player.CharacterName + " Loaded <font color='#1dff00'>by FrOnDaL</font>");
                        Console.WriteLine("FrOnDaL AIO " + ObjectManager.Player.CharacterName + " loaded");
                        break;
                    default:
                        Game.Print("<font color='#b756c5' size='25'>FrOnDaL AIO Does Not Support " + ObjectManager.Player.CharacterName + " - By FrOnDaL</font>");
                        Console.WriteLine("FrOnDaL AIO Does Not Support " + ObjectManager.Player.CharacterName + " - By FrOnDaL");
                        break;
                }
            }
            catch (Exception)
            {
                Game.Print("Error in loading - By FrOnDaL");
                Console.WriteLine("Error in loading - By FrOnDaL");
            }
        }
    }
}
