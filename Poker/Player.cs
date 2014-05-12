namespace Poker
{
    using System.Runtime.Serialization;
    using System.Collections.Generic;

    [DataContract]
    public class Player
    {
        [DataMember(Name = "id")]
        public uint Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "version")]
        public string Version { get; set; }

        [DataMember(Name = "stack")]
        public uint Stack { get; set; }

        [DataMember(Name = "bet")]
        public uint Bet { get; set; }
    }
}
