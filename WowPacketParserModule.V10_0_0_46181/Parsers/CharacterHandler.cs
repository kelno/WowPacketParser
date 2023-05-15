﻿using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;

namespace WowPacketParserModule.V10_0_0_46181.Parsers
{
    public static class CharacterHandler
    {
        public static void ReadPVPBracketData(Packet packet, params object[] idx)
        {
            packet.ReadByte("Bracket", idx);
            packet.ReadInt32("Unused3", idx);
            packet.ReadInt32("Rating", idx);
            packet.ReadInt32("Rank", idx);
            packet.ReadInt32("WeeklyPlayed", idx);
            packet.ReadInt32("WeeklyWon", idx);
            packet.ReadInt32("SeasonPlayed", idx);
            packet.ReadInt32("SeasonWon", idx);
            packet.ReadInt32("WeeklyBestRating", idx);
            packet.ReadInt32("SeasonBestRating", idx);
            packet.ReadInt32("PvpTierID", idx);
            packet.ReadInt32("WeeklyBestWinPvpTierID", idx);
            packet.ReadInt32("Unused1", idx);
            packet.ReadInt32("Unused2", idx);
            packet.ReadInt32("RoundsSeasonPlayed", idx);
            packet.ReadInt32("RoundsSeasonWon", idx);
            packet.ReadInt32("RoundsWeeklyPlayed", idx);
            packet.ReadInt32("RoundsWeeklyWon", idx);

            packet.ReadBit("Disqualified", idx);
            packet.ResetBitReader();
        }

        [Parser(Opcode.SMSG_INSPECT_RESULT)]
        public static void HandleInspectResult(Packet packet)
        {
            V9_0_1_36216.Parsers.CharacterHandler.ReadPlayerModelDisplayInfo(packet, "DisplayInfo");
            var glyphCount = packet.ReadUInt32("GlyphsCount");
            var talentCount = packet.ReadUInt32("TalentsCount");
            var pvpTalentCount = packet.ReadUInt32("PvpTalentsCount");
            packet.ReadInt32("ItemLevel");
            packet.ReadByte("LifetimeMaxRank");
            packet.ReadUInt16("TodayHK");
            packet.ReadUInt16("YesterdayHK");
            packet.ReadUInt32("LifetimeHK");
            packet.ReadUInt32("HonorLevel");

            for (int i = 0; i < glyphCount; i++)
                packet.ReadUInt16("Glyphs", i);

            for (int i = 0; i < talentCount; i++)
                packet.ReadUInt16("Talents", i);

            for (int i = 0; i < pvpTalentCount; i++)
                packet.ReadUInt16("PvpTalents", i);

            var hasGuildData = packet.ReadBit("HasGuildData");
            var hasAzeriteLevel = packet.ReadBit("HasAzeriteLevel");
            packet.ResetBitReader();

            for (int i = 0; i < 7; i++)
                ReadPVPBracketData(packet, i, "PVPBracketData");

            if (hasGuildData)
            {
                packet.ReadPackedGuid128("GuildGUID");
                packet.ReadInt32("NumGuildMembers");
                packet.ReadInt32("GuildAchievementPoints");
            }
            if (hasAzeriteLevel)
                packet.ReadInt32("AzeriteLevel");

            packet.ReadInt32("Level", "TraitInspectData");
            packet.ReadInt32("ChrSpecializationID", "TraitInspectData");
            TraitHandler.ReadTraitConfig(packet, "TraitInspectData", "Traits");
        }
    }
}
