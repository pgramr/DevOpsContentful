using Contentful.Core.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DevOpsContentful.Models
{
    public class Snippet
    {
        [JsonProperty("sys")]
        public SystemProperties SystemProperties { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public File File { get; set; }

        public Dictionary<string, string> TitleLocalized { get; set; }

        public Dictionary<string, string> DescriptionLocalized { get; set; }

        public Dictionary<string, File> FilesLocalized { get; set; }

    }
}
