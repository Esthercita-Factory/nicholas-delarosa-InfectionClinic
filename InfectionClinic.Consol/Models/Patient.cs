namespace InfectionClinic.Consol.Models;

public class Patient
{
    private static int _nextId = 0;
    
    public int Id { get; }
    public string Name { get; set; }
    public int AgeInYears { get; set; }
    public string Symptom  { get; set; }

    public Patient(string name, int ageInYears, string symptom)
    {
        Id = Interlocked.Increment(ref _nextId);
        Name = name;
        AgeInYears = ageInYears;
        Symptom = symptom;
    }
    
    public override string ToString()
    {
        return $"Patient(Id: {Id}, Name: {Name}, Age: {AgeInYears}, Symptom: {Symptom})";
    }
}