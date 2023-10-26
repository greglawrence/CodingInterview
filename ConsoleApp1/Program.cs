using NumberTextService;

var generator = new NumberTextGenerator();
//generator.Generate(100);
Dictionary<short, string> generatorDictionary = new()
{
    {0, "test a Zero"},
    {3, "Greg" },
    {5, "Test"},
    {10, "Ten"},
    {500, "Lawrence"}
};

var strings = generator.GetStringArray(200, generatorDictionary);
foreach (var s in strings)
{
    Console.WriteLine(s);
}
