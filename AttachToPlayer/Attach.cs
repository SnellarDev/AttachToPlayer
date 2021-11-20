using HarmonyLib;
using MelonLoader;
using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using UnhollowerRuntimeLib.XrefScans;
using UnityEngine;
using VRC.DataModel;
using VRC.UI.Elements.Menus;

namespace AttachToPlayer
{
    public class Attach : MelonMod
    {
        public static VRC.Player cachedselected;
        public static HarmonyLib.Harmony Instance = new HarmonyLib.Harmony("Patches");
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("Press Space to stop attaching or your right controller menu button if you are in VR(sorry lefties). This was made by Stellar");
            InitPatches();
            MelonCoroutines.Start(AttachUI.WhereDaUI());
            MelonCoroutines.Start(CheckNullPlayer());
        }
        private static HarmonyMethod GetPatch(string name)
        {
            return new HarmonyMethod(typeof(Attach).GetMethod(name, BindingFlags.Static | BindingFlags.NonPublic));
        }
        private static void InitPatches()
        {
            MethodInfo[] array = (from m in typeof(NetworkManager).GetMethods()
                                  where m.Name.Contains("Method_Public_Void_Player_") && !m.Name.Contains("PDM")
                                  select m).ToArray<MethodInfo>();
            try { Instance.Patch(AccessTools.Method(typeof(NetworkManager), array[1].Name, null, null), GetPatch("OnPlayerLeft")); } catch (Exception e) { MelonLogger.Error($"Error Patching OnPlayerLeft => {e.Message}"); }
        }

        private static bool OnPlayerLeft(ref VRC.Player __0)
        {
            try
            {
                if (Target.GetAPIUser().id == __0.GetAPIUser().id)
                {
                   AbreastAttachment = false;
                   CircularAttachment = false;
                   PlayerExtensions.FreezeLocalPlayer(true);
                   Target = null;
                }
            }
            catch { }
            return true;
        }
        public static IEnumerator CheckNullPlayer()
        {
            for (; ; )
            {
                try
                {
                    if (PlayerExtensions.IsInWorld() && AttachUI.GetSelectedPlayer() != null)
                    {
                        cachedselected = AttachUI.GetSelectedPlayer();
                    }
                }
                catch { }
                yield return new WaitForSeconds(0.1f);
            }
        }

        public override void OnUpdate()
        {
            for (int i = 0; i < keycodes.Length; i++) if (Target != null && Input.GetKeyDown(keycodes[i]))
                {
                    PlayerExtensions.FreezeLocalPlayer(true);
                    Target = null;
                    AbreastAttachment = false;
                    CircularAttachment = false;
                }
            if (Target != null && PlayerExtensions.LocalVRCPlayer != null && !AbreastAttachment && !CircularAttachment)
            {
                PlayerExtensions.LocalPlayer.transform.position = new Vector3(Target.GetVRCPlayer().GetAnimator().GetBoneTransform(boneparts[BodyX]).position.x, Target.GetVRCPlayer().GetAnimator().GetBoneTransform(boneparts[BodyY]).position.y, Target.GetVRCPlayer().GetAnimator().GetBoneTransform(boneparts[BodyZ]).position.z);
            }
            if (Target != null && PlayerExtensions.LocalVRCPlayer != null && AbreastAttachment && !CircularAttachment)
            {
                PlayerExtensions.LocalPlayer.transform.position = new Vector3(Target.GetVRCPlayer().GetAnimator().GetBoneTransform(boneparts[BodyX]).position.x + PosX, Target.GetVRCPlayer().GetAnimator().GetBoneTransform(boneparts[BodyY]).position.y + PosY, Target.GetVRCPlayer().GetAnimator().GetBoneTransform(boneparts[BodyZ]).position.z + PosZ);
            }
            if (Target != null && PlayerExtensions.LocalVRCPlayer != null && !AbreastAttachment && CircularAttachment)
            {
                outset += Time.deltaTime * circularspeed;
                PlayerExtensions.LocalPlayer.transform.position = new Vector3(Target.transform.position.x + PosX * (float)System.Math.Cos((double)outset), Target.transform.position.y, Target.transform.position.z + PosZ * (float)System.Math.Sin((double)outset));
            }
        }

        public static VRC.Player Target;
        public static bool AbreastAttachment;
        public static bool CircularAttachment;
        public static float outset = 0f;
        public static float circularspeed = 2f;
        public static float PosX;
        public static float PosY;
        public static float PosZ;
        public static int BodyX;
        public static int BodyY;
        public static int BodyZ;
        private KeyCode[] keycodes = new KeyCode[] { KeyCode.Space, KeyCode.JoystickButton15 };
        public HumanBodyBones[] boneparts = new HumanBodyBones[] { HumanBodyBones.Head, HumanBodyBones.Chest, HumanBodyBones.LeftHand, HumanBodyBones.RightHand, HumanBodyBones.Hips, HumanBodyBones.LeftLowerLeg, HumanBodyBones.RightLowerLeg, HumanBodyBones.RightLowerArm, HumanBodyBones.LeftLowerArm, HumanBodyBones.LeftToes, HumanBodyBones.RightToes, HumanBodyBones.Spine };
    }
}