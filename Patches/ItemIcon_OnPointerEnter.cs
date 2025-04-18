using HarmonyLib;
using UnityEngine;

namespace Expulsion.Erenshor.VendorInfo.Patches
{
    [HarmonyPatch(typeof(ItemIcon), nameof(ItemIcon.OnPointerEnter))]
    public class ItemIcon_OnPointerEnter
    {
        public static void Postfix(ItemIcon __instance)
        {
            GameData.Misc.IDTitle.text = __instance.VendorSlot
                ? $"{__instance.MyItem.ItemName}\n{__instance.MyItem.ItemValue} Gold"
                : $"{__instance.MyItem.ItemName}\n{Mathf.RoundToInt(__instance.MyItem.ItemValue * 0.65f)} Gold";
        }
    }
}