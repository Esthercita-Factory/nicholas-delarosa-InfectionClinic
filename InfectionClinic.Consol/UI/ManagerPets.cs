using InfectionClinic.Consol.Models;
using InfectionClinic.Consol.Repositories;

namespace InfectionClinic.Consol.UI;

public class ManagerPets
{
    public static void CreatePet()
    {
        Console.Write("Please, enter the pet's name: ");
        string name = Console.ReadLine();
        
        Console.Write("Please, enter the pet's age: ");
        int ageInMonths = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Please, enter the appointment type: ");
        string appointmentType = Console.ReadLine();
        
        Console.Write("Do the pet have symptoms?\ny or n");
        string askSymptom = Console.ReadLine();

        string symptom = "None";
        
        if (askSymptom.Trim().ToLower() == "y")
        {
            Console.Write("Please, enter the pet's symptom: ");
            symptom = Console.ReadLine();
        }

        var newPatient = new Pet(name, ageInMonths, appointmentType, symptom);
        
        PetRepository.RegisterPet(newPatient);
    }
    
    public static void GetPets()
    {
        var petFromDb = PetRepository.ListPet();

        foreach (var pet in petFromDb)
        {
            pet.ShowDetails();
            Console.WriteLine("-----------");
        }
    }
    
    
}