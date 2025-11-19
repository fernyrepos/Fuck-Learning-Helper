using HarmonyLib;
using UnityEngine;
using Verse;

namespace FuckLearningHelper
{
    [HarmonyPatch(typeof(WidgetRow), nameof(WidgetRow.ToggleableIcon))]
    public class WidgetRow_ToggleableIcon_Patch
    {
        static bool Prefix(ref bool toggleable, Texture2D tex, string tooltip, SoundDef mouseoverSound = null, string tutorTag = null)
        {
            if (tex == TexButton.ShowLearningHelper)
            {
                return false;
            }
            return true;
        }
    }
}
