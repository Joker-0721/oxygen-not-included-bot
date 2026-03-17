using Harmony;
using UnityEngine;

/// <summary>
/// Oxygen Not Included Automation Mod
/// 缺氧遊戲自動化模組
/// </summary>
public class OniAutomationMod
{
    private static Harmony _harmony;
    
    /// <summary>
    /// 模組加載時調用 (由遊戲調用)
    /// </summary>
    public static void Init()
    {
        Debug.Log("[OniAutomation] Automation Link Initialized");
        Debug.Log("[OniAutomation] Mod loaded successfully");
        
        // 初始化 Harmony 補丁 (Harmony 2.x API)
        _harmony = new Harmony("com.oni.automation");
        _harmony.PatchAll();
        
        Debug.Log("[OniAutomation] Harmony patches applied");
    }

    /// <summary>
    /// 模組卸載時調用
    /// </summary>
    public static void Shutdown()
    {
        Debug.Log("[OniAutomation] Mod unloaded");
        
        _harmony?.UnpatchAll("com.oni.automation");
    }
}

/// <summary>
/// 遊戲更新循環的補丁
/// </summary>
[HarmonyPatch]
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
