using Pilotak;

List<Pilotaclass> pilotak = new List<Pilotaclass>();

StreamReader sr = new StreamReader("pilotak.csv");
sr.ReadLine();

while (!sr.EndOfStream)
{
    string[] adatok = sr.ReadLine().Split(";");
    if (adatok[3]=="")
    {
        pilotak.Add(new Pilotaclass(adatok[0], adatok[1], adatok[2], -1));
    }
    else
    {
        pilotak.Add(new Pilotaclass(adatok[0], adatok[1], adatok[2], int.Parse(adatok[3])));
    }
    
}
sr.Close();

Console.WriteLine($"3.feladat: {pilotak.Count()}");

Console.WriteLine($"4.feladat: {pilotak.Last().Nev}");

Console.WriteLine("5.feladat:");
foreach (var pilota in pilotak)
{
    string[] datumsplit = pilota.Szuletesidatum.Split(".");
    if (1901>int.Parse(datumsplit[0]))
    {
        Console.WriteLine($"\t{pilota.Nev} ({pilota.Szuletesidatum})");
    }
}



Console.WriteLine($"6.feladat: {pilotak.Last().Nev}");



