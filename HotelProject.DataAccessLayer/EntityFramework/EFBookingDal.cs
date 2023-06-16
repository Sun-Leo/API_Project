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

        public void BookingStatusChangeApproved(int id)
        {
            var context = new Context();
            var value = context.Bookings.Find(id);
            value.Status = "Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusChangeCansel(int id)
        {
            var context = new Context();
            var value = context.Bookings.Find(id);
            value.Status = "İptal Edildi";
            context.SaveChanges();
        }

        public void BookingStatusChangeWait(int id)
        {
            var context = new Context();
            var value = context.Bookings.Find(id);
            value.Status = "Müşteri Aranacak";
            context.SaveChanges();
        }
    }
}
