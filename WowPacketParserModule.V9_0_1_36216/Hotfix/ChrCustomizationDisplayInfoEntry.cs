using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.ChrCustomizationDisplayInfo, ClientVersionBuild.V9_0_1_36216, ClientVersionBuild.V9_1_0_39185)]
    public class ChrCustomizationDisplayInfoEntry
    {
        public uint ID { get; set; }
        public int ShapeshiftFormID { get; set; }
        public int DisplayID { get; set; }
        public float BarberShopMinCameraDistance { get; set; }
        public float BarberShopHeightOffset { get; set; }
    }
}
