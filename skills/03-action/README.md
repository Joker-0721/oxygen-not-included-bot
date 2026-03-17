# 03-行動層 (Action)

指令集抽象化與執行 API，將玩家動作轉化為程序化調用。

## 相關目標

- [goal-05-build-tool](./goal-05-build-tool.md) - 建造指令
- [goal-06-dig-tool](./goal-06-dig-tool.md) - 挖掘指令

## 核心概念

- BuildTool.TryBuild
- DigTool.AddItem
- 任務隊列 (Errands)

## AI Prompt 模板

```
請分析《缺氧》的 BuildTool 類，寫一個函數 InvokeBuild(buildingId, cellIndex, materialId) 來模擬玩家建造。
```
