using System.Text.Json;
using System.Text.Json.Serialization;
using Shared;

var runs = int.Parse(args[2]);

if (args[0] == "async")
{
	for (var i = 0; i < runs; i++)
		await JsonSerializer.DeserializeAsync(File.OpenRead(args[1]), RootContext.Default.Root);
}
else
{
	for (var i = 0; i < runs; i++)
		JsonSerializer.Deserialize(File.ReadAllText(args[1]), RootContext.Default.Root);
}

[JsonSerializable(typeof(Root), GenerationMode = JsonSourceGenerationMode.Metadata)]
internal partial class RootContext : JsonSerializerContext
{
}