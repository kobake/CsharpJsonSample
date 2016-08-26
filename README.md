# CsharpJsonSample
JSON Serialize and Deserialize sample, implemented with [Json.NET](http://www.newtonsoft.com/json)

## 環境
- Visual Studio 2013 (C#)

## 概要
以下動作のサンプル
- C# オブジェクトを JSON テキストに変換
- JSON テキストを C# オブジェクトに変換

## 実行結果
```text
-------- normal json --------
[{"Id":1,"Name":"野望の王国 1","Asin":"B00M84FTOS"},{"Id":2,"Name":"アカギ 1","Asin":"B00DVYTZ12"}]

-------- formatted json --------
[
  {
    "Id": 1,
    "Name": "野望の王国 1",
    "Asin": "B00M84FTOS"
  },
  {
    "Id": 2,
    "Name": "アカギ 1",
    "Asin": "B00DVYTZ12"
  }
]

-------- parse json result --------
10, フェルマーの最終定理, 4102159711
20, 暗号解読, 410215972X
```
