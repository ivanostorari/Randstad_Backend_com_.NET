using trilha_net_minimals_api_desafio.Context;
using trilha_net_minimals_api_desafio.Models;
using trilha_net_minimals_api_desafio.Services.Interfaces;

namespace trilha_net_minimals_api_desafio.Services
{
    public class VeiculoService : IVeiculoService
    {
        private readonly AutenticationContext _context;

        public VeiculoService(AutenticationContext context)
        {
            _context = context;
        }

        public void Apagar(Veiculo veiculo)
        {
            _context.Veiculos.Remove(veiculo);
            _context.SaveChanges();
        }

        public void Atualizar(Veiculo veiculo)
        {
            _context.Veiculos.Update(veiculo);
            _context.SaveChanges();
        }

        public Veiculo? BuscarPorId(int id)
        {
            return _context.Veiculos.Where(v => v.Id == id).FirstOrDefault();
        }

        public void Inserir(Veiculo veiculo)
        {
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
        }

        public List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null)
        {
            var query = _context.Veiculos.AsQueryable();

            if(!string.IsNullOrEmpty(nome))
            {
                query = query.Where(v => v.Nome.Contains(nome, StringComparison.CurrentCultureIgnoreCase));
            }

            int itensPorPagina = 10;

            if(pagina.HasValue)
            {
                query = query.Skip(((int)pagina -1) * itensPorPagina).Take(itensPorPagina);
            }
            return [.. query];
        }
    }
}