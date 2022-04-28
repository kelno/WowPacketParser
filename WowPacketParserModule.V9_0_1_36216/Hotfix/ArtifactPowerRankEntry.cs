using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.ArtifactPowerRank, HasIndexInData = false)]
    public class ArtifactPowerRankEntry
    {
        public byte RankIndex { get; set; }
        public int SpellID { get; set; }
        public ushort ItemBonusListID { get; set; }
        public float AuraPointsOverride { get; set; }
        public ushort ArtifactPowerID { get; set; }
    }
}
