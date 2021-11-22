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
        public static void AttachGUI()
        {
            uiManager = new UiManager("Target");
            uiManager.TargetMenu.AddMenuPage("Utils", "Opens a sub-menu for attaching to players");
            ReMenuPage page = uiManager.TargetMenu.GetMenuPage("Utils");

            page.AddButton("Attach To Player", "Attaches your player to the other player's head", delegate
            {
                BoneAttachValues(new Vector3(0, 0, 0));
            });

            page.AddMenuPage("Bone Attach", "Select the player's bones to attach to");
            ReMenuPage bonepage = page.GetMenuPage("Bone Attach");

            bonepage.AddButton("Chest", "Attaches your player to the other player's chest", delegate
            {
                BoneAttachValues(new Vector3(1, 1, 1));
            });

            bonepage.AddButton("Right Hand", "Attach to the right hand of the player", delegate
            {
                BoneAttachValues(new Vector3(2, 2, 2));
            });

            bonepage.AddButton("Left Hand", "Attach to the left hand of the player", delegate
            {
                BoneAttachValues(new Vector3(3, 3, 3));
            });

            bonepage.AddButton("Hips", "Attach to the hips of the player", delegate
            {
                BoneAttachValues(new Vector3(4, 4, 4));
            });

            bonepage.AddButton("Left Leg", "Attach to the left leg of the player", delegate
            {
                BoneAttachValues(new Vector3(5, 5, 5));
            });

            bonepage.AddButton("Right Leg", "Attach to the right leg of the player", delegate
            {
                BoneAttachValues(new Vector3(6, 6, 6));
            });

            bonepage.AddButton("Right Arm", "Attach to the right arm of the player", delegate
            {
                BoneAttachValues(new Vector3(7, 7, 7));
            });

            bonepage.AddButton("Left Arm", "Attach to the left arm of the player", delegate
            {
                BoneAttachValues(new Vector3(8, 8, 8));
            });

            bonepage.AddButton("Left Side", "Attach to the left side of the player", delegate
            {
                BoneAttachValues(new Vector3(9, 9, 9), new Vector3(0.5f, 0f, 0f), true);
            });

            bonepage.AddButton("Right Side", "Attach to the right side of the player", delegate
            {
                BoneAttachValues(new Vector3(10, 10, 10), new Vector3(-0.5f, 0f, 0f), true);
            });
        }

        public static void BoneAttachValues(Vector3 bonevec, Vector3 posvec = default(Vector3), bool isabreast = false)
        {
            try
            {
                Player playercheck = Attach.cachedselected;
                if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
                {
                    if (Attach.Target != null)
                    {
                        if (!isabreast)
                        {
                            Attach.Target = null;
                            Attach.AbreastAttachment = false;
                            Attach.CircularAttachment = false;
                        }
                        if (isabreast)
                        {
                            Attach.Target = null;
                            Attach.CircularAttachment = false;
                        }
                    }
                    Attach.BodyVector3.x = bonevec.x;
                    Attach.BodyVector3.y = bonevec.y;
                    Attach.BodyVector3.z = bonevec.z;
                    Attach.PosVector3.x = posvec.x;
                    Attach.PosVector3.y = posvec.y;
                    Attach.PosVector3.z = posvec.z;
                    Attach.Target = Attach.cachedselected;
                    PlayerExtensions.FreezeLocalPlayer(false);
                }
                else
                    MelonLogger.Error("The player is not able to be attached to");
            }
            catch { }
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

        private static UiManager uiManager;

    }
}