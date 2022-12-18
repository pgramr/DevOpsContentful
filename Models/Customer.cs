using Contentful.Core.Models;
using Newtonsoft.Json;

namespace DevOpsContentful.Models
{
    public class Customer
    {
        [JsonProperty("sys")]
        public SystemProperties Sys { get; set; } = new SystemProperties();
        public int Id { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; } = string.Empty;
        [JsonProperty("Address")]
        public string Address { get; set; } = string.Empty;
        [JsonProperty("IBAN")]
        public string IBAN { get; set; } = string.Empty;
        [JsonProperty("VTA")]
        public string VTA { get; set; } = string.Empty;

    }
}
