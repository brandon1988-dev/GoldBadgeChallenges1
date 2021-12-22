using _02_KomodoClaims.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaimsUI
{
    class ProgramUI
    {
        private readonly ClaimRepository _cRepo = new ClaimRepository();


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
                    "1. See All Claims\n" +
                    "2. Take Care Of Next Claim\n" +
                    "3. Add New Claim\n" +
                    "4. Exit\n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        GetAllContents();
                        break;
                    case "2":
                        TakeCareOfNextClaim();
                        break;
                    case "3":
                        AddNewClaim();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a number between 1 and 4");
                        WaitForKeyPress();
                        break;
                }

            }
        }
        private void WaitForKeyPress()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void GetAllContents()
        {
            Console.Clear();
            Console.WriteLine("Claims available: ");
            Queue<Claim> claims = _cRepo.GetAllContents();
            foreach (Claim item in claims)
            {
                {
                    Console.WriteLine(item.ToString());
                }
                {
                    WaitForKeyPress();
                }
            }

        }
        private void AddNewClaim()
        {
            Console.Clear();
            Claim claim = new Claim();

            Console.WriteLine("Enter the claim id: ");
            claim.ClaimID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the claim type: \n" +
                "1. Auto\n" +
                "2. Home\n" +
                "3. Theft");
            int value = int.Parse(Console.ReadLine());
            claim.ClaimType = (ClaimType)value;

            Console.WriteLine("Amount of Damage: ");
            claim.ClaimAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Date of Incident: ");
            DateTime dateOfIncident = DateTime.Parse(Console.ReadLine());
            claim.DateOfIncident = dateOfIncident;

            Console.WriteLine("Date of Claim: ");
            DateTime dateOfClaim = DateTime.Parse(Console.ReadLine());
            claim.DateOfClaim = dateOfClaim;

            Console.WriteLine($"This claim is {claim.IsValid} ");
            bool success = _cRepo.AddNewClaim(claim);
            if (success)
            {
                Console.WriteLine("SUCCESS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
        }

        private void TakeCareOfNextClaim()
        {
            Console.Clear();
            Claim claim = _cRepo.GetClaim();
            Console.WriteLine(claim.ToString());
            Console.WriteLine("Do you want to handle this claim? y/n");
            string userInput = Console.ReadLine();
            if (userInput == "Y".ToLower())
            {
                bool success = _cRepo.NextClaim();
                if (success)
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAIL");
                }
            }
            else
            {
                Console.WriteLine("Claim was not handled");
            }
            Console.ReadKey();
        }

        private void Seed()
        {
            Claim claimA = new Claim(1, ClaimType.Auto, "Cars", 100.00m, new DateTime(2021, 11, 05), new DateTime(2020, 12, 30));
            Claim claimB = new Claim(2, ClaimType.Home, "House", 1000.00m, new DateTime(2021, 10, 05), new DateTime(2020, 12, 30));
            Claim claimC = new Claim(3, ClaimType.Theft, "Stolen", 10000.00m, new DateTime(2021, 09, 05), new DateTime(2020, 12, 30));
            _cRepo.AddNewClaim(claimC); 
            _cRepo.AddNewClaim(claimB); 
            _cRepo.AddNewClaim(claimA); 
        }
    }
}
