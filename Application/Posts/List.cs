using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistance;

namespace Application.Posts
{
    public class List
    {
        public class Query : IRequest<List<Post>> { }

        public class Handler : IRequestHandler<Query, List<Post>>
        {
      
            public DataContext _context { get; set; }
            public Handler(DataContext context)
            {
                _context = context;
            }
            public  async Task<List<Post>> Handle(Query request, CancellationToken cancellationToken)
            {
                var posts = await _context.Posts.ToListAsync();
                return posts;
            }
        }

    }
}