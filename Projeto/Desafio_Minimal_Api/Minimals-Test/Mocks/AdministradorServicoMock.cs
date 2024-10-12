using trilha_net_minimals_api_desafio.DTOs;
using trilha_net_minimals_api_desafio.Models;
using trilha_net_minimals_api_desafio.Services.Interfaces;

namespace Minimals_Test.Mocks
{
    public class AdministradorServicoMock : IAdministradorService
{
    private static List<Administrador> administradores = new List<Administrador>(){
        new Administrador{
            Id = 1,
            Email = "adm@teste.com",
            Senha = "123456",
            Perfil = "Adm"
        },
        new Administrador{
            Id = 2,
            Email = "editor@teste.com",
            Senha = "123456",
            Perfil = "Editor"
        }
    };

    public Administrador? BuscarPorId(int id)
    {
        return administradores.Find(a => a.Id == id);
    }

    public Administrador Inserir(Administrador administrador)
    {
        administrador.Id = administradores.Count() + 1;
        administradores.Add(administrador);

        return administrador;
    }

    public Administrador? Login(LoginDTO loginDTO)
    {
        return administradores.Find(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha);
    }

    public List<Administrador> Todos(int? pagina)
    {
        return administradores;
    }
}
}