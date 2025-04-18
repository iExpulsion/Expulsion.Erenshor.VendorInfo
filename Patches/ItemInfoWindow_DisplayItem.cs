using HarmonyLib;
using UnityEngine;

namespace Expulsion.Erenshor.VendorInfo.Patches
{
    [HarmonyPatch(typeof(ItemInfoWindow), nameof(ItemInfoWindow.DisplayItem))]
    public class ItemInfoWindow_DisplayItem
    {
        public static void Postfix(ItemInfoWindow __instance, Item item)
        {
            __instance.ItemName.text = GameData.HighlightedItem.VendorSlot
                ? $"{item.ItemName}\n<size=75%>{item.ItemValue} Gold</size>"
                : $"{item.ItemName}\n<size=75%>{Mathf.RoundToInt(item.ItemValue * 0.65f)} Gold</size>";
        }
    }
}