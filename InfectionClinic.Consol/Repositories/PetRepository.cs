using InfectionClinic.Consol.Models;

namespace InfectionClinic.Consol.Repositories;

public class PetRepository
{
    public static List<Pet> PetWarehouse { get; set; }

    public PetRepository()
    { 
        PetWarehouse =
        [
            new Pet("Max", 24, "Checkup"),
            new Pet("Bella", 18, "Vaccination"),
            new Pet("Charlie", 36, "Surgery", "Limping"),
            new Pet("Lucy", 12, "Checkup"),
            new Pet("Rocky", 48, "Dental Cleaning", "Bad breath"),
            new Pet("Luna", 8, "Vaccination"),
            new Pet("Cooper", 30, "Checkup", "Loss of appetite"),
            new Pet("Daisy", 20, "Grooming"),
            new Pet("Milo", 15, "Emergency", "Vomiting"),
            new Pet("Lola", 60, "Checkup", "Arthritis"),
            new Pet("Buddy", 10, "Vaccination"),
            new Pet("Sadie", 42, "Surgery", "Skin lump"),
            new Pet("Bear", 28, "Dental Cleaning"),
            new Pet("Chloe", 14, "Checkup", "Ear infection"),
            new Pet("Duke", 54, "Emergency", "Difficulty breathing"),
            new Pet("Zoey", 6, "Vaccination"),
            new Pet("Toby", 33, "Checkup"),
            new Pet("Nala", 22, "Grooming", "Excessive shedding"),
            new Pet("Oscar", 40, "Dental Cleaning", "Broken tooth"),
            new Pet("Ruby", 16, "Checkup")
        ];
    }
    
    // Create
    public static void RegisterPet(Pet pet)
    {
        PetWarehouse.Add(pet);
    }
    
    // Read
    public static List<Pet> ListPet()
    {
        return PetWarehouse;
    }
}