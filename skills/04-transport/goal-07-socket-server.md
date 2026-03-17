# Goal 07: C# Socket 服務器

遊戲模組端的 Socket 通信服務器。

## UDP 服務器

```csharp
using System.Net;
using System.Net.Sockets;

UdpClient server = new UdpClient(8888);
IPEndPoint remote = new IPEndPoint(IPAddress.Any, 0);
```

## 發送數據

```csharp
byte[] data = Encoding.UTF8.GetBytes(json);
server.Send(data, data.Length, remote);
```

## AI Prompt

```
寫一個 C# UDP 服務器，每秒發送遊戲數據到客戶端。
```
