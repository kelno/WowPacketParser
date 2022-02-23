using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Store.Objects;

namespace WowPacketParserModule.Substructures
{
    public static class ItemHandler
    {
        public static ItemInstance ReadItemInstance602(Packet packet, params object[] indexes)
        {
            ItemInstance instance = new ItemInstance();
            instance.ItemID = packet.ReadInt32<ItemId>("ItemID", indexes);
            instance.RandomPropertiesSeed = packet.ReadUInt32("RandomPropertiesSeed", indexes);
            instance.RandomPropertiesID = packet.ReadUInt32("RandomPropertiesID", indexes);

            packet.ResetBitReader();

            var hasBonuses = packet.ReadBit("HasItemBonus", indexes);
            var hasModifications = packet.ReadBit("HasModifications", indexes);
            if (hasBonuses)
            {
                instance.Context = packet.ReadByte("Context", indexes);

                var bonusCount = packet.ReadUInt32();
                instance.BonusListIDs = new uint[bonusCount];
                for (var j = 0; j < bonusCount; ++j)
                    instance.BonusListIDs[j] = packet.ReadUInt32("BonusListID", indexes, j);
            }

            if (hasModifications)
            {
                var mask = packet.ReadUInt32();
                for (var j = 0; mask != 0; mask >>= 1, ++j)
                {
                    if ((mask & 1) != 0)
                    {
                        ItemModifier mod = (ItemModifier)j;
                        instance.ItemModifier[mod] = packet.ReadInt32(mod.ToString(), indexes);
                    }
                }
            }
            return instance;
        }

        public static ItemInstance ReadItemInstance815(Packet packet, params object[] indexes)
        {
            ItemInstance instance = new ItemInstance();
            instance.ItemID = packet.ReadInt32<ItemId>("ItemID", indexes);

            packet.ResetBitReader();
            var hasBonuses = packet.ReadBit("HasItemBonus", indexes);
            var hasModifications = packet.ReadBit("HasModifications", indexes);
            if (hasBonuses)
            {
                instance.Context = packet.ReadByte("Context", indexes);

                var bonusCount = packet.ReadUInt32();
                instance.BonusListIDs = new uint[bonusCount];
                for (var j = 0; j < bonusCount; ++j)
                    instance.BonusListIDs[j] = packet.ReadUInt32("BonusListID", indexes, j);
            }

            if (hasModifications)
            {
                var mask = packet.ReadUInt32();
                for (var j = 0; mask != 0; mask >>= 1, ++j)
                {
                    if ((mask & 1) != 0)
                    {
                        ItemModifier mod = (ItemModifier)j;
                        instance.ItemModifier[mod] = packet.ReadInt32(mod.ToString(), indexes);
                    }
                }
            }
            return instance;
        }

        public static ItemInstance ReadItemInstance(Packet packet, params object[] indexes)
        {
            if (ClientVersion.RemovedInVersion(ClientVersionBuild.V8_1_5_29683) || ClientVersion.IsClassicClientVersionBuild(ClientVersion.Build))
                return ReadItemInstance602(packet, indexes);
            return ReadItemInstance815(packet, indexes);
        }
    }
}
