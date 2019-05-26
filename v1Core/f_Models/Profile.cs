using Newtonsoft.Json;
using System.Collections.Generic;

namespace HowDareYou
{
    public class Profile
    {
        public string Mode { get; set; }

        public string Name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Questions { get; set; }

        public List<string> Answers { get; set; }
    }
}
