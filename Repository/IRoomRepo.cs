using BookingSystem.Models;
using System.Collections.Generic;

namespace BookingSystem.Repository
{
    public interface IRoomRepo
    {
        int Delete(int id);
        int Edit(int id, Room room);
        Room FindById(int id);
        List<Room> GetAll();
        int Insert(Room room);
    }
}