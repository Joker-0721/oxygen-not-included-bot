# Goal 02: 使用 dnSpy 分析遊戲類

使用 dnSpy 反編譯遊戲 DLL，找到關鍵類和方法。

## 目標說明

使用 dnSpy 分析 `Assembly-CSharp.dll` 尋找關鍵類，為後續數據讀取做準備。

## 步驟

1. 下載 dnSpy (https://github.com/dnSpy/dnSpy)
2. 打開 `<遊戲目錄>/Oxygen Not Included_Data/Managed/Assembly-CSharp.dll`
3. 搜索關鍵類：`Game`, `Grid`, `World`
4. 記錄屬性偏移地址和方法簽名

## 關鍵類

| 類名 | 用途 |
| :--- | :--- |
| `Game.Instance` | 全局遊戲實例 |
| `Grid` | 磁磚數據靜態類 |
| `World.Instance` | 世界實例 |
| `BuildTool` | 建造工具類 |
| `DigTool` | 挖掘工具類 |

## 常用搜索關鍵字

- `Temperature` - 溫度相關
- `Mass` - 質量相關
- `Element` - 元素相關
- `GetCell` - 獲取磁磚
- `Update` - 遊戲更新循環

## 分析技巧

1. 右鍵 → 分析 → 查看引用
2. 雙擊方法名 → 查看 IL 代碼
3. 記錄方法的完整簽名（命名空間 + 類名 + 方法名）

## AI Prompt

> 「我需要找到《缺氧》中讀取磁磚溫度的方法。請用 dnSpy 分析 Grid 類，找出 Temperature 相關的數組和方法，請提供 C# 代碼示例。」

## 注意事項

- 遊戲更新後 DLL 可能變化，需重新分析
- 建議記錄關鍵類的偏移地址
- 使用 ILSpy 作為替代工具
