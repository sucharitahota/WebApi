using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace testAPI.Models
{
            //[DataContract]
    public class Response
    {
                //[DataMember(Name="data")]
                [JsonProperty(PropertyName="data")]
                public string data { get; set; }
    }
}