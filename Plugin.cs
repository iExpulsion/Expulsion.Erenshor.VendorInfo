using BepInEx;
using HarmonyLib;

namespace Expulsion.Erenshor.VendorInfo
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string PluginGuid = "Expulsion.Erenshor.VendorInfo";
        private const string PluginName = "VendorInfo";
        private const string PluginVersion = "1.0.0";

        private void Awake()
        {
            var harmonyInstance = new Harmony(PluginGuid);
            harmonyInstance.PatchAll();

            Logger.LogInfo($"Plugin {PluginName} is loaded!");
        }
    }
}