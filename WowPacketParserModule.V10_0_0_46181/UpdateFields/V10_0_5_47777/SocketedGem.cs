using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V10_0_0_46181.UpdateFields.V10_0_5_47777
{
    public class SocketedGem : ISocketedGem
    {
        public System.Nullable<int> ItemID { get; set; }
        public System.Nullable<ushort>[] BonusListIDs { get; } = new System.Nullable<ushort>[16];
        public System.Nullable<byte> Context { get; set; }
    }
}

