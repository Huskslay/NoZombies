using System;
using System.Collections.Generic;
using UnityEngine;
using HarmonyLib;

namespace NoZombies.Patches;

[HarmonyPatch(typeof(MushroomZombieSpawner))]
public class MushroomZombieSpawnerPatch
{
    [HarmonyPrefix]
    [HarmonyPatch(nameof(MushroomZombieSpawner.Start))]
    public static bool StartPrefix(MushroomZombieSpawner __instance)
    {
        UnityEngine.Object.Destroy(__instance.gameObject);
        Plugin.Logger.LogMessage($"No zombies, removing zombie spawner!");
        return false;
    }
}
