﻿using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WA.ViaCEPCache.Main.Models
{
    public class ViaCEPResponse
    {
        public Guid Id { get; set; }

        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }
        
        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("localidade")]
        public string Localidade { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("ibge")]
        public string Ibge { get; set; }

        [JsonProperty("gia")]
        public string Gia { get; set; }

        [JsonProperty("ddd")]
        public string Ddd { get; set; }

        [JsonProperty("siafi")]
        public string Siafi { get; set; }

        public string GetCep()
        {
            return Cep.Replace("-", "");
        }

    }
}