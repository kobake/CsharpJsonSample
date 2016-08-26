using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpJsonSample
{
	// Sample model
	class Book
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Asin { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			// 日本語ちゃんと出力されるようにしておく
			Console.OutputEncoding = new UTF8Encoding();

			// Sample: C# Object -> JSON Text
			ObjectToJson();

			// Sample: JSON TEXT -> C# Object
			JsonToObject();
		}

		static void ObjectToJson()
		{
			// せっかくだからリスト構造を作ってみる
			List<Book> books = new List<Book>
			{
				new Book{ Id = 1, Name = "野望の王国 1", Asin = "B00M84FTOS"},
				new Book{ Id = 2, Name = "アカギ 1", Asin = "B00DVYTZ12"},
			};

			// 普通の JSON テキスト構築
			Console.WriteLine("-------- normal json --------");
			string jsonString = JsonConvert.SerializeObject(books);
			Console.WriteLine(jsonString);

			// インデント付きの JSON テキスト構築
			Console.WriteLine("\n-------- formatted json --------");
			string formattedJson = JsonConvert.SerializeObject(books, Formatting.Indented);
			Console.WriteLine(formattedJson);
		}

		static void JsonToObject()
		{
			// JSON テキストのサンプル (書式はあえて適当に崩した)
			string jsonSample = @"[
				{ ""Id"": 10, ""Name"": ""フェルマーの最終定理"", ""Asin"": ""4102159711"" },
				{
				""Asin"": ""410215972X"",
				""Name"" : ""暗号解読"", ""Id"": 20
				}
			]";

			// JSON テキストから C# オブジェクトを構築
			List<Book> booksByJson = JsonConvert.DeserializeObject<List<Book>>(jsonSample);

			// 結果確認用出力
			Console.WriteLine("\n-------- parse json result --------");
			booksByJson.ForEach((book) =>
			{
				Console.WriteLine(book.Id + ", " + book.Name + ", " + book.Asin);
			});
		}
	}
}
