# Goal 01: Hello World 模組

建立第一個《缺氧》C# 模組，驗證開發環境。

## 步驟

1. 安裝 .NET Framework 4.7.2 SDK
2. 安裝 Visual Studio 2019+
3. 建立類庫項目，引用遊戲 DLL
4. 使用 Harmony 補丁
5. 輸出到 Mod 目錄

## 關鍵代碼

```csharp
using Harmony;
using UnityEngine;

[HarmonyPatch]
public class Mod {
    public static void Init() {
        Debug.Log("Automation Link Initialized");
    }
}
```

## 驗證

遊戲啟動後查看控制台輸出。
