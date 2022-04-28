using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.SpellCastTimes, HasIndexInData = false)]
    public class SpellCastTimesEntry
    {
        public int Base { get; set; }
        public int Minimum { get; set; }
    }
}
