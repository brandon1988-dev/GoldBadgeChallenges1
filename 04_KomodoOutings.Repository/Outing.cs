using System;

namespace _04_KomodoOutings.Repository
{
    public enum EventType
    {
        Golf = 1,
        Bowling = 2,
        AmusementPark = 3,
        Concert = 4
    }

    public class Outing
    {
        public Outing() { }

        public Outing(EventType eventType, int peopleThatAttended, DateTime date, decimal costPerPerson, decimal costPerEvent)
        {
            EventType = eventType;
            PeopleThatAttended = peopleThatAttended;
            Date = date;
            CostPerPerson = costPerPerson;
            CostPerEvent = costPerEvent;
        }
        public EventType EventType { get; set; }
        public int PeopleThatAttended { get; set; }
        public DateTime Date { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal CostPerEvent { get; set; }

        public override string ToString()
        {

            return $"{EventType} \n" +
                   $"{PeopleThatAttended}\n" +
                   $"{Date}\n" +
                   $"{CostPerPerson}\n" +
                   $"{CostPerEvent}";
        }
    }

}
