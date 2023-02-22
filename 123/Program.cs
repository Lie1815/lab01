// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
String example = "Объект – категория, выражающая то, что противостоит субъекту в его предметно-практической и познавательной деятельности";

Console.WriteLine(Encoding.UTF8.GetByteCount(example));
Console.WriteLine(Encoding.UTF7.GetByteCount(example));
Console.WriteLine(Encoding.UTF32.GetByteCount(example));
Console.WriteLine(Encoding.ASCII.GetByteCount(example));
Console.WriteLine($"int {int.MinValue} {int.MaxValue} byte/s");
Console.WriteLine($"decimal {decimal.MinValue} {decimal.MaxValue} byte/s");
Console.WriteLine($"sbyte {sbyte.MinValue} {sbyte.MaxValue} byte/s");
Console.WriteLine($"uint {uint.MinValue} {uint.MaxValue} byte/s");
Console.WriteLine($" short {short.MinValue} {short.MaxValue} byte/s");
Console.WriteLine($" double {double.MinValue} {double.MaxValue} byte/s");
Console.WriteLine($"ushort {ushort.MinValue} {ushort.MaxValue} byte/s");
Console.WriteLine($" float {float.MinValue} {float.MaxValue} byte/s");
Console.WriteLine($" long {long.MinValue} {long.MaxValue} byte/s");
Console.WriteLine($" ulong {ulong.MinValue} {ulong.MaxValue} byte/s");


char maxValue = char.MaxValue;
string trueString = bool.TrueString;



