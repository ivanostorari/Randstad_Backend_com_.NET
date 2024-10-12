using trilha_net_minimals_api_desafio.Models;

namespace trilha_net_minimals_api_desafio.Services.Interfaces
{
    public interface IVeiculoService
    {
        List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null);

        Veiculo? BuscarPorId(int id);

        void Inserir(Veiculo veiculo);

        void Atualizar(Veiculo veiculo);

        void Apagar(Veiculo veiculo);
    }
}