﻿using AutoMapper;
using HotelProject.DTOLayer.DTOS.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.Web.Mapping
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AddRoomDto, Room>();
            CreateMap<Room, AddRoomDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
