# Goal 04: JSON 數據導出

將遊戲數據序列化為 JSON 格式。

## 數據結構

```csharp
[System.Serializable]
public class CellData {
    public int x, y;
    public string element;
    public float temperature;
    public float mass;
}
```

## 導出方法

```csharp
string json = JsonUtility.ToJson(cellData);
```

## AI Prompt

```
請寫一個 C# 類來序列化《缺氧》的磁磚數據為 JSON，包含座標、元素、溫度、質量。
```
