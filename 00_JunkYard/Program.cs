using _02_KomodoClaims.Repository;
using System;
using System.Collections;
using System.Collections.Generic;

namespace _00_JunkYard
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Claim> queue = new  Queue<Claim>();
            Claim newClaim = new Claim(1, ClaimType.Auto, "Cars", 1000.00m, new DateTime(2020, 11, 08), new DateTime(2020, 10, 15));
            Claim newClaim1 = new Claim(2, ClaimType.Home, "House", 1000.00m, new DateTime(2020, 11, 08), new DateTime(2020, 10, 15));
            Claim newClaim2 = new Claim(3, ClaimType.Theft, "Theif", 1000.00m, new DateTime(2020, 11, 08), new DateTime(2020, 10, 15));
            //Add to queue
            queue.Enqueue(newClaim);
            queue.Enqueue(newClaim1);
            queue.Enqueue(newClaim2);

            foreach (var item in queue)
            {
                Console.WriteLine($"{item.ClaimID}, {item.ClaimType}");
            }
            // I can only see who is next in line by putting ==> var claim = queue.Peek();

            // To remove a queue the dequeue method is used
            queue.Dequeue();
            queue.Dequeue();
            var claim = queue.Peek();

            Console.WriteLine($"Next in line: {claim.ClaimID}, {claim.ClaimType}");
            Console.ReadKey();
        }
    }
}
