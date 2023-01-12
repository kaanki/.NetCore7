using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Activities;
public class Edit
{

    public class Command : IRequest
    {
        public Activity Activity { get; set; }
    }

    public class Handler : IRequestHandler<Command>
    {
        private readonly DataContext _context;
        public IMapper _mapper { get; }
        public Handler(DataContext context, IMapper mapper)
        {
            this._context = context;
            _mapper = mapper;
        }



        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            var activity = await _context.Activities.FindAsync(request.Activity.Id);
            _mapper.Map(request.Activity, activity);

            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }


}