﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFBookingDal: GenericRepository<Booking>, IBookingDal
    {
        public EFBookingDal(Context context): base(context) 
        {
                
        }

        public void BookingStatusChangeApproved(Booking booking)
        {
            var context = new Context();
            var value=context.Bookings.Where(x => x.BookingID == booking.BookingID).FirstOrDefault();
            value.Status = "Onaylandı";
            context.SaveChanges();
        }
    }
}