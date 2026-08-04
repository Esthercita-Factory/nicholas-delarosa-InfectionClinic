using InfectionClinic.Consol.UI;

Console.WriteLine("Hello, World!");

ManagerUsers.ShowMenu();

string option = Console.ReadLine();

switch (option)
{
    case "1":
        ManagerPets.CreatePet();
        break;
    case "2":
        ManagerPets.GetPets();
        break;
    default:
        Console.WriteLine("Invalid option");
        break;
}