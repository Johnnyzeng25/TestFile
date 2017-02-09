using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopyPlanet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tryAnother = false;

            do
            {



                Console.Clear();    //  To clean up previous result after a loop

                Console.WriteLine("         Menu of Planets          ");
                Console.WriteLine("         ==== == =======          ");
                Console.WriteLine("1. Jupiter   2. Mars     3. Mercury");
                Console.WriteLine("4. Neptune   5. Pluto    6. Saturn");
                Console.WriteLine("7. Uranus    8. Venus    9. <Quit>");
                Console.WriteLine();

                Console.Write("Enter your menu choice: ");
                int userOption = int.Parse(Console.ReadLine()); //Program could still run without converting this into a numeric value, but this could prevent "next step" happening when no planet is being selected
                double gravityRatio = 0;    //Preset a variable here could prevent writing calculation(gravity conversion) for every case
                String planetName = "";     //Same for this one

                switch (userOption) //One of the case from below would be activated as long as the input value is a number
                {
                    case 1:
                        gravityRatio = 2.64;
                        planetName = "Jupiter";
                        break;
                    case 2:
                        gravityRatio = 0.38;
                        planetName = "Mars";
                        break;
                    case 3:
                        gravityRatio = 0.37;
                        planetName = "Mercury";
                        break;
                    case 4:
                        gravityRatio = 1.12;
                        planetName = "Neptune";
                        break;
                    case 5:
                        gravityRatio = 0.04;
                        planetName = "Pluto";
                        break;
                    case 6:
                        gravityRatio = 1.15;
                        planetName = "Saturn";
                        break;
                    case 7:
                        gravityRatio = 1.15;
                        planetName = "Uranus";
                        break;
                    case 8:
                        gravityRatio = 0.88;
                        planetName = "Venus";
                        break;
                    case 9:
                        Console.WriteLine("\nHave a great day! Goodbye!");
                        break;
                    default:
                        tryAnother = true;  // program resets if the value of option is > 9 (When none of the planets was being selected)
                        break;
                }

                if (userOption < 9) //In order to do the calculation, one of the planet has to be selected first
                {
                    Console.Write("Enter your weight on Earth: ");
                    double userWeight = double.Parse(Console.ReadLine());   //This line is where user inputs their weight, since text value could not be calculated, a conversion into numeric value is a must!
                    double result = userWeight * gravityRatio;  //Calculation for weight on other planet
                    double roundResult = Math.Round(result, 1); //Round up to one decimal
                    Console.WriteLine("Your weight of " + userWeight + " pounds on Earth would be " + roundResult + " on " + planetName);    // Just a combination of text and numeric values that correlates to different planet

                    Console.WriteLine("\nWould you want to try another planet? (Y/N)");

                    string againOption = Console.ReadLine();    //prompt user if they want to try another one
                    if (againOption.Equals("y"))    //assign character y to true (try another/again)
                    {
                        tryAnother = true;  // This activates the loop
                    }
                    else if (againOption.Equals("n"))
                    {
                        tryAnother = false;
                    }
                }
            } while (tryAnother == true);   //Loop whenever tryAnother is true
 

        }
    }
}
