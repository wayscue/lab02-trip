/*
* Name: William Ayscue
* Course: CSCI 1250, Section 001
* Assignment: Lab 02, Trip Calculator
* Date: September 23, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/
/*
Trip information: This calculates how many gallons of gas are needed, and the total fuel cost.
*/
using System.Runtime.ConstrainedExecution;

System.Console.Write("What was the total trip in miles? ");
System.Console.WriteLine("");
int TotalTripMiles = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("How many MPG does your car get? ");
System.Console.WriteLine();
int MilesPerGallon = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("How much does gas cost in your area. (price per gallon please!) ");
System.Console.WriteLine();
double GasCost = Convert.ToDouble (Console.ReadLine());
System.Console.WriteLine();
double GallonsNeeded = TotalTripMiles / (double)MilesPerGallon;
double FuelCost = GallonsNeeded * (double)GasCost;
System.Console.WriteLine($"Gallons needed: {GallonsNeeded.ToString("F2")}");
System.Console.WriteLine();
System.Console.WriteLine($"Fuel cost: {FuelCost.ToString("C")}");
/*
Pizza party: This calculates how many slices there will be, how many each person will get, and the total cost of all pizzas.
*/
System.Console.Write("How many people will be going? ");
System.Console.WriteLine();
int PeopleGoing = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("How many pizzas do you need? ");
System.Console.WriteLine();
int PizzaNeeded = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("How much does each pizza cost? ");
System.Console.WriteLine();
double PerPizzaCost = Convert.ToDouble (Console.ReadLine());
System.Console.WriteLine();
const int PizzaSlices = 8;
int TotalSlices = PizzaNeeded * PizzaSlices;
double SLicesPerPerson = TotalSlices / (double) PeopleGoing;
double PizzaCost = PizzaNeeded * (double) PerPizzaCost;
System.Console.WriteLine($"Total slices: {TotalSlices}");
System.Console.WriteLine();
System.Console.WriteLine($"Slices per person: {SLicesPerPerson.ToString("F1")}");
System.Console.WriteLine();
System.Console.WriteLine($"Pizza cost: {PizzaCost.ToString("C")}");
/*
Payday: This calculates your gross pay, your tax withheld, and your take home pay. This is like a check stub.
*/
System.Console.Write("How many hours have you worked this week? (Whole number please!) ");
System.Console.WriteLine();
int HoursWorked = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("How much do you make per hour? ");
System.Console.WriteLine();
double HourlyRate = Convert.ToDouble (Console.ReadLine());
System.Console.WriteLine();
const double TaxRate = 0.18;
double GrossPay = HoursWorked * HourlyRate;
double TaxWithheld = GrossPay * TaxRate;
double TakeHome = GrossPay - TaxWithheld;
System.Console.WriteLine($"Gross pay: {GrossPay.ToString("C")}");
System.Console.WriteLine();
System.Console.WriteLine($"Tax withheld: {TaxWithheld.ToString("C")}");
System.Console.WriteLine();
System.Console.WriteLine($"Take home pay: {TakeHome.ToString("C")}");
System.Console.WriteLine();
/*
The whole thing: This calculates information about your whole trip, including the total trip cost, the per person cost, how much money you actualy get per hour, and the hours you need to work to cover your share of the trip.
*/
double TripTotal = FuelCost + PizzaCost;
double CostPerPerson = TripTotal / PeopleGoing;
double TakeHomePayPerHour = TakeHome / HoursWorked;
double HoursNeeded = CostPerPerson / TakeHomePayPerHour;
System.Console.WriteLine($"Trip total: {TripTotal.ToString("C")}");
System.Console.WriteLine();
System.Console.WriteLine($"Cost per person: {CostPerPerson.ToString("C")}");
System.Console.WriteLine();
System.Console.WriteLine($"Take home pay per hour: {TakeHomePayPerHour.ToString("C")}");
System.Console.WriteLine();
System.Console.WriteLine($"Hours you must work to cover your share: {HoursNeeded.ToString("F2")}");
System.Console.WriteLine("");
System.Console.WriteLine("");
System.Console.WriteLine("=== Part 1: Road Trip ===");
System.Console.WriteLine("Round trip miles: " + TotalTripMiles );
System.Console.WriteLine($"Miles per gallon: {MilesPerGallon}");
System.Console.WriteLine($"Price per gallon: {GasCost}");
System.Console.WriteLine("");
System.Console.WriteLine("");
System.Console.WriteLine($"Gallons needed: {GallonsNeeded.ToString("F2")}");
System.Console.WriteLine($"Fuel cost: {FuelCost.ToString("C")}");
System.Console.WriteLine("");
System.Console.WriteLine("");
System.Console.WriteLine("=== Part 2: Pizza Party ===");
System.Console.WriteLine($"How many people are going: {PeopleGoing}");
System.Console.WriteLine($"How man pizzas: {PizzaNeeded}");
System.Console.WriteLine($"Price per pizza: {PerPizzaCost.ToString("C")}");
System.Console.WriteLine("");
System.Console.WriteLine("");
System.Console.WriteLine($"Total slices: {TotalSlices}");
System.Console.WriteLine($"Slices per person: {SLicesPerPerson.ToString("F1")}");
System.Console.WriteLine($"Pizza cost: {PizzaCost.ToString("C")}");
System.Console.WriteLine("");
System.Console.WriteLine("");
System.Console.WriteLine("=== Part 3: Paycheck ===");
System.Console.WriteLine($"Hours worked this week: {HoursWorked}");
System.Console.WriteLine($"Hourly rate: {HourlyRate}");
System.Console.WriteLine("");
System.Console.WriteLine("");
System.Console.WriteLine($"Gross pay: {GrossPay.ToString("C")}");
System.Console.WriteLine($"Tax withheld: {TaxWithheld.ToString("C")}");
System.Console.WriteLine($"Take home pay: {TakeHome.ToString("C")}");
System.Console.WriteLine("");
System.Console.WriteLine("");
System.Console.WriteLine("=== Part 4: The Whole Trip ===");
System.Console.WriteLine($"Trip total: {TripTotal.ToString("C")}");
System.Console.WriteLine($"Cost per person {CostPerPerson.ToString("C")}");
System.Console.WriteLine($"Take home pay per hour: {TakeHomePayPerHour.ToString("C")}");
System.Console.WriteLine($"Hours you must work to cover your share: {HoursNeeded.ToString("F2")}");