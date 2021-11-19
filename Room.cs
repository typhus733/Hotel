using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    enum RoomType
    {
        Single, Double, Queen, King
    }
    class Room
    {
        //static public int NumberOfRooms = 0;

        public RoomType Type { get; set; }
        public int Number { get; set; }
        public decimal CostPerNight { get; set; }

        public Room(RoomType type, int number, decimal cost)
        {
            this.Type = type;
            this.Number = number;
            this.CostPerNight = cost;
            //Room.NumberOfRooms++;
        }


    }
}
