using Contentful.Core.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DevOpsContentful.Models
{
    public class Asset
    {
        [JsonProperty("sys")]
        public SystemProperties SystemProperties { get; set; }

        //
        // Summary:
        //     The description of the asset.
        public string Description { get; set; }

        //
        // Summary:
        //     The title of the asset.
        public string Title { get; set; }

        //
        // Summary:
        //     Encapsulates information about the binary file of the asset.
        public File File { get; set; }

        //
        // Summary:
        //     The titles of the asset per locale.
        public Dictionary<string, string> TitleLocalized { get; set; }

        //
        // Summary:
        //     The descriptions of the asset per locale.
        public Dictionary<string, string> DescriptionLocalized { get; set; }

        //
        // Summary:
        //     Information about the file in respective language.
        public Dictionary<string, File> FilesLocalized { get; set; }

        ////
        //// Summary:
        ////     The system managed metadata of an entry.
        //public ContentfulMetadata Metadata { get; set; }
    }
}
