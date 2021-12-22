using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_KomodoOutings.Repository
{
    public class OutingRepository
    {
        protected readonly List<Outing> _outingDirectory = new List<Outing>();

        //Create
        public bool AddNewOuting(Outing outing)
        {
            if (outing is null)
            {
                return false;
            }
            else
            {
               
                _outingDirectory.Add(outing);
                return true;
            }
        }

        //Read
        public List<Outing> GetContents()
        {
            return _outingDirectory;
        }

        public decimal GetTotalCostOfOuting()
        {
            decimal startingCosts = 0;
            foreach (var item in _outingDirectory)
            {
                startingCosts += item.CostPerEvent;
                
            }
            return startingCosts;
        }

        public decimal GetToalCostOfOuting(EventType eventType)
        {
            decimal startingCosts = 0;

            foreach (var item in _outingDirectory)
            {
                if (item.EventType==eventType)
                {
                    startingCosts += item.CostPerEvent;

                }

            }
            return startingCosts;
        }
    }
}
