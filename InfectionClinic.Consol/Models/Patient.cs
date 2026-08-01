namespace InfectionClinic.Consol.Models;

public class Patient
{
    public Guid Id { get; }
    public string Name { get; set; }
    public int AgeInYears { get; set; }
    public string Symptom  { get; set; }

    public Patient(string name, int ageInYears, string symptom)
    {
        Id = Guid.NewGuid();
        Name = name.Trim().ToLower();
        AgeInYears = ageInYears;
        Symptom = symptom.Trim().ToLower();
    }
    
    public override string ToString()
    {
        return $"Patient(Id: {Id}, Name: {Name}, Age: {AgeInYears}, Symptom: {Symptom})";
    }
}