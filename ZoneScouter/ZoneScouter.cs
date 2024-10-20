﻿namespace ZoneScouter;

using System.Reflection;

using BepInEx;

using HarmonyLib;

using static PluginConfig;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public sealed class ZoneScouter : BaseUnityPlugin {
  public const string PluginGuid = "redseiko.valheim.zonescouter";
  public const string PluginName = "ZoneScouter";
  public const string PluginVersion = "1.6.0";

  void Awake() {
    BindConfig(Config);
    ZoneSystemUtils.SetupUtils();

    Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), harmonyInstanceId: PluginGuid);
  }
}
