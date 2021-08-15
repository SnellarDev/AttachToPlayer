using Harmony;
using System;
using System.Reflection;

namespace AttachToPlayer
{
    public class Patch
    {
        public Patch(Type PatchClass, Type YourClass, string Method, string ReplaceMethod, BindingFlags stat = BindingFlags.Static, BindingFlags pub = BindingFlags.NonPublic)
        {
            Patch.HInstance.Patch(AccessTools.Method(PatchClass, Method, null, null), this.GetPatch(YourClass, ReplaceMethod, stat, pub), null, null);
        }

        private HarmonyMethod GetPatch(Type YourClass, string MethodName, BindingFlags stat, BindingFlags pub)
        {
            return new HarmonyMethod(YourClass.GetMethod(MethodName, stat | pub));
        }

        private static readonly HarmonyInstance HInstance = HarmonyInstance.Create("StarlightPatches");

        internal static Type GetPatch(string v)
        {
            throw new NotImplementedException();
        }
    }
}