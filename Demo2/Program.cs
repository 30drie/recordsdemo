using System;

// Creating instances from Developer class and compare

var developer = new Developer()
{
	Company = "Sharevalue",
	Profession = ".NET Developer",
	Name = "Michiel"
};

var dev1 = new Developer()
{
	Company = developer.Company,
	Profession = developer.Profession,
	Name = "Jasper"
};

var dev2 = new Developer()
{
	Company = developer.Company,
	Profession = developer.Profession,
	Name = developer.Name
};

Console.WriteLine(DeveloperString(developer));
Console.WriteLine(DeveloperString(dev1));
Console.WriteLine(DeveloperString(dev2));

Console.WriteLine($"developer == dev1 : {developer == dev1}");
Console.WriteLine($"developer == dev2 : {developer == dev2}");

Console.ReadLine();

static string DeveloperString(Developer dev)
{
	return $"Name: {dev.Name}, Company: {dev.Company}, Profession: {dev.Profession}";
}