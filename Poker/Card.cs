namespace Poker
{
    using System.Runtime.Serialization;
    using System.Collections.Generic;

    [DataContract]
    public class Card
    {
        [DataMember(Name = "rank")]
        public string Rank { get; set; }

        [DataMember(Name = "suit")]
        public string Suit { get; set; }
    }
}