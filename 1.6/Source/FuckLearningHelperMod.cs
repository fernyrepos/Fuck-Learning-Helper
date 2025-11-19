using HarmonyLib;
using Verse;

namespace FuckLearningHelper
{
    public class FuckLearningHelperMod : Mod
    {
        public FuckLearningHelperMod(ModContentPack pack) : base(pack)
        {
            new Harmony("FuckLearningHelperMod").PatchAll();
        }
    }
}