using System;

// Creating instances from inherited record

var developer = new Developer("Michiel", "ShareValue", ".NET Developer");

var cl = new CompetenceLead(developer.Name, developer.Company, developer.Profession, ".NET");

Console.WriteLine(DeveloperString(developer));
Console.WriteLine(DeveloperString(cl));

Console.WriteLine($"developer == cl : {developer == cl}");
Console.WriteLine($"developer == (Developer)cl : {developer == (Developer)cl}");

Console.ReadLine();

static string DeveloperString(Developer dev)
{
	return $"HashCode: {dev.GetHashCode()}, Name: {dev.Name}, Company: {dev.Company}, Profession: {dev.Profession}";
}