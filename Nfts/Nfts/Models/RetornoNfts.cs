using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Nfts
{
    public class RetornoNfts
    {
        [JsonProperty(PropertyName = "data")]
        public List<NftsIntermediario> InfosGerais { get; set; }

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
    }

    public class NftsIntermediario
    {
        [JsonProperty("data")]
        public NftsItem Item { get; set; }

        public string Conta { get; set; }
    }

    public class NftsItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }
    }
}
