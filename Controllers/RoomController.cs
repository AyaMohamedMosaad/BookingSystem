using BookingSystem.Models;
using BookingSystem.Repository;
using BookingSystem.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BookingSystem.Controllers
{
    public class RoomController : Controller
    {
        IRoomRepo RoomRepo;

       // Entity context;
        public RoomController(IRoomRepo _RoomRepo/*, Entity _context*/)
        {
            RoomRepo = _RoomRepo;
           // context = _context;
         
        }


        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Search(SearchForAvailableRoomsViewModel SVM)
        //{
        //    if (SVM.DateFrom==null || SVM.DateTo == null)
        //    {
        //    return View();

        //    }
        //   var RoomsBooked = from b in context.Reservations
        //                             where  ((SVM.DateFrom>=b.StartDate)&& (SVM.DateFrom<=b.EndDate))||
        //                                    ((SVM.DateTo >= b.StartDate) && (SVM.DateTo <= b.EndDate)) ||     
        //                                    ((SVM.DateFrom <= b.StartDate) && (SVM.DateTo >= b.StartDate)&&(SVM.DateTo<=b.EndDate))||
        //                                    ((SVM.DateFrom >= b.StartDate) && (SVM.DateTo <= b.StartDate) && (SVM.DateTo >= b.EndDate)) ||
        //                                    ((SVM.DateFrom <= b.StartDate) && (SVM.DateTo >= b.EndDate)) 
        //                             select b;

        //    var availableRooms = context.Rooms.Where(r => !RoomsBooked.Any(b => b.Id == r.Id)).Include(x => x.RoomType).ToList();
        //    foreach(var item in availableRooms)
        //    {
        //        if(item)
        //    }

        //    return View();
        //}
    }
}
