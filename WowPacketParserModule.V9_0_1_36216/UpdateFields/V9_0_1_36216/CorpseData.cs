using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

namespace WowPacketParserModule.V9_0_1_36216.UpdateFields.V9_0_1_36216
{
    public class CorpseData : ICorpseData
    {
        public uint DynamicFlags { get; set; }
        public WowGuid Owner { get; set; }
        public WowGuid PartyGUID { get; set; }
        public WowGuid GuildGUID { get; set; }
        public uint DisplayID { get; set; }
        public uint[] Items { get; } = new uint[19];
        public byte Unused { get; set; }
        public byte RaceID { get; set; }
        public byte Sex { get; set; }
        public uint Flags { get; set; }
        public int FactionTemplate { get; set; }
        public uint StateSpellVisualKitID { get; set; }
        public DynamicUpdateField<IChrCustomizationChoice> Customizations { get; } = new DynamicUpdateField<IChrCustomizationChoice>();
    }
}

