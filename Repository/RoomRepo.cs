using BookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookingSystem.Repository
{
    public class RoomRepo : IRoomRepo
    {

        Entity context;
        public RoomRepo(Entity _context)
        {
            context = _context;
        }

        public List<Room> GetAll()
        {
            return context.Rooms.ToList();
        }

       
        public Room FindById(int id)
        {
            return context.Rooms.FirstOrDefault(x => x.Id == id);
        }
        public int Insert(Room room)
        {
            context.Rooms.Add(room);
            return context.SaveChanges();
        }
        public int Edit(int id, Room room)
        {
            Room oldRoom = FindById(id);
            if (oldRoom != null)
            {
                oldRoom.Status = room.Status;
                oldRoom.Price = room.Price;
                return context.SaveChanges();
            }
            return 0;
        }
        public int Delete(int id)
        {
            Room delRoom = FindById(id);
            context.Rooms.Remove(delRoom);
            return context.SaveChanges();
        }

    }
}
