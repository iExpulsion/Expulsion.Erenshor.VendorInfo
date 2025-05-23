﻿using BepInEx;
using HarmonyLib;

namespace Expulsion.Erenshor.VendorInfo
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string PluginGuid = "Expulsion.Erenshor.VendorInfo";
        private const string PluginName = "VendorInfo";
        private const string PluginVersion = "1.0.2";

        private Harmony _harmonyInstance;
        
        private void Awake()
        {
            _harmonyInstance = new Harmony(PluginGuid);
            _harmonyInstance.PatchAll();

            Logger.LogInfo($"Plugin {PluginName} is loaded!");
        }

        private void OnDestroy()
        {
            _harmonyInstance.UnpatchSelf();
        }
    }
}