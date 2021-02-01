using System;

// Creating instances from Developer record and compare

var developer = new Developer()
{
	Company = "Sharevalue",
	Profession = ".NET Developer",
	Name = "Michiel"
};

var dev1 = developer with { Name = "Jasper" };
var dev2 = dev1 with { Name = "Michiel" };

Console.WriteLine(DeveloperString(developer));
Console.WriteLine(DeveloperString(dev1));
Console.WriteLine(DeveloperString(dev2));

Console.WriteLine($"developer == dev1 : {developer == dev1}");
Console.WriteLine($"developer == dev2 : {developer == dev2}");

Console.ReadLine();

static string DeveloperString(Developer dev)
{
	return $"HashCode: {dev.GetHashCode()}, Name: {dev.Name}, Company: {dev.Company}, Profession: {dev.Profession}";
}