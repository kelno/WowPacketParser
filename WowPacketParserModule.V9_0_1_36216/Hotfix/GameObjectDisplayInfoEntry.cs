using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.GameobjectDisplayInfo, HasIndexInData = false)]
    public class GameObjectDisplayInfoEntry
    {
        [HotfixArray(3, true)]
        public float[] GeoBoxMin { get; set; }
        [HotfixArray(3, true)]
        public float[] GeoBoxMax { get; set; }
        public int FileDataID { get; set; }
        public short ObjectEffectPackageID { get; set; }
        public float OverrideLootEffectScale { get; set; }
        public float OverrideNameScale { get; set; }
    }
}
