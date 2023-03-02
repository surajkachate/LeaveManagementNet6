using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Configurations
{
    public class MapperConfg : Profile
    {
        public MapperConfg() { 
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
