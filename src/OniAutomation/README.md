# OniAutomation Mod

《缺氧》遊戲自動化模組

## 環境需求

- .NET Framework 4.7.2
- Visual Studio 2019+ 或 Rider

## 設置步驟

1. **添加遊戲 DLL 引用**
   
   需要引用以下 DLL（從遊戲目錄 `Oxygen Not Included_Data/Managed/`）：
   - `Assembly-CSharp.dll`
   - `UnityEngine.dll`
   - `UnityEngine.CoreModule.dll`

2. **安裝依賴**
   ```bash
   dotnet restore
   ```

3. **編譯**
   ```bash
   dotnet build
   ```

4. **輸出**
   
   編譯後的 DLL 位於 `bin/Debug/net472/OniAutomation.dll`

## 安裝到遊戲

1. 創建目錄：`Oxygen Not Included/Mods/OniAutomation/`
2. 將編譯的 DLL 複製到 `assemblies/` 子目錄
3. 創建 `mod.yaml` 文件：
   ```yaml
   contentID: OniAutomation
   description: 缺氧遊戲自動化模組
   ```

## 運行遊戲

遊戲啟動後，在控制台（Debug Console）應該看到：
```
[OniAutomation] Automation Link Initialized
[OniAutomation] Mod loaded successfully
[OniAutomation] Harmony patches applied
[OniAutomation] Game initialized
```

## 下一步

- 使用 dnSpy 分析遊戲類
- 實現 Grid 數據讀取
- 添加 Socket 通信
