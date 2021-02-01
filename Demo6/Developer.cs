public record Developer
{
	public string Company { get; init; }
	public string Profession { get; init; }
	public string Name { get; init; }

	public Developer(string name, string comp, string prof) => 
		(Company, Profession, Name) = (comp, prof, name);

	public void Deconstruct(out string name, out string comp, out string prof) =>
		(comp, prof, name) = (Company, Profession, Name);
}

public record CompetenceLead : Developer
{
	public string Competence { get; init; }

	public CompetenceLead(string name, string company, string prof, string competence) : base(name, company, prof) => Competence = competence;

}