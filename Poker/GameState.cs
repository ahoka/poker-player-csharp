namespace Poker
{
    using System.Runtime.Serialization;
    using System.Collections.Generic;

    [DataContract]
    public class GameState
    {
        [DataMember(Name = "small_blind")]
        public uint SmallBind { get; set; }

        [DataMember(Name = "current_buy_in")]
        public uint CurrentBuyIn { get; set; }

        [DataMember(Name = "pot")]
        public uint Pot { get; set; }

        [DataMember(Name = "minimum_raise")]
        public uint MinimumRaise { get; set; }

        [DataMember(Name = "dealer")]
        public uint Dealer { get; set; }

        [DataMember(Name = "orbits")]
        public uint Orbits { get; set; }

        [DataMember(Name = "in_action")]
        public uint InAction { get; set; }

        [DataMember(Name = "players")]
        public List<Player> Players { get; set; }

        [DataMember(Name = "community_cards")]
        public List<Card> CommunityCards { get; set; }
    }
}
