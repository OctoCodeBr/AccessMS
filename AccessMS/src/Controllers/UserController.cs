using AccessMS.DTOs.Login;
using AccessMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace AccessMS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController {

    private readonly UserService userService;

    public UserController(UserService _userService) =>
        (userService) = (_userService);

    [HttpPost("login")]
    public async Task<LoginResponseDTO> Login(LoginRequestDTO request) =>
        await userService.Login(request);

}