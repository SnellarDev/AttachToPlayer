using MelonLoader;
using RubyButtonAPI;
using System.Collections;
using UnityEngine;
using VRC;
using VRC.Core;

namespace AttachToPlayer
{
    internal class AttachUI
    {
        public static void AttachGUI()
        {
            Object.Destroy(GameObject.Find("UserInterface/QuickMenu/UserInteractMenu/ReportAbuseButton"));
            TargetNest = new QMNestedButton("UserInteractMenu", 4, 1, "Attach Utils", "Opens a sub-menu for attaching to players", Color.cyan, Color.cyan, null, null);
            AttachToPlayer = new QMSingleButton(TargetNest, 1, 0, "Attach To Player", delegate
            {
                Player playercheck = GetSelectedPlayer();
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.AbreastAttachment = false;
                        Attach.CircularAttachment = false;
                    }
                    Attach.BodyX = 0;
                    Attach.BodyY = 0;
                    Attach.BodyZ = 0;
                    Attach.Target = GetSelectedPlayer();
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            }, "Attaches your player to the other player's head", Color.cyan, Color.cyan);
            AttachToBone = new QMNestedButton(TargetNest, 2, 0, "Bone Attach", "Select the player's bones to attach to", Color.cyan, Color.cyan, null, null);
            AttachToChest = new QMSingleButton(AttachToBone, 1, 0, "Chest", delegate
            {
                Player playercheck = GetSelectedPlayer();
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.AbreastAttachment = false;
                        Attach.CircularAttachment = false;
                    }
                    Attach.BodyX = 1;
                    Attach.BodyY = 1;
                    Attach.BodyZ = 1;
                    Attach.Target = GetSelectedPlayer();
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            }, "Attach to the chest of the player", Color.cyan, Color.cyan);
            AttachToRightHand = new QMSingleButton(AttachToBone, 2, 0, "Right Hand", delegate
            {
                Player playercheck = GetSelectedPlayer();
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.AbreastAttachment = false;
                        Attach.CircularAttachment = false;
                    }
                    Attach.BodyX = 2;
                    Attach.BodyY = 2;
                    Attach.BodyZ = 2;
                    Attach.Target = GetSelectedPlayer();
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            }, "Attach to the right hand of the player", Color.cyan, Color.cyan);
            AttachToLeftHand = new QMSingleButton(AttachToBone, 3, 0, "Left Hand", delegate
            {
                Player playercheck = GetSelectedPlayer();
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.AbreastAttachment = false;
                        Attach.CircularAttachment = false;
                    }
                    Attach.BodyX = 3;
                    Attach.BodyY = 3;
                    Attach.BodyZ = 3;
                    Attach.Target = GetSelectedPlayer();
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            }, "Attach to the left hand of the player", Color.cyan, Color.cyan);
            AttachToHips = new QMSingleButton(AttachToBone, 4, 0, "Hips", delegate
            {
                Player playercheck = GetSelectedPlayer();
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.AbreastAttachment = false;
                        Attach.CircularAttachment = false;
                    }
                    Attach.BodyX = 4;
                    Attach.BodyY = 4;
                    Attach.BodyZ = 4;
                    Attach.Target = GetSelectedPlayer();
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            }, "Attach to the hip of the player", Color.cyan, Color.cyan);
            AttachToLeftLeg = new QMSingleButton(AttachToBone, 1, 1, "Left Leg", delegate
            {
                Player playercheck = GetSelectedPlayer();
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.AbreastAttachment = false;
                        Attach.CircularAttachment = false;
                    }
                    Attach.BodyX = 5;
                    Attach.BodyY = 5;
                    Attach.BodyZ = 5;
                    Attach.Target = GetSelectedPlayer();
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            }, "Attach to the left leg of the player", Color.cyan, Color.cyan);
            AttachToRightLeg = new QMSingleButton(AttachToBone, 2, 1, "Right Leg", delegate
            {
                Player playercheck = GetSelectedPlayer();
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.AbreastAttachment = false;
                        Attach.CircularAttachment = false;
                    }
                    Attach.BodyX = 6;
                    Attach.BodyY = 6;
                    Attach.BodyZ = 6;
                    Attach.Target = GetSelectedPlayer();
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            }, "Attach to the right leg of the player", Color.cyan, Color.cyan);
            AttachToRightArm = new QMSingleButton(AttachToBone, 3, 1, "Right Arm", delegate
            {
                Player playercheck = GetSelectedPlayer();
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.AbreastAttachment = false;
                        Attach.CircularAttachment = false;
                    }
                    Attach.BodyX = 7;
                    Attach.BodyY = 7;
                    Attach.BodyZ = 7;
                    Attach.Target = GetSelectedPlayer();
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            }, "Attach to the right arm of the player", Color.cyan, Color.cyan);
            AttachToLeftArm = new QMSingleButton(AttachToBone, 4, 1, "Left Arm", delegate
            {
                Player playercheck = GetSelectedPlayer();
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.AbreastAttachment = false;
                        Attach.CircularAttachment = false;
                    }
                    Attach.BodyX = 8;
                    Attach.BodyY = 8;
                    Attach.BodyZ = 8;
                    Attach.Target = GetSelectedPlayer();
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            }, "Attach to the left arm of the player", Color.cyan, Color.cyan);
            AttachToLeftSide = new QMSingleButton(AttachToBone, 1, 2, "Left Side", delegate
            {
                Player playercheck = GetSelectedPlayer();
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.CircularAttachment = false;
                    }
                    Attach.AbreastAttachment = true;
                    Attach.BodyX = 9;
                    Attach.BodyY = 9;
                    Attach.BodyZ = 9;
                    Attach.PosX = .5f;
                    Attach.PosY = 0f;
                    Attach.PosZ = 0f;
                    Attach.Target = GetSelectedPlayer();
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            }, "Attach to an offsetted side of the player", Color.cyan, Color.cyan);
            AttachToRightSide = new QMSingleButton(AttachToBone, 2, 2, "Right Side", delegate
            {
                Player playercheck = GetSelectedPlayer();
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.CircularAttachment = false;
                    }
                    Attach.AbreastAttachment = true;
                    Attach.BodyX = 10;
                    Attach.BodyY = 10;
                    Attach.BodyZ = 10;
                    Attach.PosX = -.5f;
                    Attach.PosY = 0f;
                    Attach.PosZ = 0f;
                    Attach.Target = GetSelectedPlayer();
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            }, "Attach to an offsetted side of the player", Color.cyan, Color.cyan);
            AttachToBelow = new QMSingleButton(AttachToBone, 3, 2, "Below", delegate
            {
                Player playercheck = GetSelectedPlayer();
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.CircularAttachment = false;
                    }
                    Attach.AbreastAttachment = true;
                    Attach.BodyX = 11;
                    Attach.BodyY = 11;
                    Attach.BodyZ = 11;
                    Attach.PosX = 0f;
                    Attach.PosY = -2f;
                    Attach.PosZ = 0f;
                    Attach.Target = GetSelectedPlayer();
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            }, "Attach to a pivot below the player", Color.cyan, Color.cyan);
            AttachToAbove = new QMSingleButton(AttachToBone, 4, 2, "Above", delegate
            {
                Player playercheck = GetSelectedPlayer();
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.CircularAttachment = false;
                    }
                    Attach.AbreastAttachment = true;
                    Attach.BodyX = 11;
                    Attach.BodyY = 11;
                    Attach.BodyZ = 11;
                    Attach.PosX = 0f;
                    Attach.PosY = 1f;
                    Attach.PosZ = 0f;
                    Attach.Target = GetSelectedPlayer();
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            }, "Attach to a pivot above the player", Color.cyan, Color.cyan);
            OrbitTarget = new QMSingleButton(TargetNest, 3, 0, "Orbit", delegate
            {
                if (Attach.Target != null)
                {
                    Attach.Target = null;
                    Attach.AbreastAttachment = false;
                }

                Attach.CircularAttachment = true;
                Attach.PosX = 1f;
                Attach.PosY = 0f;
                Attach.PosZ = 1f;
                Attach.Target = GetSelectedPlayer();
                PlayerExtensions.FreezeLocalPlayer(false);
            }, "Orbits the targeted player", Color.cyan, Color.cyan);
        }

        public static QuickMenu GetQuickMenu()
        {
            return QuickMenu.prop_QuickMenu_0;
        }

        public static APIUser GetSelectedAPIUser()
        {
            return GetQuickMenu().field_Private_APIUser_0;
        }

        public static Player GetSelectedPlayer()
        {
            return PlayerExtensions.GetPlayerByID(GetSelectedAPIUser().id);
        }

        public static IEnumerator WhereDaUI()
        {
            while (VRCUiManager.prop_VRCUiManager_0 == null) yield return null;
            AttachGUI();
            yield break;
        }

        public static QMNestedButton TargetNest;
        public static QMSingleButton AttachToPlayer;
        public static QMNestedButton AttachToBone;
        public static QMSingleButton OrbitTarget;
        public static QMSingleButton AttachToChest;
        public static QMSingleButton AttachToHips;
        public static QMSingleButton AttachToLeftLeg;
        public static QMSingleButton AttachToRightLeg;
        public static QMSingleButton AttachToLeftArm;
        public static QMSingleButton AttachToRightArm;
        public static QMSingleButton AttachToBelow;
        public static QMSingleButton AttachToAbove;
        public static QMSingleButton AttachToLeftSide;
        public static QMSingleButton AttachToRightSide;
        public static QMSingleButton AttachToLeftHand;
        public static QMSingleButton AttachToRightHand;
    }
}