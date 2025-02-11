using AutoMapper;
using webapp.Models;
using webapp.Models.ViewModel;


namespace webapp.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Property, PropertyViewModel>(); 
        }
    }
}
