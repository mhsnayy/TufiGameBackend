using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TufiGame.Application.DTOs.UserDTO;
using TufiGame.Application.Interfaces.Repositories;

namespace TufiGame.Application.Features.CQRS.Queries.GetAllUsers
{
    public class GetAllUsersQuery:IRequest<List<UserViewDto>>
    {

        public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserViewDto>>
        {
            private readonly IUserRepository _userRepository;
            public GetAllUsersQueryHandler(IUserRepository userRepository)
            {
                _userRepository = userRepository;
            }

            public async Task<List<UserViewDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
            {
                //cast convertion map işlemlerini burada yapacaz
                //automapper da eklenebilir.
                var users = await _userRepository.GetAllAsync();
                return users.Select(u => new UserViewDto()
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Phone = u.Phone,
                    Email = u.Email
                }).ToList();
            }
        }
    }
}
