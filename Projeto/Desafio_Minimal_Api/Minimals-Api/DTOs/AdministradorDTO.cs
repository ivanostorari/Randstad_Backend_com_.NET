using trilha_net_minimals_api_desafio.Models.Enums;

namespace trilha_net_minimals_api_desafio.DTOs
{
    public class AdministradorDTO
    {
        public string Email { get; set; } = default!;
        public string Senha { get; set; } = default!;
        public Perfil Perfil { get; set; } = default!;
    }
}