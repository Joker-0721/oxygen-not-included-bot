# Goal 08: Python 控制客戶端

Python 端的 Socket 通信客戶端。

## UDP 客戶端

```python
import socket

sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
sock.bind(('localhost', 8888))
```

## 接收與響應

```python
data, addr = sock.recvfrom(1024)
if oxygen_pressure < 500:
    sock.sendto(b'BUILD_ALGAE_TERRARIUM', addr)
```

## AI Prompt

```
寫一個 Python UDP 客戶端，接收遊戲數據並根據氧氣含量返回指令。
```
