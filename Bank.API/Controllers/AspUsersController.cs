using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bank.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AspUsersController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AspUsersController(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repository = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {

            var users = _repository.AspNetUser.GetAspNetUsers(trackChanges: false);
            var usersDTO = _mapper.Map<IEnumerable<UsersDTO>>(users);
            return Ok(usersDTO);

        }

        [HttpGet("{id}")]
        public IActionResult GetCompany(string id)
        {
            var user = _repository.AspNetUser.GetAspNetUser(id, trackChanges: false);
            if (user == null)
            {
                _logger.LogInfo($"Co,pany witth id:{id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var userDto = _mapper.Map<UsersDTO>(user);
                return Ok(userDto);
            }
        }

    }
}
