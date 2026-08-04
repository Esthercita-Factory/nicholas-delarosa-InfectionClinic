namespace InfectionClinic.Consol.Models;

public class Pet
{
    public Guid Id { get; }
    public string Name { get; set; }
    public int AgeInMonths { get; set; }
    public string AppointmentType { get; set; }
    public string? Symptom  { get; set; }

    public Pet(string name, int ageInMonths, string appointmentType, string? symptom = null)
    {
        Id = Guid.NewGuid();
        Name = name.Trim().ToLower();
        AgeInMonths = ageInMonths;
        AppointmentType = appointmentType.Trim().ToLower();
        Symptom = symptom?.Trim().ToLower();
    }
    
    public void ShowDetails()
    {
        Console.WriteLine($@"Pet:
    Id: {Id}
    Name: {Name}
    Age: {AgeInMonths}
    Appointment Type: {AppointmentType}");
        if (Symptom != null)
        {
            Console.WriteLine($"Symptom: {Symptom}");
        }
    }
}