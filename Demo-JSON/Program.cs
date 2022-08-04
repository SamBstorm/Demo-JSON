using Demo_JSON;
using System.Text.Json;

string message = "Hello world!";
object objetRandom = new { Id = 1, Name = "Samuel", Mail = "info@test.com" };
int[] ints = new int[] { 1, 2, 3 };
object? nullAbsolu = null; 
Dictionary<string, string> dic = new Dictionary<string, string>();
dic.Add("zero", "Toto");
dic.Add("un", "Titi");
dic.Add("deux", "Tutu");
dic.Add("trois", "Tata");

FauxDictionnaire fauxDictionnaire = new FauxDictionnaire() { zero = "Toto", un="Titi", deux="Tutu", trois="Tata" };



Console.WriteLine(JsonSerializer.Serialize(message));
Console.WriteLine(JsonSerializer.Serialize(objetRandom));
Console.WriteLine(JsonSerializer.Serialize(ints));
Console.WriteLine(JsonSerializer.Serialize(nullAbsolu));
Console.WriteLine(JsonSerializer.Serialize(dic));
Console.WriteLine(JsonSerializer.Serialize(fauxDictionnaire));

string json = JsonSerializer.Serialize(dic);

fauxDictionnaire = JsonSerializer.Deserialize<FauxDictionnaire>(json);
Console.WriteLine();


object inconnu = JsonSerializer.Deserialize<FauxDictionnaire>("null");
Console.WriteLine();