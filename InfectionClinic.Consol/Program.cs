using InfectionClinic.Consol.UI;

Console.WriteLine("Hello, World!");

ManagerUsers.ShowMenu();

string option = Console.ReadLine();

switch (option)
{
    case "1":
        ManagerPatients.CreatePatient();
        break;
    case "2":
        ManagerPatients.GetPatients();
        break;
    default:
        Console.WriteLine("Invalid option");
        break;
}