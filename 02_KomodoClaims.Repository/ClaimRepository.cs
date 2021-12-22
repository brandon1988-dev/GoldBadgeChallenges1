using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaims.Repository
{
    public class ClaimRepository
    {
        protected readonly Queue<Claim> _claimDirectory = new();
        private int _count;


        //Create
        public bool AddNewClaim(Claim claim)
        {
            if (claim is null)
            {
                return false;
            }
            else
            {
                _count++;
                claim.ClaimID = _count;
                _claimDirectory.Enqueue(claim);
                return true;
            }

        }

        //Read
        public Queue<Claim> GetAllContents()
        {
            return _claimDirectory;
        }
        public Claim GetClaim()
        {
            return _claimDirectory.Peek();
        }

        public bool NextClaim()
        {
             _claimDirectory.Dequeue();
            return true;
        }

    }
}


        

    
