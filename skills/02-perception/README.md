# 02-感知層 (Perception)

世界數據解耦與結構化導出，將遊戲數據轉化為 AI 可理解的格式。

## 相關目標

- [goal-03-grid-data](./goal-03-grid-data.md) - 讀取 Grid 磁磚數據
- [goal-04-json-export](./goal-04-json-export.md) - 導出為 JSON 格式

## 核心概念

- Grid.Temperature / Grid.Mass / Grid.Element
- 區域採樣 (ROI)
- 數據序列化

## AI Prompt 模板

```
請寫一段 C# 代碼，攔截遊戲的主循環，每隔 5 秒獲取玩家視野中心 20x20 磁磚的數據，包含元素 ID、溫、質量，封裝成 JSON。
```
