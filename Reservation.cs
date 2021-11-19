using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    class Reservation
    {
        public Customer Customer { get; set; }
        public Room Room { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Reservation(Customer customer, Room room, DateTime start, DateTime end)
        {
            this.Customer = customer;
            this.Room = room;
            this.StartDate = start;
            this.EndDate = end;
        }

        static public decimal CalculateReservationCost(Reservation reservation)
        {
            decimal cost = 0m;

            double days = (reservation.EndDate - reservation.StartDate).TotalDays;

            cost = (int)days * reservation.Room.CostPerNight;

            return cost;
        }

    }
}
