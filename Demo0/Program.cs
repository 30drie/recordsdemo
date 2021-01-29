using System;

// Creating instances from Developer class

var developer = new Developer()
{
	Company = "Sharevalue",
	Profession = ".NET Developer",
	Name = "Michiel"
};

var newdeveloper = new Developer()
{
	Company = developer.Company,
	Profession = developer.Profession,
	Name = "Jasper"
};

Console.WriteLine(DeveloperString(developer));
Console.WriteLine(DeveloperString(newdeveloper));

Console.ReadLine();

static string DeveloperString(Developer dev)
{
	return $"Name: {dev.Name}, Company: {dev.Company}, Profession: {dev.Profession}";
}