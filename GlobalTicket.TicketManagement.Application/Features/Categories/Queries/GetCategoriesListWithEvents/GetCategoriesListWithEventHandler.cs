using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListWithEventHandler : IRequestHandler<GetCategoriesListWithEventQuery, List<CategoryEventListVm>>
    {
        private readonly ICategoryRepository _catgoryRepository;
        private readonly IMapper _mapper;

        public GetCategoriesListWithEventHandler(ICategoryRepository catgoryRepository, IMapper mapper)
        {
            _catgoryRepository = catgoryRepository;
            _mapper = mapper;
        }


        public async Task<List<CategoryEventListVm>> Handle(GetCategoriesListWithEventQuery request, CancellationToken cancellationToken)
        {
            var list = await _catgoryRepository.GetCategoriesWithEvents(request.IncludeHistory);
            return _mapper.Map<List<CategoryEventListVm>>(list);
        }
    }
}
