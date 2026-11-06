using Ingatlanok;
if (!File.Exists("ingatlanok.txt"))
{
    Console.WriteLine($"A(z) {"ingatlanok.txt"} nem található!");
    return;
}
List<ingatlanok> ingatlan = new List<ingatlanok>();
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
    if (darab.Length == 4)
    {
        if (int.TryParse(darab[3],out int alapteruletM2))
        {
            ingatlan.Add(new ingatlanok(azonosito, cim, kategoria, alapteruletM2));

        }
        else
        {
            Console.WriteLine($"[HIBA] A(z) {azonosito} azonosítójú eszköz adatai hibásak, átugorva!");
        }
    }
    else if (darab.Length >= 5)
    {
        bool sikeresAlapteruletM2 = int.TryParse(darab[3], out int alapteruletM2);
        bool sikeresArEzerFt = int.TryParse(darab[4], out int arEzerFt);

        if (sikeresAlapteruletM2 && sikeresArEzerFt)
        {
            ingatlan.Add(new ingatlanok(azonosito, cim, kategoria, alapteruletM2, arEzerFt));
        }
        else
        {
            Console.WriteLine($"[HIBA] A(z) {azonosito} azonosítójú eszköz adatai hibásak, átugorva!");
        }
    }
}
foreach (var ingatlans in ingatlan)
{
    Console.WriteLine(ingatlans.ToString());
}
Console.WriteLine($"Regisztrált ingatlanok száma a rendszerben: {ingatlanok.OsszesRegisztraltIngatlan} db");
