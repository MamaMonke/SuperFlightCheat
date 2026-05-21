using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using UnityEngine;

namespace SuperFlightCheats
{
    [BepInPlugin("MamaMonke", "Mod", "0.0.2")]
    public class main : BaseUnityPlugin
    {
        void Awake()
        {
            Debug.Log("Mod Is Loaded");
        }
        void Update()
        {
            SuperFlightCheats.Mods.Update();
        }

        void OnGUI()
        {
            GUI.color = Color.magenta;
            GUI.Box(new Rect(10, 10, 400, 560), "Mamamonke GUI");

            if (GUI.Button(new Rect(20, 40, 260, 30), "Add 1000 score"))
            {
                SuperFlightCheats.Mods.Add1KToPlayer();
            }

            if (GUI.Button(new Rect(20, 80, 260, 30), "Call Potal"))
            {
                SuperFlightCheats.Mods.CallPortal();
            }

            if (GUI.Button(new Rect(20, 120, 260, 30), "Fake New Score"))
            {
                SuperFlightCheats.Mods.FakeNewScore();
            }

            if (GUI.Button(new Rect(20, 160, 260, 30), "RGB Player"))
            {
                SuperFlightCheats.Mods.RGBplayer();
            }
            string godModeStatus = SuperFlightCheats.Plugin.UnityPlugin.isGodMode ? "God Mode [ON]" : "God Mode [OFF]";
            if (GUI.Button(new Rect(20, 200, 260, 30), godModeStatus))
            {
                SuperFlightCheats.Mods.ToggleGodMode();
            }
            if (GUI.Button(new Rect(20, 240, 260, 30), "Speed Boost"))
            {
                SuperFlightCheats.Mods.SpeedBoost();
            }
        }
    }
}
