using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V9_0_1_36216.UpdateFields.V9_0_2_36639
{
    public class SocketedGem : ISocketedGem
    {
        public int ItemID { get; set; }
        public ushort[] BonusListIDs { get; } = new ushort[16];
        public byte Context { get; set; }
    }
}

