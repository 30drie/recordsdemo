using System;

// Creating instances from Developer record with constructor

var developer = new Developer("Michiel", "ShareValue", ".NET Developer");

Console.WriteLine(DeveloperString(developer));

Console.ReadLine();

static string DeveloperString(Developer dev)
{
	return $"Name: {dev.Name}, Company: {dev.Company}, Profession: {dev.Profession}";
}