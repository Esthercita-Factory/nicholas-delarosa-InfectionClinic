using InfectionClinic.Consol.Models;
using InfectionClinic.Consol.Repositories;

namespace InfectionClinic.Consol.UI;

public class ManagerPatients
{
    public static void CreatePatient()
    {
        Console.Write("Please, enter the patient's name: ");
        string name = Console.ReadLine();
        
        Console.Write("Please, enter the patient's age: ");
        int ageInYears = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Please, enter the patient's symptom: ");
        string symptom = Console.ReadLine();

        var newPatient = new Patient(name, ageInYears, symptom);
        
        PatientRepository.RegisterPatient(newPatient);
    }
    
    public static void GetPatients()
    {
        var patientFromDB = PatientRepository.ListPatients();

        foreach (var patient in patientFromDB)
        {
            Console.WriteLine(patient);
            Console.WriteLine("-----------");
        }
    }
    
    
}