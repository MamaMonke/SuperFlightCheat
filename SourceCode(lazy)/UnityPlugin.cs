using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SuperFlightCheats.Plugin
{
    internal class UnityPlugin
    {
        public static bool isGodMode = false;
        public static void Invinc()
        {
            if (isGodMode && LocalGameManager.Singleton != null)
            {
                if (LocalGameManager.Singleton.playerState == LocalGameManager.PlayerState.Dead)
                {
                    LocalGameManager.Singleton.playerState = LocalGameManager.PlayerState.Flying;
                    LocalGameManager.Singleton.OnPortalEnter();
                }
            }
        }
    }
}
