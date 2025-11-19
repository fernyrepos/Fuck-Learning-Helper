using HarmonyLib;
using RimWorld;

namespace FuckLearningHelper
{
    [HarmonyPatch(typeof(LearningReadout), nameof(LearningReadout.LearningReadoutOnGUI))]
    public class LearningReadout_LearningReadoutOnGUI_Patch
    {
        static bool Prefix()
        {
            return false;
        }
    }
}
