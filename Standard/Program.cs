using System.Text.Json;
using Shared;

var runs = int.Parse(args[2]);

if (args[0] == "async")
{
	for (var i = 0; i < runs; i++)
		await JsonSerializer.DeserializeAsync<Root>(File.OpenRead(args[1]));
}
else
{
	for (var i = 0; i < runs; i++)
		JsonSerializer.Deserialize<Root>(File.ReadAllText(args[1]));
}