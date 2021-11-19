using System;
using System.Collections.Generic;

namespace Hotel
{
    class HotelTest
    {
        public bool ReservationCreationTest()
        {

            Hotel testHotel = new Hotel("The Hotel", "The City", new List<Room> { new Room (RoomType.Single, 1, 50m)} );
            Customer testCustomer = new Customer("Bob", "Hope", "555-5555", DateTime.Parse("10/10/1910"), "1234512355");

            Reservation actualResult = testHotel.MakeReservation(testCustomer, RoomType.Single, DateTime.Parse("11/19/2021"), DateTime.Parse("11/20/2021"));


            Console.WriteLine("Reservation Creation Test should return True");
            return actualResult.Room.Type == RoomType.Single;

        }

        public bool ReservationAvailabilityTest()
        {
            bool actualResult = false;
            Hotel testHotel = new Hotel("The Hotel", "The City", new List<Room> { new Room(RoomType.Single, 1, 50m) });
            Customer testCustomer = new Customer("Bob", "Hope", "555-5555", DateTime.Parse("10/10/1910"), "1234512355");

            testHotel.Reservations.Add(testHotel.MakeReservation(testCustomer, RoomType.Single, DateTime.Parse("11/19/2021"), DateTime.Parse("11/20/2021")));
            try
            {
                testHotel.Reservations.Add(testHotel.MakeReservation(testCustomer, RoomType.Single, DateTime.Parse("11/19/2021"), DateTime.Parse("11/20/2021")));
            }
            catch (ArgumentOutOfRangeException e)
            {
                actualResult = true;
            }
            Console.WriteLine("Reservation Availablility Test should return True");
            return actualResult;

        }

        public bool ReservationCostCalculationTest()
        {
            decimal expectedResult = 50m;
            Hotel testHotel = new Hotel("The Hotel", "The City", new List<Room> { new Room(RoomType.Single, 1, 50m) });
            Customer testCustomer = new Customer("Bob", "Hope", "555-5555", DateTime.Parse("10/10/1910"), "1234512355");
            Reservation testReservation = testHotel.MakeReservation(testCustomer, RoomType.Single, DateTime.Parse("11/19/2021"), DateTime.Parse("11/20/2021"));

            decimal actualResult = Reservation.CalculateReservationCost(testReservation);

            Console.WriteLine("Reservation Cost Calculation Test should return True");
            return actualResult == expectedResult;

        }


    }

    class Menu
    {
        static void Main(string[] args)
        {
            HotelTest hotelTester = new HotelTest();

            //Console.WriteLine(hotelTester.ReservationCreationTest());

            //Console.WriteLine(hotelTester.ReservationAvailabilityTest());

            Console.WriteLine(hotelTester.ReservationCostCalculationTest());

        }
    }
}
