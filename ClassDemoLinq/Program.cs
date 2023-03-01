// See https://aka.ms/new-console-template for more information


using ClassDemoLinq.model;

List<Person> personer = new List<Person>()
{
    new Person("Peter", 22, "Roskilde"),
    new Person("Anders", 23, "Roskilde"),
    new Person("Henrik", 26, "Roskilde"),
    new Person("Ivan", 27,"Roskilde"),
    new Person("Vibeke", 21, "Roskilde"),
    new Person("Per", 22, "København"),
    new Person("Jakob", 23, "København"),
    new Person("Peter", 26, "København"),
    new Person("Jakob", 24, "København"),
    new Person("Jamshid", 23, "København"),
    new Person("Vibeke", 22, "København"),
    new Person("Ivan", 20, "København"),
    new Person("Henrik", 24, "København"),
    new Person("Per", 23, "København"),
    new Person("Jakob", 26, "Holbæk"),
    new Person("Peter", 24, "Holbæk"),
    new Person("Jakob", 25, "Holbæk"),
    new Person("Vibeke", 22, "Holbæk"),
    new Person("Henrik", 21, "Holbæk"),
    new Person("Peter", 23, "Holbæk"),
    new Person("Anders", 21, "Holbæk"),
    new Person("Per", 24, "Holbæk"),
    new Person("Vibeke", 26, "Greve"),
    new Person("Henrik", 28, "Greve"),
    new Person("Anders", 20, "Greve"),
    new Person("Henrik", 23, "Greve"),
    new Person("Ivan", 24, "Greve"),
    new Person("Vibeke", 26, "Greve"),
    new Person("Per", 25, "Roskilde"),
    new Person("Peter", 27, "Roskilde"),
};


PersonRepository repo = new PersonRepository(personer);
Console.WriteLine();
Console.WriteLine("===== Max =====");
Console.WriteLine();
Console.WriteLine(repo.MaxAge());
Console.WriteLine("Linq");
Console.WriteLine(personer.Max(p => p.Age));


Console.WriteLine();
Console.WriteLine("===== Min =====");
Console.WriteLine();
Console.WriteLine(repo.MinAge());
Console.WriteLine("Linq");
Console.WriteLine(personer.Min(p => p.Age));


Console.WriteLine();
Console.WriteLine("===== gns =====");
Console.WriteLine();
Console.WriteLine(repo.GnsAge());
Console.WriteLine("Linq");
Console.WriteLine(personer.Average(p => p.Age));


Console.WriteLine();
Console.WriteLine("===== Get All From Holbæk =====");
Console.WriteLine();
foreach (Person p in repo.GetAllFrom("Holbæk"))
{
    Console.WriteLine(p);
}
Console.WriteLine("Linq");
foreach (Person p in personer.Where(p => p.City == "Holbæk").OrderBy(p => p.Name))
{
    Console.WriteLine(p);
}




Console.WriteLine();
Console.WriteLine("===== Get All With Name Vibeke =====");
Console.WriteLine();
foreach (Person p in repo.GetAllName("Vibeke"))
{
    Console.WriteLine(p);
}
Console.WriteLine("Linq");
foreach (Person p in personer.Where(p => p.Name == "Vibeke"))
{
    Console.WriteLine(p);
}


Console.WriteLine();
Console.WriteLine("===== Get All From Holbæk older than 23 =====");
Console.WriteLine();
foreach (Person p in repo.GetAllFromAndOlderThan("Holbæk", 23))
{
    Console.WriteLine(p);
}
Console.WriteLine("Linq");
foreach (Person p in personer.Where(p => p.City == "Holbæk" && p.Age > 23))
{
    Console.WriteLine(p);
}