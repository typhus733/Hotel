using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    class Hotel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Reservation> Reservations{get; set;}

        public Hotel(string name, string city, List<Room> rooms)
        {
            this.Name = name;
            this.City = city;
            this.Rooms = rooms;
            Reservations = new List<Reservation>();
        }

        public Reservation MakeReservation(Customer customer, RoomType roomType, DateTime start, DateTime end)
        {
            
            Reservation reservation = null;

            foreach (Room room in Rooms)
            {
                if(room.Type == roomType)
                {
                    if (Reservations.Count == 0)
                    {
                        reservation = new Reservation(customer, room, start, end);
                        break;
                    }

                    else
                    {
                        foreach (Reservation reservationCheck in Reservations)
                        {
                            if (room.Number == reservationCheck.Room.Number)
                            {
                                break;
                            }
                            else
                            {
                                reservation = new Reservation(customer, room, start, end);
                                break;
                            }
                        }
                    }
                }
            }

            if (reservation == null)
            {
                throw new ArgumentOutOfRangeException();
            }

            return reservation;
        }

        public decimal DailyRevenue(DateTime day)
        {
            decimal sum = 0m;

            foreach (Reservation reservation in Reservations)
            {
                if (reservation.EndDate >= day && reservation.StartDate <= day)
                {

                }
            }

        }
    }
}
