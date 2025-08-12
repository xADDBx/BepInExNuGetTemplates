using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Text;
using System.Reflection;
using UnityEngine;

namespace {SourceName};

public static class Main : BaseUnityPlugin {
    public const string PLUGIN_GUID = "{SourceName}";
    public const string PLUGIN_NAME = "{Description}";
    public const string PLUGIN_VERSION = "{Version}";
    internal static Harmony HarmonyInstance;
    internal static ManualLogSource Log;

    private void Awake() {
        Log = Logger;
        HarmonyInstance = new Harmony(PLUGIN_GUID);
        try {
            HarmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
        } catch {
            HarmonyInstance.UnpatchAll(PLUGIN_GUID);
            throw;
        }
        Logger.LogInfo($"Plugin {PLUGIN_GUID} is loaded!");
    }
}
