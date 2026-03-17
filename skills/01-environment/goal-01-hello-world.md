# Goal 01: 建立開發與調試基礎環境

建立第一個《缺氧》C# 模組，驗證開發環境。

## 目標說明

在不修改原始碼的前提下，利用 Harmony 補丁技術建立實驗平台。

## 步驟

1. 安裝 .NET Framework 4.7.2 SDK
2. 安裝 Visual Studio 2019+
3. 建立類庫項目，引用遊戲 DLL
4. 使用 Harmony 補丁庫
5. 輸出到 Mod 目錄

## 關鍵代碼

```csharp
using Harmony;
using HarmonyLiberator;
using KMod;
using UnityEngine;

[HarmonyPatch]
public class AutomationMod : UserMod2 {
    public override void OnLoad() {
        Debug.Log("Automation Link Initialized");
        // 初始化代碼
    }
}
```

## Harmony 補丁基礎

### 前綴補丁 (Prefix)
```csharp
[HarmonyPatch(typeof(Game), "Update")]
public class Game_Update_Patch {
    static void Prefix() {
        // 在原始方法之前執行
    }
}
```

### 後綴補丁 (Postfix)
```csharp
[HarmonyPatch(typeof(Game), "Update")]
public class Game_Update_Patch {
    static void Postfix() {
        // 在原始方法之後執行
    }
}
```

## 引用遊戲 DLL

需要引用的關鍵 DLL：
- `Assembly-CSharp.dll` - 遊戲核心邏輯
- `UnityEngine.dll` - Unity 引擎
- `Harmony.dll` - 補丁庫

## 輸出路徑

```
<遊戲目錄>/Mods/<你的模組名稱>/assemblies/
```

## AI Prompt 模板

> 「請扮演資深 Unity 遊戲 Modder。我正在為《缺氧》開發自動化項目，請提供一個 C# 模組模板，要求使用 Harmony 補丁庫。模組需要在遊戲啟動時載入，並在控制台列印 'Automation Link Initialized'。請說明如何引用遊戲核心 DLL 文件並設置輸出路徑。」

## 驗證

遊戲啟動後查看控制台輸出 "Automation Link Initialized"。
