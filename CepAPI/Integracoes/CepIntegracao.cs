

using CepAPI.Integracoes.Interfaces;
using CepAPI.Integracoes.Response;

namespace CepAPI.Integracoes
{
    public class CepIntegracao : ICepIntegracao
    {
        private readonly ICepIntegraçãoRefit _cepIntegraçãoRefit;
        public CepIntegracao(ICepIntegraçãoRefit cepIntegraçãoRefit)
        {
            _cepIntegraçãoRefit = cepIntegraçãoRefit;
        }
        public async Task<CepResponse> ObterDadosCep(string cep)
        {
            var responseData = await _cepIntegraçãoRefit.ObterDadosViaCep(cep);

            if(responseData != null && responseData.IsSuccessStatusCode) 
            {
                return responseData.Content;
            }

            return null;
        }
    }
}
