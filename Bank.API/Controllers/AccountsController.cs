using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank.API.Controllers
{
    [Route("api/aspusers/{Id}account")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AccountsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult GetAccounts(string UserId)
        {
            var user = _repository.Account.GetAccounts(UserId, trackChanges: false);
            if(user == null)
            {
                _logger.LogInfo($"Account with Id: {UserId} does not exist in the database.");
                return NotFound();
            }
            var userfromDb = _repository.AspNetUser.GetAspNetUser(UserId, trackChanges: false);
            var accountDTO = _mapper.Map<IEnumerable<AccountsDTO>>(userfromDb);
            return Ok(accountDTO);
        }
    }
}
