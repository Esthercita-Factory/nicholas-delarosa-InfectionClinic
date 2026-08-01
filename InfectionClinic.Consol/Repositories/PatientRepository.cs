using InfectionClinic.Consol.Models;

namespace InfectionClinic.Consol.Repositories;

public class PatientRepository
{
    public static List<Patient> PatientWarehouse { get; set; }

    public PatientRepository()
    { 
        PatientWarehouse =
        [
            new Patient("Alice Johnson", 28, "Headache"),
            new Patient("Brian Smith", 45, "Fever"),
            new Patient("Catherine Lee", 34, "Cough"),
            new Patient("Daniel Brown", 52, "Chest Pain"),
            new Patient("Emma Davis", 19, "Sore Throat"),
            new Patient("Frank Wilson", 61, "Back Pain"),
            new Patient("Grace Taylor", 40, "Dizziness"),
            new Patient("Henry Moore", 73, "Shortness of Breath"),
            new Patient("Isabella Thomas", 31, "Nausea"),
            new Patient("Jack Anderson", 26, "Stomach Ache"),
            new Patient("Karen Martin", 58, "High Blood Pressure"),
            new Patient("Liam White", 14, "Ear Infection"),
            new Patient("Mia Harris", 22, "Allergic Reaction"),
            new Patient("Noah Clark", 37, "Migraine"),
            new Patient("Olivia Lewis", 49, "Joint Pain"),
            new Patient("Paul Walker", 65, "Fatigue"),
            new Patient("Quinn Hall", 33, "Skin Rash"),
            new Patient("Rachel Allen", 55, "Diarrhea"),
            new Patient("Samuel Young", 47, "Vomiting"),
            new Patient("Sophia King", 29, "Anxiety")
        ];
    }
    
    // Create
    public static void RegisterPatient(Patient patient)
    {
        PatientWarehouse.Add(patient);
    }
    
    // Read
    public static List<Patient> ListPatients()
    {
        return PatientWarehouse;
    }

    
}