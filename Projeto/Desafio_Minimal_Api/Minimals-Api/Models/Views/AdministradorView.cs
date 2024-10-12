namespace trilha_net_minimals_api_desafio.Models.Views
{
    public record AdministradorView
    {
        public int Id { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Perfil { get; set; } = default!;
    }
}