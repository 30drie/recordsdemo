public record Developer
{
	public string Company { get; init; }
	public string Profession { get; init; }
	public string Name { get; init; }

	public Developer(string name, string comp, string prof) => 
		(Company, Profession, Name) = (comp, prof, name);
}
