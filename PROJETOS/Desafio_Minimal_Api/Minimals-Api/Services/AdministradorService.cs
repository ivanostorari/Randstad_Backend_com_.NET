using trilha_net_minimals_api_desafio.Context;
using trilha_net_minimals_api_desafio.DTOs;
using trilha_net_minimals_api_desafio.Models;
using trilha_net_minimals_api_desafio.Services.Interfaces;

namespace trilha_net_minimals_api_desafio.Services
{
    public class AdministradorService : IAdministradorService
    {
        private readonly AutenticationContext _context;

        public AdministradorService(AutenticationContext context)
        {
            _context = context;
        }

        public Administrador? BuscarPorId(int id)
        {
            return _context.Administradores.Where(v => v.Id == id).FirstOrDefault();
        }

        public Administrador Inserir(Administrador administrador)
        {
            _context.Administradores.Add(administrador);
            _context.SaveChanges();

            return administrador;
        }
        
        public Administrador? Login(LoginDTO loginDTO)
        {
            var adm = _context.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
            return adm;
        }

        public List<Administrador> Todos(int? pagina)
        {
            var query = _context.Administradores.AsQueryable();

            int itensPorPagina = 10;

            if (pagina.HasValue)
            {
                query = query.Skip(((int)pagina - 1) * itensPorPagina).Take(itensPorPagina);
            }
            return [.. query];
        }
    }
}