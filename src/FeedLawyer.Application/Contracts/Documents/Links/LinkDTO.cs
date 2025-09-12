using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Application.Contracts.Documents.Links
{
    [DataContract]
    public class LinkDTO
    {
        [DataMember(Order = 1)]
        public string Href { get; set; } = string.Empty;
        [DataMember(Order = 2)]
        public string Rel { get; set; } = string.Empty;
        [DataMember(Order = 3)]
        public string Method { get; set; } = "GET";
    }
}
