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


System.Console.Write("What was the total trip in miles? ");
int totalTripMiles = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine();


System.Console.Write("How many MPG does your car get? ");
int milesPerGallon = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine();


System.Console.Write("How much does gas cost in your area. (price per gallon please!) ");
double gasCost = Convert.ToDouble (Console.ReadLine());
System.Console.WriteLine();


double gallonsNeeded = totalTripMiles / (double)milesPerGallon;
double fuelCost = gallonsNeeded * (double)gasCost;
System.Console.WriteLine($"Gallons needed: {gallonsNeeded.ToString("F2")}");
System.Console.WriteLine();


System.Console.WriteLine($"Fuel cost: {fuelCost.ToString("C")}");
System.Console.WriteLine();
/*
Pizza party: This calculates how many slices there will be, how many each person will get, and the total cost of all pizzas.
*/
System.Console.Write("How many people will be going? ");
int peopleGoing = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine();


System.Console.Write("How many pizzas do you need? ");
int pizzaNeeded = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine();


System.Console.Write("How much does each pizza cost? ");
double perPizzaCost = Convert.ToDouble (Console.ReadLine());
System.Console.WriteLine();


const int PizzaSlices = 8;
int totalSlices = pizzaNeeded * PizzaSlices;
double slicesPerPerson = totalSlices / (double) peopleGoing;
double pizzaCost = pizzaNeeded * (double) perPizzaCost;
System.Console.WriteLine($"Total slices: {totalSlices}");
System.Console.WriteLine();


System.Console.WriteLine($"Slices per person: {slicesPerPerson.ToString("F1")}");
System.Console.WriteLine();


System.Console.WriteLine($"Pizza cost: {pizzaCost.ToString("C")}");
System.Console.WriteLine();


/*
Payday: This calculates your gross pay, your tax withheld, and your take home pay. This is like a check stub.
*/
System.Console.Write("How many hours have you worked this week? (Whole number please!) ");
int hoursWorked = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine();


System.Console.Write("How much do you make per hour? ");
double hourlyRate = Convert.ToDouble (Console.ReadLine());
System.Console.WriteLine();


const double taxRate = 0.18;
double grossPay = hoursWorked * hourlyRate;
double taxWithheld = grossPay * taxRate;
double takeHome = grossPay - taxWithheld;
System.Console.WriteLine($"Gross pay: {grossPay.ToString("C")}");
System.Console.WriteLine();


System.Console.WriteLine($"Tax withheld: {taxWithheld.ToString("C")}");
System.Console.WriteLine();


System.Console.WriteLine($"Take home pay: {takeHome.ToString("C")}");
System.Console.WriteLine();
/*
The whole thing: This calculates information about your whole trip, including the total trip cost, the per person cost, how much money you actualy get per hour, and the hours you need to work to cover your share of the trip.
*/
double tripTotal = fuelCost + pizzaCost;
double costPerPerson = tripTotal / peopleGoing;
double takeHomePayPerHour = takeHome / hoursWorked;
double hoursNeeded = costPerPerson / takeHomePayPerHour;
System.Console.WriteLine($"Trip total: {tripTotal.ToString("C")}");
System.Console.WriteLine();


System.Console.WriteLine($"Cost per person: {costPerPerson.ToString("C")}");
System.Console.WriteLine();


System.Console.WriteLine($"Take home pay per hour: {takeHomePayPerHour.ToString("C")}");
System.Console.WriteLine();


System.Console.WriteLine($"Hours you must work to cover your share: {hoursNeeded.ToString("F2")}");
System.Console.WriteLine("");
System.Console.WriteLine("");


System.Console.WriteLine("=== Part 1: Road Trip ===");
System.Console.WriteLine("Round trip miles: " + totalTripMiles );
System.Console.WriteLine($"Miles per gallon: {milesPerGallon}");
System.Console.WriteLine($"Price per gallon: {gasCost}");
System.Console.WriteLine("");
System.Console.WriteLine("");


System.Console.WriteLine($"Gallons needed: {gallonsNeeded.ToString("F2")}");
System.Console.WriteLine($"Fuel cost: {fuelCost.ToString("C")}");
System.Console.WriteLine("");
System.Console.WriteLine("");


System.Console.WriteLine("=== Part 2: Pizza Party ===");
System.Console.WriteLine($"How many people are going: {peopleGoing}");
System.Console.WriteLine($"How man pizzas: {pizzaNeeded}");
System.Console.WriteLine($"Price per pizza: {perPizzaCost.ToString("C")}");
System.Console.WriteLine("");
System.Console.WriteLine("");


System.Console.WriteLine($"Total slices: {totalSlices}");
System.Console.WriteLine($"Slices per person: {slicesPerPerson.ToString("F1")}");
System.Console.WriteLine($"Pizza cost: {pizzaCost.ToString("C")}");
System.Console.WriteLine("");
System.Console.WriteLine("");


System.Console.WriteLine("=== Part 3: Paycheck ===");
System.Console.WriteLine($"Hours worked this week: {hoursWorked}");
System.Console.WriteLine($"Hourly rate: {hourlyRate.ToString("F2")}");
System.Console.WriteLine("");
System.Console.WriteLine("");


System.Console.WriteLine($"Gross pay: {grossPay.ToString("C")}");
System.Console.WriteLine($"Tax withheld: {taxWithheld.ToString("C")}");
System.Console.WriteLine($"Take home pay: {takeHome.ToString("C")}");
System.Console.WriteLine("");
System.Console.WriteLine("");


System.Console.WriteLine("=== Part 4: The Whole Trip ===");
System.Console.WriteLine($"Trip total: {tripTotal.ToString("C")}");
System.Console.WriteLine($"Cost per person {costPerPerson.ToString("C")}");
System.Console.WriteLine($"Take home pay per hour: {takeHomePayPerHour.ToString("C")}");
System.Console.WriteLine($"Hours you must work to cover your share: {hoursNeeded.ToString("F2")}");