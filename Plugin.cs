using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.IO;
using System.Reflection;
using System;
using UnityEngine;
using BepInEx.Configuration;


namespace NoZombies;


[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;


    public static readonly KeyCode GUIKey = KeyCode.Home;


    private void Awake()
    {
        Logger = base.Logger;

        Patch();

        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
    }

    private void Patch()
    {
        Harmony patcher = new("HarmonyPatcher");
        patcher.PatchAll();
    }
}
