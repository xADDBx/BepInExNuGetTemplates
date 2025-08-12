using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Text;
using System.Reflection;
using UnityEngine;

namespace {SourceName};

[BepInPlugin(Main.PLUGIN_GUID, Main.PLUGIN_NAME, Main.PLUGIN_VERSION)]
public class Main : BaseUnityPlugin {
    public const string PLUGIN_GUID = "{SourceName}";
    public const string PLUGIN_NAME = "{Description}";
    public const string PLUGIN_VERSION = "{Version}";
    internal static Harmony HarmonyInstance;
    internal static ManualLogSource Log;

    internal void Awake() {
        Log = Logger;
        HarmonyInstance = new Harmony(PLUGIN_GUID);
        try {
            HarmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
        } catch {
            HarmonyInstance.UnpatchSelf();
            throw;
        }
        Log.LogInfo($"Plugin {PLUGIN_GUID} is loaded!");
    }
}
