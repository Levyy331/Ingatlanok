using Ingatlanok;
if (!File.Exists("ingatlanok.txt"))
{
    Console.WriteLine($"A(z) {"ingatlanok.txt"} nem található!");
    return;
}
List<ingatlanok> eszkozok = new List<ingatlanok>();
string[] sorok = File.ReadAllLines("ingatlanok.txt");
foreach (string sor in sorok)
{
    if (string.IsNullOrWhiteSpace(sor))
    {
        continue;
    }
    string[] darab = sor.Split(';');
    if (darab.Length < 4)
    {
        continue;
    }
    string azonosito = darab[0];
    string cim = darab[1];
    string kategoria = darab[2];
}
