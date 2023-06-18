using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gym_app_backend.Data.AuthRepository;
using gym_app_backend.Dtos;
using gym_app_backend.Dtos.User;
using gym_app_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace gym_app_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }
        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserSignUpDto request)
        {
            var response = await _authRepo.Register(
                new User { FirstName = request.FirstName, LastName = request.LastName, EmailAddress = request.EmailAddress, ReceiveDiscounts = request.ReceiveDiscounts }, request.Password
            );
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
        {
            var response = await _authRepo.Login(request.EmailAddress, request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}