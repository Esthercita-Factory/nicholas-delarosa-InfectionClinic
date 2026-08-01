using InfectionClinic.Consol.Models;

Console.WriteLine("Hi, InfectionClinic!");

Console.WriteLine("Enter the next data:");
Console.Write("Name: ");
var name = Console.ReadLine();
Console.Write("Age: ");
var age = int.Parse(Console.ReadLine());
Console.Write("Symptom: ");
var symptom = Console.ReadLine();

var newPatient = new Patient(name, age, symptom);

Console.WriteLine(newPatient);