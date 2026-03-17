# Goal 02: 使用 dnSpy 分析遊戲類

使用 dnSpy 反編譯遊戲 DLL，找到關鍵類和方法。

## 步驟

1. 下載 dnSpy
2. 打開 `Assembly-CSharp.dll`
3. 搜索關鍵類：`Game`, `Grid`, `World`
4. 記錄屬性偏移地址

## 關鍵類

| 類名 | 用途 |
| :--- | :--- |
| `Game.Instance` | 全局遊戲實例 |
| `Grid` | 磁磚數據靜態類 |
| `World.Instance` | 世界實例 |

## AI Prompt

```
我需要找到《缺氧》中讀取磁磚溫度的方法。請用 dnSpy 分析 Grid 類，找出 Temperature 相關的數組和方法。
```
