using HarmonyLib;
using UnityEngine;
using Verse;

namespace FuckLearningHelper
{
    [HarmonyPatch(typeof(Listing_Standard), nameof(Listing_Standard.ButtonTextLabeledPct))]
    public class ListingStandard_ButtonTextLabeledPct_Patch
    {
        static bool Prefix(string label, string buttonLabel, float labelPct, TextAnchor anchor = TextAnchor.UpperLeft, string highlightTag = null, string tooltip = null, Texture2D labelIcon = null)
        {
            if (label == "ResetAdaptiveTutor".Translate())
            {
                return false;
            }
            return true;
        }
    }
}
