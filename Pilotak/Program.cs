using Pilotak;

List<Pilotaclass> pilotak = new List<Pilotaclass>();

StreamReader sr = new StreamReader("pilotak.csv", encoding:"UTF8");
sr.ReadLine();

while (!sr.EndOfStream)
{
    string[] adatok = sr.ReadLine().Split(";");
    pilotak.Add(new Pilotaclass(adatok[0], adatok[1], adatok[2], int.Parse(adatok[3])));
}
sr.Close();

Console.WriteLine($"3.feladat: {pilotak.Count()}");