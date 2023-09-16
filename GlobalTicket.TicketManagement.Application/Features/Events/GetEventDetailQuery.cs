﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Events
{
    public class GetEventDetailQuery :IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}
