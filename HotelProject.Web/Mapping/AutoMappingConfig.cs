using HotelProject.EntityLayer.Concrete;
using HotelProject.Web.DTOS.ServiceDtos;
using AutoMapper;
using HotelProject.Web.DTOS.RegisterDtos;
using HotelProject.Web.DTOS.Login_Dtos;
using HotelProject.Web.DTOS.AboutDtos;
using HotelProject.Web.DTOS.RoomDtos;

namespace HotelProject.Web.Mapping
{
    public class AutoMappingConfig: Profile
    {
        public AutoMappingConfig()
        {
              CreateMap<ResultServiceDto,Service>().ReverseMap();
              CreateMap<UpdateServiceDto,Service>().ReverseMap();
              CreateMap<CreateServiceDto,Service>().ReverseMap();

              CreateMap<CreateNewUserDto,AppUser>().ReverseMap();

            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultRoomDto, Room>().ReverseMap();


        }
    }
}
