using System;

// Creating instances from Developer record with short syntax

var developer = new Developer("Michiel", "ShareValue", ".NET Developer");

Console.WriteLine(DeveloperString(developer));

developer.Deconstruct(out string comp, out string prof, out string name);
Console.WriteLine($"Name: {name}, Company: {comp}, Profession: {prof}");

Console.ReadLine();

static string DeveloperString(Developer dev)
{
	return $"Name: {dev.Name}, Company: {dev.Company}, Profession: {dev.Profession}";
}

//How short?
public record Developer(string Company, string Profession, string Name);