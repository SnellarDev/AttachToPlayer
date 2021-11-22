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
        private static UiManager uiManager;
        public static void BoneAttachValues(int BodyX, int BodyY, int BodyZ, bool isabreast = false, float PosX = 0, float PosY = 0, float PosZ = 0)
        {
            Player playercheck = Attach.cachedselected;
            if (playercheck.GetVRCPlayer().GetAnimator().isHuman)
            {
                if (Attach.Target != null)
                {
                    if(!isabreast)
                    {
                        Attach.Target = null;
                        Attach.AbreastAttachment = false;
                        Attach.CircularAttachment = false;
                    }
                    if(isabreast)
                    {
                        Attach.Target = null;
                        Attach.CircularAttachment = false;
                    }
                }
                Attach.BodyX = BodyX;
                Attach.BodyY = BodyY;
                Attach.BodyZ = BodyZ;
                Attach.PosX = PosX;
                Attach.PosY = PosY;
                Attach.PosZ = PosZ;
                Attach.Target = Attach.cachedselected;
                PlayerExtensions.FreezeLocalPlayer(false);
            }
            else
            MelonLogger.Msg("the player is not able to be attached to");
        }
        public static void AttachGUI()
        {
            uiManager = new UiManager("Target");
            uiManager.TargetMenu.AddMenuPage("Utils", "Opens a sub-menu for attaching to players");
            ReMenuPage page = uiManager.TargetMenu.GetMenuPage("Utils");

            page.AddButton("Attach To Player", "Attaches your player to the other player's head", delegate
            {
                BoneAttachValues(0, 0, 0);
            });

            page.AddMenuPage("Bone Attach", "Select the player's bones to attach to");
            ReMenuPage bonepage = page.GetMenuPage("Bone Attach");
            bonepage.AddButton("Chest", "Attaches your player to the other player's chest", delegate
            {
                BoneAttachValues(1, 1, 1);
            });

            bonepage.AddButton("Right Hand", "Attach to the right hand of the player", delegate
            {
                BoneAttachValues(2, 2, 2);
            });

            bonepage.AddButton("Left Hand", "Attach to the left hand of the player", delegate
            {
                BoneAttachValues(3, 3, 3);
            });

            bonepage.AddButton("Hips", "Attach to the hips of the player", delegate
            {
                BoneAttachValues(4, 4, 4);
            });

            bonepage.AddButton("Left Leg", "Attach to the left leg of the player", delegate
            {
                BoneAttachValues(5, 5, 5);
            });

            bonepage.AddButton("Right Leg", "Attach to the right leg of the player", delegate
            {
                BoneAttachValues(6, 6, 6);
            });

            bonepage.AddButton("Right Arm", "Attach to the right arm of the player", delegate
            {
                BoneAttachValues(7, 7, 7);
            });

            bonepage.AddButton("Left Arm", "Attach to the left arm of the player", delegate
            {
                BoneAttachValues(8, 8, 8);
            });

            bonepage.AddButton("Left Side", "Attach to the left side of the player", delegate
            {
                BoneAttachValues(9, 9, 9, true, 0.5f, 0f, 0f);
            });

            bonepage.AddButton("Right Side", "Attach to the right side of the player", delegate
            {
                BoneAttachValues(10, 10, 10, true, -0.5f, 0f, 0f);
            });

            //bonepage.AddButton("Below", "Attach below the player", delegate
            //{
            //    BoneAttachValues(11, 11, 11, true, 0f, -2f, 0f);
            //});

            //bonepage.AddButton("Above", "Attach above the player", delegate
            //{
            //    BoneAttachValues(11, 11, 11, true, 0f, 1f, 0f);
            //});
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