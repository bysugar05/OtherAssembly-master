﻿using EnsoulSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Mid
{
    class Update
    {
        public static void Check()
        {
            try
            {
                using (var wb = new WebClient())
                {
                    var raw = wb.DownloadString("https://raw.githubusercontent.com/011110001/EnsoulSharp/master/Easy_Mid/Version.txt");

                    System.Version Version = Assembly.GetExecutingAssembly().GetName().Version;

                    if (raw != Version.ToString())
                    {
                        Game.Print("<font color=\"#ff0000\">Easy_Mid is outdated! Please update to {0}!</font>", raw);
                    }
                    else
                        Game.Print("<font color=\"#ff0000\">Easy_Mid is updated! Version : {0}!</font>", Version.ToString());
                }

            }
            catch
            {
                Game.Print("<font color=\"#ff0000\">Failed to verify script version!</font>");
            }
        }
    }
}
