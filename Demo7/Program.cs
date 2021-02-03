using System;

// Creating instances from Developer record

var developer = new Developer()
{
	Company = "Sharevalue",
	Profession = ".NET Developer",
	Name = "Michiel"
};

var newdeveloper = developer with { Name = "Jasper" };
newdeveloper.Profession = "Competence Lead";

Console.WriteLine(DeveloperString(developer));
Console.WriteLine(DeveloperString(newdeveloper));

Console.ReadLine();

static string DeveloperString(Developer dev)
{
	return $"HashCode: {dev.GetHashCode()}, Name: {dev.Name}, Company: {dev.Company}, Profession: {dev.Profession}";
}