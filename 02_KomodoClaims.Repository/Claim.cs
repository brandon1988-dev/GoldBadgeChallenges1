using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaims.Repository
{
    public enum ClaimType
    {
        Auto =1,
        Home =2,
        Theft =3
    }
    public class Claim
    {
        public Claim() { }

        public Claim(int claimId, ClaimType claimType, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ClaimID = claimId;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;

        }
        public int ClaimID { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid 
        { 
            get
            {
                TimeSpan span =  DateOfIncident - DateOfClaim;
                if (span.TotalDays>30)
                {
                    return false;
                }
                return true;
            }
        }
        public override string ToString()
        {
            return $"{ClaimID} \n" +
                $"{ClaimType}\n" +
                $"{Description}\n" +
                $"{ClaimAmount}\n" +
                $"{DateOfIncident}\n" +
                $"{DateOfClaim}\n" +
                $"{IsValid}"; 
        }

    }

}