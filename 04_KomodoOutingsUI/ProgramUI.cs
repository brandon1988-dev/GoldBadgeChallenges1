using _04_KomodoOutings.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_KomodoOutingsUI
{
    class ProgramUI
    {
        private readonly OutingRepository _oRepo = new OutingRepository();

        public void Run()
        {
            Seed();
            ShowMenu();

        }

            private void ShowMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine(
                    "Enter the option you'd like to select:\n" +
                    "1. See All Outings\n" +
                    "2. Add Outing\n" +
                    "3. Combined Outing Costs\n" +
                    "4. Individual Outing Costs\n" +
                    "5. Exit\n");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        GetContents();
                        break;
                    case "2":
                        AddNewOuting();
                        break;
                    case "3":
                        GetTotalCostOfOuting();
                        break;
                    case "4":
                        GetToalCostOfOutingPerEvent();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a number between 1 and 5");
                        WaitForKeyPress();
                        break;
                }
            }
        }

        private void GetToalCostOfOutingPerEvent()
        {
            Console.Clear();
            Console.WriteLine("Cost Per Event type: \n" +
              "1. Golf\n" +
              "2. Bowling\n" +
              "3. Amusment Park\n" +
              "4. Concert");
            int value = int.Parse(Console.ReadLine());
            var eventType = (EventType)value;

            decimal total = _oRepo.GetToalCostOfOuting(eventType);
            Console.WriteLine($"Total Cost: {total}");
            Console.ReadKey();
        }

        private void GetTotalCostOfOuting()
        {
            Console.Clear();
            Console.WriteLine("Total Cost of Outing: ");
            decimal outings = _oRepo.GetTotalCostOfOuting();
            Console.WriteLine($"Total Cost: {outings}");
            Console.ReadKey();
        }

        private void WaitForKeyPress()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void GetContents()
        {
            Console.Clear();
            Console.WriteLine("Outings: ");
            List<Outing> outing = _oRepo.GetContents();
            foreach (Outing item in outing)
            {
                {
                    Console.WriteLine(item.ToString());
                }
                {
                    WaitForKeyPress();
                }
            }
            Console.ReadKey();
        }
        private void AddNewOuting()
        {
            Console.Clear();
            Outing outing = new Outing();

            Console.WriteLine("Enter the Event type: \n" +
               "1. Golf\n" +
               "2. Bowling\n" +
               "3. Amusment Park\n" +
               "4. Concert");
            int value = int.Parse(Console.ReadLine());
            outing.EventType = (EventType)value;

            Console.WriteLine("Number of People Attended: ");
            outing.PeopleThatAttended = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Date of Event: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            outing.Date = date;

            Console.WriteLine("Cost Per Person: ");
            outing.CostPerPerson = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Cost Per Event: ");
            outing.CostPerEvent = Convert.ToDecimal(Console.ReadLine());

            var success = _oRepo.AddNewOuting(outing);
            if (success)
            {
                Console.WriteLine("SUCCESS");
            }
            else
            {
                Console.WriteLine("FAILED");
            }
        }
        private void Seed()
        {
           Outing outingA = new Outing(EventType.AmusementPark, 30, new DateTime(2021, 11, 05), 25.00m, 750.00m);
           Outing outingB = new Outing(EventType.Bowling, 20, new DateTime(2021, 11, 15), 10.00m, 200.00m);
           Outing outingC = new Outing(EventType.Concert, 100, new DateTime(2021, 07, 03), 150.00m, 15000.00m);
           Outing outingD = new Outing(EventType.Golf, 10, new DateTime(2021, 05, 25), 30.00m, 300.00m);
            _oRepo.AddNewOuting(outingA);
            _oRepo.AddNewOuting(outingB);
            _oRepo.AddNewOuting(outingC);
            _oRepo.AddNewOuting(outingD);
        }
    }
}





