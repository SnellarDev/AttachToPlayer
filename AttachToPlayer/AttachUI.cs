using MelonLoader;
using System.Collections;
using UnityEngine;
using VRC;
using VRC.Core;
using ReMod;
using ReMod.Core.Managers;
using ReMod.Core.UI;
using System;
using System.Threading;
using ReMod.Core.VRChat;
using VRC.UI.Elements.Menus;
using System.Collections.Generic;
using System.Linq;

namespace AttachToPlayer
{
    public static class AttachUI
    {
        public static bool ison;
        private static UiManager uiManager;
        public static Sprite sprith;
        public static void AttachGUI()
        {
            GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Toggle_SafeMode").gameObject.SetActive(false);
            uiManager = new UiManager("Target");
            uiManager.TargetMenu.AddMenuPage("Utils", "Opens a sub-menu for attaching to players");
            ReMenuPage page = uiManager.TargetMenu.GetMenuPage("Utils");
            page.AddButton("Attach To Player", "Attaches your player to the other player's head", delegate
            {
                Player playercheck = Attach.cachedselected;
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
                    Attach.Target = Attach.cachedselected;
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            });
            page.AddMenuPage("Bone Attach", "Select the player's bones to attach to");
            ReMenuPage bonepage = page.GetMenuPage("Bone Attach");
            bonepage.AddButton("Chest", "Attaches your player to the other player's chest", delegate
            {
                Player playercheck = Attach.cachedselected;
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
                    Attach.Target = Attach.cachedselected;
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            });
            bonepage.AddButton("Right Hand", "Attach to the right hand of the player", delegate
            {
                Player playercheck = Attach.cachedselected;
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
                    Attach.Target = Attach.cachedselected;
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            });
            bonepage.AddButton("Left Hand", "Attach to the left hand of the player", delegate
            {
                Player playercheck = Attach.cachedselected;
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
                    Attach.Target = Attach.cachedselected;
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            });

            bonepage.AddButton("Hips", "Attach to the hips of the player", delegate
            {
                Player playercheck = Attach.cachedselected;
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
                    Attach.Target = Attach.cachedselected;
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            });
            bonepage.AddButton("Left Leg", "Attach to the left leg of the player", delegate
            {
                Player playercheck = Attach.cachedselected;
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
                    Attach.Target = Attach.cachedselected;
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            });
            bonepage.AddButton("Right Leg", "Attach to the right leg of the player", delegate
            {
                Player playercheck = Attach.cachedselected;
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
                    Attach.Target = Attach.cachedselected;
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            });
            bonepage.AddButton("Right Arm", "Attach to the right arm of the player", delegate
            {
                Player playercheck = Attach.cachedselected;
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
                    Attach.Target = Attach.cachedselected;
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            });
            bonepage.AddButton("Left Arm", "Attach to the left arm of the player", delegate
            {
                Player playercheck = Attach.cachedselected;
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
                    Attach.Target = Attach.cachedselected;
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            });
            bonepage.AddButton("Left Side", "Attach to the left side of the player", delegate
            {
                Player playercheck = Attach.cachedselected;
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.CircularAttachment = false;
                    }
                    Attach.BodyX = 9;
                    Attach.BodyY = 9;
                    Attach.BodyZ = 9;
                    Attach.PosX = .5f;
                    Attach.PosY = 0f;
                    Attach.PosZ = 0f;
                    Attach.Target = Attach.cachedselected;
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            });
            bonepage.AddButton("Right Side", "Attach to the right side of the player", delegate
            {
                Player playercheck = Attach.cachedselected;
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.CircularAttachment = false;
                    }
                    Attach.BodyX = 10;
                    Attach.BodyY = 10;
                    Attach.BodyZ = 10;
                    Attach.PosX = -.5f;
                    Attach.PosY = 0f;
                    Attach.PosZ = 0f;
                    Attach.Target = Attach.cachedselected;
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            });
            bonepage.AddButton("Below", "Attach below the player", delegate
            {
                Player playercheck = Attach.cachedselected;
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.CircularAttachment = false;
                    }
                    Attach.BodyX = 11;
                    Attach.BodyY = 11;
                    Attach.BodyZ = 11;
                    Attach.PosX = 0f;
                    Attach.PosY = -2f;
                    Attach.PosZ = 0f;
                    Attach.Target = Attach.cachedselected;
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            });

            bonepage.AddButton("Above", "Attach above the player", delegate
            {
                Player playercheck = Attach.cachedselected;
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        Attach.Target = null;
                        Attach.CircularAttachment = false;
                    }
                    Attach.BodyX = 11;
                    Attach.BodyY = 11;
                    Attach.BodyZ = 11;
                    Attach.PosX = 0f;
                    Attach.PosY = 1f;
                    Attach.PosZ = 0f;
                    Attach.Target = Attach.cachedselected;
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                MelonLogger.Msg("the player is not able to be attached to");
            });
            page.AddButton("Orbit", "orbits the selected player", delegate
            {
                MelonLogger.Msg("orbit activated");
                if (Attach.Target != null)
                {
                    Attach.Target = null;
                    Attach.AbreastAttachment = false;
                }
                Attach.PosX = 1f;
                Attach.PosY = 0f;
                Attach.PosZ = 1f;
                Attach.Target = Attach.cachedselected;
                PlayerExtensions.FreezeLocalPlayer(false);
            });
        }

        public static Player GetSelectedPlayer()
        {
            var a = UnityEngine.Object.FindObjectOfType<SelectedUserMenuQM>().field_Private_IUser_0;
            return PlayerExtensions.GetPlayerByID(a.prop_String_0);
        }

        public static IEnumerator WhereDaUI()
        {
            while (QuickMenuEx.Instance == null) yield return null;
            AttachGUI();
            yield break;
        }
    }
}