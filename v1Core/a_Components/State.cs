using Amazon.DynamoDBv2.DataModel;
using System.Collections.Generic;

namespace HowDareYou
{
    [DynamoDBTable(SessionKey.DbTableName)]
    public class State
    {
        [DynamoDBHashKey]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int NumPlayed { get; set; }
        public int NumPrompted { get; set; }
        public List<Utterance> Utterances { get; set; }
    }
}
