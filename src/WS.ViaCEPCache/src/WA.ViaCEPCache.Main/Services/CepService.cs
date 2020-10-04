using System.Linq;
using RestSharp;
using WA.ViaCEPCache.Main.Infra;
using WA.ViaCEPCache.Main.Models;

namespace WA.ViaCEPCache.Main.Services
{
    public class CepService
    {
        private readonly CepContext _context;
        private RestClient _client;

        public CepService()
        {
            _context = new CepContext();
        }

        public ViaCEPResponse GetCep(string cep)
        {
            var r = _context.Ceps
                .ToList().Find(x => x.GetCep() == cep);

            if (r == null)
            {
                _client = new RestClient();
                var request = new RestRequest($"https://viacep.com.br/ws/{cep}/json/", Method.GET);

                var response = _client.Get<ViaCEPResponse>(request);

                if (response.IsSuccessful && response.Data != null)
                {
                    _context.Ceps.Add(response.Data);
                    _context.SaveChanges();
                    return response.Data;
                }

            }

            return r;

        }
    }
}