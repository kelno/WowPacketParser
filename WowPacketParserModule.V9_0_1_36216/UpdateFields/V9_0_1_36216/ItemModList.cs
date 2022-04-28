using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

namespace WowPacketParserModule.V9_0_1_36216.UpdateFields.V9_0_1_36216
{
    public class ItemModList : IItemModList
    {
        public DynamicUpdateField<IItemMod> Values { get; } = new DynamicUpdateField<IItemMod>();
    }
}

