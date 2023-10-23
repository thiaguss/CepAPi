using CepAPI.Integracoes.Response;
using Refit;

namespace CepAPI.Integracoes.Interfaces
{
    public interface ICepIntegraçãoRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<CepResponse>> ObterDadosViaCep(string cep);
    }
}
