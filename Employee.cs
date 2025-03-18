namespace CSHARP25031801;

class Employee
{
    public string Name { get; set; }
    public string Sex { get; set; }
    public string Department { get; set; }
    public int Entry { get; set; }
    public int Payment { get; set; }

    public override string ToString() =>
        $"\t Name: {Name}\n" +
        $"\t Sex: {Sex}\n" +
        $"\t Department: {Department}\n" +
        $"\t Entry: {Entry}\n" +
        $"\t Payment: {Payment:N0} HUF";

    public Employee(string row)
    {
        var v = row.Split(';');
        Name = v[0];
        Sex = v[1];
        Department = v[2];
        Entry = int.Parse(v[3]);
        Payment = int.Parse(v[4]);
    }

}
