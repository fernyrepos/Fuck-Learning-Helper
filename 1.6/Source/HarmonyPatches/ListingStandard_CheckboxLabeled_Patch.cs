using HarmonyLib;
using Verse;

namespace FuckLearningHelper
{
    [HarmonyPatch(typeof(Listing_Standard), nameof(Listing_Standard.CheckboxLabeled), new[] { typeof(string), typeof(bool), typeof(string), typeof(float), typeof(float) }, new ArgumentType[] { ArgumentType.Normal, ArgumentType.Ref, ArgumentType.Normal, ArgumentType.Normal, ArgumentType.Normal })]
    public class ListingStandard_CheckboxLabeled_Patch
    {
        static bool Prefix(string label, ref bool checkOn, string tooltip = null, float height = 0f, float labelPct = 1f)
        {
            if (label == "LearningHelper".Translate())
            {
                return false;
            }
            return true;
        }
    }
}
