﻿using HotelProject.BuninessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingServices _bookingServices;

        public BookingController(IBookingServices bookingServices)
        {
            _bookingServices = bookingServices;
        }

        [HttpGet]
        public IActionResult Bookinglist()
        {
            var value = _bookingServices.TGetList();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingServices.TInsert(booking);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingServices.TGetByID(id);
            _bookingServices.TDelete(value);
            return Ok();
        }
        [HttpGet("id")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingServices.TGetByID(id);
            return Ok(value);
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingServices.TUpdate(booking);
            return Ok();
        }
        [HttpPut("BookingStatus1")]
        public IActionResult BookingStatus1(Booking booking)
        {
            _bookingServices.TBookingStatusChangeApproved(booking);
            return Ok();
        }
    }
}
