﻿using BepInEx;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using CheepsAmongUsApi.API;
using CheepsAmongUsApi.API.Enumerations;
using CheepsAmongUsApi.API.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSwapGameMode
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency(CheepsAmongUsApi.CheepsAmongUs.PluginGuid)]    // Add the API as a dependency
    [BepInDependency(CheepsAmongUsMod.CheepsAmongUsMod.PluginGuid)] // Add the base mod as dependency
    [BepInProcess("Among Us.exe")]
    public class ColorSwap : BasePlugin
    {
        public const string PluginGuid = "com.cheep_yt.amonguscolorswap";
        public const string PluginName = "ColorSwapGameMode";
        public const string PluginVersion = "2.0.0";

        public const byte ColorSwapRpc = 63;

        public static ManualLogSource _logger = null;

        public ColorSwapGameMode GameMode;

        public override void Load()
        {
            _logger = Log;
            _logger.LogInfo($"{PluginName} v{PluginVersion} created by Cheep loaded");

            GameMode = new ColorSwapGameMode();
        }
    }
}
