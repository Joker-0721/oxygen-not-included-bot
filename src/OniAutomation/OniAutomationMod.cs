using Harmony;
using KMod;
using UnityEngine;

/// <summary>
/// Oxygen Not Included Automation Mod
/// 缺氧遊戲自動化模組
/// </summary>
[HarmonyPatch]
public class OniAutomationMod : UserMod2
{
    /// <summary>
    /// 模組加載時調用
    /// </summary>
    public override void OnLoad()
    {
        Debug.Log("[OniAutomation] Automation Link Initialized");
        Debug.Log("[OniAutomation] Mod loaded successfully");
        
        // 初始化 Harmony 補丁
        var harmony = HarmonyInstance.Create("com.oni.automation");
        harmony.PatchAll();
        
        Debug.Log("[OniAutomation] Harmony patches applied");
    }

    /// <summary>
    /// 模組卸載時調用
    /// </summary>
    public override void OnUnload()
    {
        Debug.Log("[OniAutomation] Mod unloaded");
        
        var harmony = HarmonyInstance.Create("com.oni.automation");
        harmony.UnpatchAll("com.oni.automation");
    }
}

/// <summary>
/// 遊戲更新循環的補丁
/// </summary>
[HarmonyPatch]
[HarmonyPatchCategory("OniAutomation")]
public class GameUpdatePatch
{
    private static float _updateInterval = 5f;  // 5秒更新一次
    private static float _lastUpdateTime = 0f;

    /// <summary>
    /// 前綴補丁 - 在遊戲更新前執行
    /// </summary>
    [HarmonyPatch(typeof(Game), "Update")]
    [HarmonyPrefix]
    public static void UpdatePrefix()
    {
        float currentTime = Time.time;
        
        if (currentTime - _lastUpdateTime >= _updateInterval)
        {
            _lastUpdateTime = currentTime;
            
            // 這裡可以添加數據採集邏輯
            // Debug.Log("[OniAutomation] Game update tick");
        }
    }
}

/// <summary>
/// 遊戲實例初始化補丁
/// </summary>
[HarmonyPatch(typeof(Game), "OnPrefabInit")]
[HarmonyPatchCategory("OniAutomation")]
public class GameInitPatch
{
    /// <summary>
    /// 後綴補丁 - 在遊戲初始化後執行
    /// </summary>
    [HarmonyPostfix]
    public static void OnPrefabInitPostfix()
    {
        Debug.Log("[OniAutomation] Game initialized");
    }
}
