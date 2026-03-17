# Goal 03: 讀取 Grid 磁磚數據

從遊戲中讀取磁磚的物理數據。

## 關鍵數組

```csharp
// 溫度 (Kelvin)
float temp = Grid.Temperature[cellIndex];

// 質量 (kg)
float mass = Grid.Mass[cellIndex];

// 元素 ID
Element element = Grid.Element[cellIndex];
```

## 注意事項

- 全圖 15 萬磁磚，僅採樣活動區域
- 每秒採樣不超過 10 次

## AI Prompt

```
如何從《缺氧》的 Grid 類讀取指定座標的溫度和質量數據？
```
