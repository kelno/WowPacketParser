﻿using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;
using CoreParsers = WowPacketParser.Parsing.Parsers;

namespace WowPacketParserModule.V10_0_0_46181.Parsers
{
    public static class NpcHandler
    {
        [Parser(Opcode.SMSG_GOSSIP_OPTION_NPC_INTERACTION)]
        public static void HandleGossipOptionNPCInteraction(Packet packet)
        {
            packet.ReadPackedGuid128("GossipGUID");
            var gossipNpcOptionID = packet.ReadInt32("GossipNpcOptionID");
            var hasFriendshipFactionID = packet.ReadBit();

            if (hasFriendshipFactionID)
                packet.ReadInt32("FriendshipFactionID");

            CoreParsers.NpcHandler.AddGossipNpcOption(gossipNpcOptionID, packet.TimeSpan, true);
        }

        [Parser(Opcode.SMSG_VENDOR_INVENTORY)]
        public static void HandleVendorInventory(Packet packet)
        {
            uint entry = packet.ReadPackedGuid128("VendorGUID").GetEntry();
            packet.ReadByte("Reason");
            int count = packet.ReadInt32("VendorItems");

            for (int i = 0; i < count; ++i)
            {
                NpcVendor vendor = new NpcVendor
                {
                    Entry = entry,
                };

                packet.ReadInt64("Price", i);
                vendor.Slot = packet.ReadInt32("Muid", i);
                packet.ReadInt32("Durability", i);
                int buyCount = packet.ReadInt32("StackCount", i);
                int maxCount = packet.ReadInt32("Quantity", i);
                vendor.ExtendedCost = packet.ReadUInt32("ExtendedCostID", i);
                vendor.PlayerConditionID = packet.ReadUInt32("PlayerConditionFailed", i);

                packet.ResetBitReader();
                vendor.Type = packet.ReadBits("Type", 3, i);
                packet.ReadBit("Locked", i);
                vendor.IgnoreFiltering = packet.ReadBit("DoNotFilterOnVendor", i);
                packet.ReadBit("Refundable", i);

                packet.ResetBitReader();
                vendor.Item = Substructures.ItemHandler.ReadItemInstance(packet, i).ItemID;

                vendor.MaxCount = maxCount == -1 ? 0 : (uint)maxCount; // TDB
                if (vendor.Type == 2)
                    vendor.MaxCount = (uint)buyCount;

                Storage.NpcVendors.Add(vendor, packet.TimeSpan);
            }

            CoreParsers.NpcHandler.LastGossipOption.Reset();
            CoreParsers.NpcHandler.TempGossipOptionPOI.Reset();
        }
    }
}
