using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelOrigin.Core.Domain;
using System.Collections.ObjectModel;

namespace HotelOrigin.Core.Repository
{
    public class RoomRepository
    {
        private static ObservableCollection<Room> rooms = new ObservableCollection<Room>();

        public static Room Create()
        {
            Room room = new Room();

            rooms.Add(room);

            return room;
        }
        public static void Add(Room room)
            {
            rooms.Add(room);
        }
        public static Room GetById(int roomNumber)
        {
            return rooms.FirstOrDefault(c => c.RoomNumber == roomNumber);
        }
        public static ObservableCollection<Room> GetAll()
        {
            return rooms;
        }
        public static void Update(Room room, int roomNumber, int numberOfBeds, bool hasTv)
        {
            room.RoomNumber = roomNumber;
            room.NumberOfBeds = numberOfBeds;
            room.HasTv = hasTv;
        }
        public static void Delete(int roomNumber)
        {
            var room = GetById(roomNumber);

            rooms.Remove(room);
        }
        public static void Delete (Room room)
        {
            rooms.Remove(room);
        }
    }
}
