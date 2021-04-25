using Newtonsoft.Json;
using System.Collections.Generic;

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

        public string DonoConta { get; set; }

        public AccountContent AccountContent { get; set; }
    }

    public class NftsItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("shine")]
        public string Shine { get; set; }
    }

    public class AccountContent
    {
        [JsonProperty("ram_quota")]
        public double RamCota { get; set; }

        [JsonProperty("ram_usage")]
        public double RamUtilizada { get; set; }

        [JsonProperty("net_limit")]
        public NetLimit Net { get; set; }

        [JsonProperty("cpu_limit")]
        public CpuLimit Cpu { get; set; }
    }

    public class NetLimit
    {
        [JsonProperty("used")]
        public double Used { get; set; }

        [JsonProperty("available")]
        public double Available { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }
    }

    public class CpuLimit
    {
        [JsonProperty("used")]
        public double Used { get; set; }

        [JsonProperty("available")]
        public double Available { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }
    }
}
