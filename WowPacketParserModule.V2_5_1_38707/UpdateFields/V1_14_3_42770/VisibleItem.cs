using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V2_5_1_38707.UpdateFields.V1_14_3_42770
{
    public class VisibleItem : IVisibleItem
    {
        public System.Nullable<int> ItemID { get; set; }
        public System.Nullable<ushort> ItemAppearanceModID { get; set; }
        public System.Nullable<ushort> ItemVisual { get; set; }

        public IVisibleItem Clone() { return (IVisibleItem)MemberwiseClone(); }
    }
}

