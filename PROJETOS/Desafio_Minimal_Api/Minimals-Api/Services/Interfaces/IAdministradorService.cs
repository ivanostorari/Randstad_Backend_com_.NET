using trilha_net_minimals_api_desafio.DTOs;
using trilha_net_minimals_api_desafio.Models;

namespace trilha_net_minimals_api_desafio.Services.Interfaces
{
    public interface IAdministradorService
    {
        Administrador? Login(LoginDTO loginDTO);
        Administrador Inserir(Administrador administrador);
        List<Administrador> Todos(int? pagina);
        Administrador? BuscarPorId(int id);
    }
}