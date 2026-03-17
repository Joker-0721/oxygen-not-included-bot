# Goal 05: 建造指令

程序化執行遊戲建造動作。

## API

```csharp
BuildTool.Instance.TryBuild(cell, buildingId, materialId);
```

## 參數

- cell: 目標磁磚索引
- buildingId: 建築 ID
- materialId: 材料 ID

## AI Prompt

```
如何調用《缺氧》的 BuildTool 來自動建造一個建築物？
```
