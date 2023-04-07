using AccessMS.DTOs.Login;
using AccessMS.Errors;
using AccessMS.Infrastructure.Repositories;

namespace AccessMS.Services;

public class UserService: IService {
    
    private readonly UserRepository userRepository;

    public UserService(UserRepository _userRepository) =>
        (userRepository) = (_userRepository);

    public async Task<LoginResponseDTO> Login(LoginRequestDTO request) {
        
        var user = await userRepository.GetUser(request.Login);

        if (user == null)
            throw new APIException("Usuário não encontrado. Que tal tentar novamente?");

        if (!(user.Password == request.Senha))
            throw new APIException("Senha inválida. Que tal tentar novamente?");

        return new LoginResponseDTO {
            AuthToken = Guid.NewGuid().ToString()
        };
    }

}