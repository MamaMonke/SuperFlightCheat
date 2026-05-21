using System;
using UnityEngine;

namespace SuperFlightCheats
{
    internal class Mods
    {
        private static bool isColoringPlayer = false;

        public static void Update()
        {
            ApplyGodMode();
            if (isColoringPlayer)
            {
                ColorGenerator.ColorizePlayer();
            }
        }

        private static void ApplyGodMode()
        {
            if (SuperFlightCheats.Plugin.UnityPlugin.isGodMode && LocalGameManager.Singleton != null && PlayerMovement.Singleton != null)
            {
                if (LocalGameManager.Singleton.playerState == LocalGameManager.PlayerState.Dead)
                {
                    LocalGameManager.Singleton.playerState = LocalGameManager.PlayerState.Flying;
                    var rb = PlayerMovement.Singleton.GetComponent<Rigidbody>();
                    if (rb != null)
                    {
                        rb.useGravity = false;
                        rb.drag = 0f;
                    }
                    LocalGameManager.Singleton.OnPortalEnter();
                }
            }
        }

        public static void ToggleGodMode()
        {
            SuperFlightCheats.Plugin.UnityPlugin.isGodMode = !SuperFlightCheats.Plugin.UnityPlugin.isGodMode;
        }

        public static void RGBplayer()
        {
            isColoringPlayer = !isColoringPlayer;
        }

        public static void SpeedBoost()
        {
            if (PlayerMovement.Singleton != null)
            {
                PlayerMovement.Singleton.forwardSpeedLimits.max = 2000f;
                PlayerMovement.Singleton.currentSpeed += 150f;
            }
        }

        public static void Add1KToPlayer()
        {
            if (LocalGameManager.Singleton != null)
                LocalGameManager.Singleton.AddBonusToRunScore(1000f);
        }

        public static void CallPortal()
        {
            if (LocalGameManager.Singleton != null)
                LocalGameManager.Singleton.OnPortalEnter();
        }

        public static void FakeNewScore()
        {
            UIManager.Singleton.CallAPraisImage(UIManager.Singleton.stylesLibrary.newHighScore, UIManager.Singleton.firstDelay, 0.1f, false, true);
        }
    }
}