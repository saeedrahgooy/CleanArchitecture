using AutoMapper;
using GlobalTicket.TicketManagement.Application.Features.Events;
using GlobalTicket.TicketManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            //Two way mapping between event and eventlistvm
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event,EventDetailVm>().ReverseMap();
            CreateMap<Category,CategoryDto>().ReverseMap();

        }
    }
}
