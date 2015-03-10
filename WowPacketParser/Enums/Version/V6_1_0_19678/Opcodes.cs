using System;
using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V6_1_0_19678
{
    public static class Opcodes_6_1_0
    {
        public static BiDictionary<Opcode, int> Opcodes(Direction direction)
        {
            switch (direction)
            {
                case Direction.ClientToServer:
                case Direction.BNClientToServer:
                    return ClientOpcodes;
                case Direction.ServerToClient:
                case Direction.BNServerToClient:
                    return ServerOpcodes;
            }
            return MiscOpcodes;
        }

        private static readonly BiDictionary<Opcode, int> ClientOpcodes = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_ADD_FRIEND, 0x15E2},
            {Opcode.CMSG_ADD_IGNORE, 0x1D33},
            {Opcode.CMSG_ATTACKSTOP, 0x0853},
            {Opcode.CMSG_ATTACKSWING, 0x048B},
            {Opcode.CMSG_AUCTION_LIST_BIDDER_ITEMS, 0x0C81},
            {Opcode.CMSG_AUCTION_PLACE_BID, 0x09E1},
            {Opcode.CMSG_AUTH_CONTINUED_SESSION, 0x1A72},
            {Opcode.CMSG_AUTH_SESSION, 0x1872},
            {Opcode.CMSG_BATTLEMASTER_JOIN, 0x0B63},
            {Opcode.CMSG_BATTLE_PAY_GET_PURCHASE_LIST_QUERY, 0x11AA},
            {Opcode.CMSG_BATTLE_PET_MODIFY_NAME, 0x1131},
            {Opcode.CMSG_BATTLE_PET_SUMMON, 0x1321},
            {Opcode.CMSG_BUY_BACK_ITEM, 0x11CB},
            {Opcode.CMSG_BUY_BANK_SLOT, 0x0971},
            {Opcode.CMSG_BUY_ITEM, 0x01A2},
            {Opcode.CMSG_CANCEL_AURA, 0x084B},
            {Opcode.CMSG_CANCEL_CAST, 0x0F63},
            {Opcode.CMSG_CANCEL_TRADE, 0x1114},
            {Opcode.CMSG_CAN_DUEL, 0x13F2},
            {Opcode.CMSG_CAST_SPELL, 0x1B02},
            {Opcode.CMSG_CHANNEL_BAN, 0x108B},
            {Opcode.CMSG_CHANNEL_INVITE, 0x188C},
            {Opcode.CMSG_CHANNEL_KICK, 0x052B},
            {Opcode.CMSG_CHANNEL_MODERATOR, 0x0E6B},
            {Opcode.CMSG_CHANNEL_MUTE, 0x045B},
            {Opcode.CMSG_CHANNEL_PASSWORD, 0x10CA},
            {Opcode.CMSG_CHANNEL_SET_OWNER, 0x1483},
            {Opcode.CMSG_CHANNEL_UNBAN, 0x18CC},
            {Opcode.CMSG_CHANNEL_UNMODERATOR, 0x050B},
            {Opcode.CMSG_CHANNEL_UNMUTE, 0x14C2},
            {Opcode.CMSG_CHAR_CREATE, 0x133A},
            {Opcode.CMSG_CHAR_DELETE, 0x1774},
            {Opcode.CMSG_CHAR_ENUM, 0x19E3},
            {Opcode.CMSG_CLOSE_INTERACTION, 0x0A3A},
            {Opcode.CMSG_CONVERT_RAID, 0x1329},
            {Opcode.CMSG_CREATURE_QUERY, 0x007C},
            {Opcode.CMSG_DB_QUERY_BULK, 0x1731},
            {Opcode.CMSG_DELETE_EQUIPMENT_SET, 0x1599},
            {Opcode.CMSG_DEL_FRIEND, 0x1B71},
            {Opcode.CMSG_DEL_IGNORE, 0x1BB3},
            {Opcode.CMSG_DEPOSIT_REAGENT_BANK, 0x1142},
            {Opcode.CMSG_DISCARDED_TIME_SYNC_ACKS, 0x02DA},
            {Opcode.CMSG_DUEL_RESPONSE, 0x01A1},
            {Opcode.CMSG_EQUIPMENT_SET_SAVE, 0x0A7C},
            {Opcode.CMSG_GAMEOBJECT_QUERY, 0x021A},
            {Opcode.CMSG_GET_UNDELETE_COOLDOWN_STATUS, 0x196A},
            {Opcode.CMSG_GM_TICKET_CREATE, 0x19A4},
            {Opcode.CMSG_GM_TICKET_DELETE_TICKET, 0x1B39},
            {Opcode.CMSG_GM_TICKET_GET_CASE_STATUS, 0x17E1},
            {Opcode.CMSG_GM_TICKET_GET_SYSTEM_STATUS, 0x1BB9},
            {Opcode.CMSG_GM_TICKET_GET_TICKET, 0x1939},
            {Opcode.CMSG_GM_TICKET_RESPONSE_RESOLVE, 0x19FB},
            {Opcode.CMSG_GM_TICKET_UPDATE_TEXT, 0x19EB},
            {Opcode.CMSG_GOSSIP_HELLO, 0x0483},
            {Opcode.CMSG_GUILD_QUERY, 0x19B3},
            {Opcode.CMSG_GUILD_SET_ACHIEVEMENT_TRACKING, 0x039E},
            {Opcode.CMSG_JOIN_CHANNEL, 0x0C6C},
            {Opcode.CMSG_LEAVE_CHANNEL, 0x0D4C},
            {Opcode.CMSG_LEAVE_GROUP, 0x192B},
            {Opcode.CMSG_LF_GUILD_BROWSE, 0x11E4},
            {Opcode.CMSG_LIST_INVENTORY, 0x06C4},
            {Opcode.CMSG_LOAD_SCREEN, 0x13E4},
            {Opcode.CMSG_LOGOUT_REQUEST, 0x0824},
            {Opcode.CMSG_LOG_DISCONNECT, 0x1432},
            {Opcode.CMSG_MESSAGECHAT_AFK, 0x180C},
            {Opcode.CMSG_MESSAGECHAT_CHANNEL, 0x067B},
            {Opcode.CMSG_MESSAGECHAT_DND, 0x0479},
            {Opcode.CMSG_MESSAGECHAT_EMOTE, 0x0C59},
            {Opcode.CMSG_MESSAGECHAT_GUILD, 0x1A4B},
            {Opcode.CMSG_MESSAGECHAT_OFFICER, 0x1243},
            {Opcode.CMSG_MESSAGECHAT_SAY, 0x140B},
            {Opcode.CMSG_MESSAGECHAT_WHISPER, 0x100C},
            {Opcode.CMSG_MESSAGECHAT_YELL, 0x1481},
            {Opcode.CMSG_MOUNT_SET_FAVORITE, 0x15B1},
            {Opcode.CMSG_MOVE_FALL_LAND, 0x0DEA},
            {Opcode.CMSG_MOVE_HEARTBEAT, 0x01F1},
            {Opcode.CMSG_MOVE_JUMP, 0x0BCC},
            {Opcode.CMSG_MOVE_SET_FACING, 0x09CA},
            {Opcode.CMSG_MOVE_START_BACKWARD, 0x0389},
            {Opcode.CMSG_MOVE_START_FORWARD, 0x01EB},
            {Opcode.CMSG_MOVE_START_STRAFE_LEFT, 0x03D2},
            {Opcode.CMSG_MOVE_START_STRAFE_RIGHT, 0x01CB},
            {Opcode.CMSG_MOVE_START_TURN_LEFT, 0x0189},
            {Opcode.CMSG_MOVE_START_TURN_RIGHT, 0x0DAA},
            {Opcode.CMSG_MOVE_STOP, 0x0892},
            {Opcode.CMSG_MOVE_STOP_STRAFE, 0x0D8A},
            {Opcode.CMSG_MOVE_STOP_TURN, 0x05E9},
            {Opcode.CMSG_NAME_QUERY, 0x15A2},
            {Opcode.CMSG_NPC_TEXT_QUERY, 0x0E44},
            {Opcode.CMSG_OBJECT_UPDATE_RESCUED, 0x0A39},
            {Opcode.CMSG_PARTY_INVITE, 0x19E2},
            {Opcode.CMSG_PARTY_INVITE_RESPONSE, 0x157A},
            {Opcode.CMSG_PET_RENAME, 0x1333},
            {Opcode.CMSG_PING, 0x167B},
            {Opcode.CMSG_PLAYED_TIME, 0x0074},
            {Opcode.CMSG_PLAYER_LOGIN, 0x1D31},
            {Opcode.CMSG_QUERY_NEXT_MAIL_TIME, 0x1119},
            {Opcode.CMSG_QUEUED_MESSAGES_END, 0x147B},
            {Opcode.CMSG_RANDOMIZE_CHAR_NAME, 0x17FA},
            {Opcode.CMSG_REORDER_CHARACTERS, 0x1729},
            {Opcode.CMSG_REQUEST_ACCOUNT_DATA, 0x1934},
            {Opcode.CMSG_ROUTER_CLIENT_LOG_STREAMING_ERROR, 0x1439},
            {Opcode.CMSG_SAVE_CUF_PROFILES, 0x10E9},
            {Opcode.CMSG_SELL_ITEM, 0x1349},
            {Opcode.CMSG_SEND_CONTACT_LIST, 0x15F9},
            {Opcode.CMSG_SET_ACTION_BUTTON, 0x13BA},
            {Opcode.CMSG_SET_CONTACT_NOTES, 0x13AC},
            {Opcode.CMSG_SET_DUNGEON_DIFFICULTY, 0x117A},
            {Opcode.CMSG_SET_FACTION_AT_WAR, 0x05E4},
            {Opcode.CMSG_SET_FACTION_INACTIVE, 0x0821},
            {Opcode.CMSG_SET_FACTION_NOT_AT_WAR, 0x15C9},
            {Opcode.CMSG_SET_LOOT_SPECIALIZATION, 0x0B7A},
            {Opcode.CMSG_SET_PARTY_LEADER, 0x1932},
            {Opcode.CMSG_SET_RAID_DIFFICULTY, 0x1162},
            {Opcode.CMSG_SET_ROLE, 0x11B2},
            {Opcode.CMSG_SET_SELECTION, 0x0DC4},
            {Opcode.CMSG_SET_SPECIALIZATION, 0x0472},
            {Opcode.CMSG_SET_TITLE, 0x0654},
            {Opcode.CMSG_SET_WATCHED_FACTION, 0x154B},
            {Opcode.CMSG_SORT_BANK_BAGS, 0x1901},
            {Opcode.CMSG_SPLIT_ITEM, 0x0095},
            {Opcode.CMSG_SUPPORT_TICKET_SUBMIT_BUG, 0x11BB},
            {Opcode.CMSG_SUPPORT_TICKET_SUBMIT_COMPLAINT, 0x1BB1},
            {Opcode.CMSG_SUPPORT_TICKET_SUBMIT_SUGGESTION, 0x1B63},
            {Opcode.CMSG_SUSPEND_COMMS_ACK, 0x123C},
            {Opcode.CMSG_SUSPEND_TOKEN_RESPONSE, 0x1273},
            {Opcode.CMSG_SWAP_INV_ITEM, 0x00C5},
            {Opcode.CMSG_SWAP_ITEM, 0x0206},
            {Opcode.CMSG_TIME_SYNC_RESPONSE, 0x0B8C},
            {Opcode.CMSG_TOGGLE_PVP, 0x10A2},
            {Opcode.CMSG_UI_TIME_REQUEST, 0x1B7B},
            {Opcode.CMSG_UPDATE_ACCOUNT_DATA, 0x17BB},
            {Opcode.CMSG_USE_EQUIPMENT_SET, 0x0026},
            {Opcode.CMSG_USE_ITEM, 0x0A5A},
            {Opcode.CMSG_VIOLENCE_LEVEL, 0x0071},
            {Opcode.CMSG_WARDEN_DATA, 0x11E3},
            {Opcode.CMSG_WHO, 0x1B3B},
        };

        private static readonly BiDictionary<Opcode, int> ServerOpcodes = new BiDictionary<Opcode, int>
        {
            {Opcode.SMSG_ACCOUNT_CRITERIA_UPDATE, 0x0A7A},
            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x15F3},
            {Opcode.SMSG_ACCOUNT_MOUNT_UPDATE, 0x19A2},
            {Opcode.SMSG_ACCOUNT_TOYS_UPDATE, 0x1F1C},
            {Opcode.SMSG_ACTION_BUTTONS, 0x153B},
            {Opcode.SMSG_ACHIEVEMENT_DELETED, 0x0B2C},
            {Opcode.SMSG_ACHIEVEMENT_EARNED, 0x1D8C},
            {Opcode.SMSG_ADDON_INFO, 0x1F5C},
            {Opcode.SMSG_AE_LOOT_TARGETS, 0x1763},
            {Opcode.SMSG_AE_LOOT_TARGET_ACK, 0x1B9A},
            {Opcode.SMSG_AI_REACTION, 0x1BDA},
            {Opcode.SMSG_ALL_ACCOUNT_CRITERIA, 0x17AC},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA, 0x097A},
            {Opcode.SMSG_ALL_GUILD_ACHIEVEMENTS, 0x02F4},
            {Opcode.SMSG_ATTACKERSTATEUPDATE, 0x13DC},
            {Opcode.SMSG_ATTACKSTART, 0x19A4},
            {Opcode.SMSG_ATTACKSTOP, 0x171A},
            {Opcode.SMSG_ATTACKSWING_LANDED_LOG, 0x15CB},
            {Opcode.SMSG_ATTACKSWING_ERROR, 0x1F4C},
            {Opcode.SMSG_AUCTION_HELLO_RESPONSE, 0x0A29},
            {Opcode.SMSG_AUCTION_COMMAND_RESULT, 0x1972},
            {Opcode.SMSG_AUCTION_CLOSED_NOTIFICATION, 0x0B73},
            {Opcode.SMSG_AUCTION_LIST_ITEMS_RESULT, 0x09C4},
            {Opcode.SMSG_AUCTION_LIST_OWNER_ITEMS_RESULT, 0x0929},
            {Opcode.SMSG_AUCTION_LIST_BIDDER_ITEMS_RESULT, 0x1339},
            {Opcode.SMSG_AUCTION_LIST_PENDING_SALES_RESULT, 0x1F89},
            {Opcode.SMSG_AUCTION_OUTBID_NOTIFICATION, 0x0972},
            {Opcode.SMSG_AUCTION_OWNER_BID_NOTIFICATION, 0x1B09},
            {Opcode.SMSG_AUCTION_REPLICATE_RESPONSE, 0x193B},
            {Opcode.SMSG_AUCTION_WON_NOTIFICATION, 0x136B},
            {Opcode.SMSG_AURA_UPDATE, 0x070A},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x0403},
            {Opcode.SMSG_AUTH_RESPONSE, 0x0B61},
            {Opcode.SMSG_BATTLE_PAY_GET_DISTRIBUTION_LIST_RESPONSE, 0x17A3},
            {Opcode.SMSG_BATTLE_PAY_GET_PURCHASE_LIST_RESPONSE, 0x1FC9},
            {Opcode.SMSG_BATTLE_PET_CAGE_DATE_ERROR, 0x175B},
            {Opcode.SMSG_BATTLE_PET_DELETED, 0x150A},
            {Opcode.SMSG_BATTLE_PET_ERROR, 0x1599},
            {Opcode.SMSG_BATTLE_PET_HEALED, 0x093C},
            {Opcode.SMSG_BATTLE_PET_JOURNAL, 0x15AC},
            {Opcode.SMSG_BATTLE_PET_JOURNAL_LOCK_ACQUIRED, 0x13A9},
            {Opcode.SMSG_BATTLE_PET_JOURNAL_LOCK_DENIED, 0x1359},
            {Opcode.SMSG_BATTLE_PET_LICENSE_CHANGED, 0x0823},
            {Opcode.SMSG_BATTLE_PET_REVOKED, 0x0B72},
            {Opcode.SMSG_BATTLE_PET_RESTORED, 0x0E82},
            {Opcode.SMSG_BATTLE_PET_UPDATES, 0x1FCC},
            {Opcode.SMSG_BATTLE_PET_TRAP_LEVEL, 0x1BCB},
            {Opcode.SMSG_BINDPOINTUPDATE, 0x156C},
            {Opcode.SMSG_CAN_DUEL_RESULT, 0x11BB},
            {Opcode.SMSG_CHANNEL_NOTIFY, 0x1634},
            {Opcode.SMSG_CHANNEL_NOTIFY_JOINED, 0x123B},
            {Opcode.SMSG_CHANNEL_NOTIFY_LEFT, 0x143B},
            {Opcode.SMSG_CHANNEL_START, 0x0F5A},
            {Opcode.SMSG_CHARACTER_LOGIN_FAILED, 0x1722},
            {Opcode.SMSG_CHAR_CREATE, 0x13E4},
            {Opcode.SMSG_CHAR_ENUM, 0x13F2},
            {Opcode.SMSG_CHUNKED_PACKET, 0x0C23},
            {Opcode.SMSG_CLEAR_TARGET, 0x17FA},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x116C},
            {Opcode.SMSG_COMBAT_EVENT_FAILED, 0x19D9},
            {Opcode.SMSG_COMPRESSED_PACKET, 0x0689},
            {Opcode.SMSG_CONTACT_LIST, 0x15A1},
            {Opcode.SMSG_CONTACT_STATUS, 0x174C},
            {Opcode.SMSG_COIN_REMOVED, 0x11A4},
            {Opcode.SMSG_CORPSE_RECLAIM_DELAY, 0x1B9C},
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x0DC2},
            {Opcode.SMSG_CRITERIA_UPDATE, 0x115A},
            {Opcode.SMSG_CRITERIA_DELETED, 0x0B2A},
            {Opcode.SMSG_DANCE_STUDIO_CREATE_RESULT, 0x15F2},
            {Opcode.SMSG_DB_REPLY, 0x097C},
            {Opcode.SMSG_DEFENSE_MESSAGE, 0x14F1},
            {Opcode.SMSG_DISMOUNT, 0x1371},
            {Opcode.SMSG_DISPLAY_PROMOTION, 0x01E2},
            {Opcode.SMSG_DUEL_COUNTDOWN, 0x1B1A},
            {Opcode.SMSG_DUEL_REQUESTED, 0x0983},
            {Opcode.SMSG_EMOTE, 0x171C},
            {Opcode.SMSG_ENVIRONMENTALDAMAGELOG, 0x0679},
            {Opcode.SMSG_EQUIPMENT_SET_LIST, 0x111A},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x13F3},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS_GLUE_SCREEN, 0x117A},
            {Opcode.SMSG_FINAL_CHUNK, 0x0C14},
            {Opcode.SMSG_FLIGHT_SPLINE_SYNC, 0x0272},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x1559},
            {Opcode.SMSG_GM_TICKET_CASE_STATUS, 0x086B},
            {Opcode.SMSG_GM_TICKET_GET_TICKET_RESPONSE, 0x0183},
            {Opcode.SMSG_GM_TICKET_RESOLVE_RESPONSE, 0x0869},
            {Opcode.SMSG_GM_TICKET_RESPONSE, 0x1729},
            {Opcode.SMSG_GM_TICKET_RESPONSE_ERROR, 0x0A33},
            {Opcode.SMSG_GM_TICKET_STATUS_UPDATE, 0x0B74},
            {Opcode.SMSG_GM_TICKET_SYSTEM_STATUS, 0x134C},
            {Opcode.SMSG_GM_TICKET_UPDATE, 0x193A},
            {Opcode.SMSG_GOSSIP_MESSAGE, 0x0117},
            {Opcode.SMSG_GROUP_NEW_LEADER, 0x1BF1},
            {Opcode.SMSG_GUILD_ACHIEVEMENT_DELETED, 0x07B3},
            {Opcode.SMSG_GUILD_ACHIEVEMENT_EARNED, 0x00F3},
            {Opcode.SMSG_GUILD_ACHIEVEMENT_MEMBERS, 0x0B93},
            {Opcode.SMSG_GUILD_CRITERIA_DELETED, 0x09B4},
            {Opcode.SMSG_GUILD_CRITERIA_UPDATE, 0x03D4},
            {Opcode.SMSG_GUILD_COMMAND_RESULT, 0x0B94},
            {Opcode.SMSG_GUILD_QUERY_RESPONSE, 0x06F3},
            {Opcode.SMSG_HOTFIX_NOTIFY_BLOB, 0x19B9},
            {Opcode.SMSG_INITIALIZE_FACTIONS, 0x06C3},
            {Opcode.SMSG_INITIAL_SPELLS, 0x12C2},
            {Opcode.SMSG_INIT_WORLD_STATES, 0x11F9},
            {Opcode.SMSG_LEARNED_SPELLS, 0x08E9},
            {Opcode.SMSG_LEVELUP_INFO, 0x092C},
            {Opcode.SMSG_LIST_INVENTORY, 0x17A1},
            {Opcode.SMSG_LOAD_CUF_PROFILES, 0x17EA},
            {Opcode.SMSG_LOGIN_SETTIMESPEED, 0x1573},
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x0B31},
            {Opcode.SMSG_LOGOUT_CANCEL_ACK, 0x1D8A},
            {Opcode.SMSG_LOGOUT_COMPLETE, 0x17AA},
            {Opcode.SMSG_LOGOUT_RESPONSE, 0x05C3},
            {Opcode.SMSG_LOOT_CONTENTS, 0x1334},
            {Opcode.SMSG_LOOT_LIST, 0x05A1},
            {Opcode.SMSG_LOOT_MONEY_NOTIFY, 0x1B23},
            {Opcode.SMSG_LOOT_RELEASE, 0x1789},
            {Opcode.SMSG_LOOT_RELEASE_ALL, 0x1B59},
            {Opcode.SMSG_LOOT_REMOVED, 0x17E9},
            {Opcode.SMSG_LOOT_RESPONSE, 0x1939},
            {Opcode.SMSG_MESSAGECHAT, 0x1472},
            {Opcode.SMSG_MOTD, 0x12FB},
            {Opcode.SMSG_MOVE_SET_FLIGHT_BACK_SPEED, 0x0752},
            {Opcode.SMSG_MOVE_SET_FLIGHT_SPEED, 0x0324},
            {Opcode.SMSG_MOVE_SET_PITCH_RATE, 0x0D21},
            {Opcode.SMSG_MOVE_SET_RUN_BACK_SPEED, 0x0019},
            {Opcode.SMSG_MOVE_SET_RUN_SPEED, 0x0363},
            {Opcode.SMSG_MOVE_SET_SWIM_BACK_SPEED, 0x0021},
            {Opcode.SMSG_MOVE_SET_SWIM_SPEED, 0x0432},
            {Opcode.SMSG_MOVE_SET_TURN_RATE, 0x0E74},
            {Opcode.SMSG_MOVE_SET_WALK_SPEED, 0x024A},
            {Opcode.SMSG_MOVE_UPDATE, 0x1514},
            {Opcode.SMSG_MOVE_UPDATE_COLLISION_HEIGHT, 0x0624},
            {Opcode.SMSG_MOVE_UPDATE_FLIGHT_BACK_SPEED, 0x036B},
            {Opcode.SMSG_MOVE_UPDATE_FLIGHT_SPEED, 0x0D72},
            {Opcode.SMSG_MOVE_UPDATE_PITCH_RATE, 0x0372},
            {Opcode.SMSG_MOVE_UPDATE_REMOVE_MOVEMENT_FORCE, 0x13D1},
            {Opcode.SMSG_MOVE_UPDATE_RUN_BACK_SPEED, 0x012A},
            {Opcode.SMSG_MOVE_UPDATE_RUN_SPEED, 0x015B},
            {Opcode.SMSG_MOVE_UPDATE_SWIM_BACK_SPEED, 0x0223},
            {Opcode.SMSG_MOVE_UPDATE_SWIM_SPEED, 0x016B},
            {Opcode.SMSG_MOVE_UPDATE_TURN_RATE, 0x084A},
            {Opcode.SMSG_MOVE_UPDATE_WALK_SPEED, 0x0A19},
            {Opcode.SMSG_MULTIPLE_PACKETS, 0x0C33},
            {Opcode.SMSG_NAME_QUERY_RESPONSE, 0x11A9},
            {Opcode.SMSG_NEW_WORLD, 0x190B},
            {Opcode.SMSG_ON_MONSTER_MOVE, 0x0B09},
            {Opcode.SMSG_PARTY_INVITE, 0x1F9C},
            {Opcode.SMSG_PET_GUIDS, 0x198A},
            {Opcode.SMSG_PET_NAME_QUERY_RESPONSE, 0x15A9},
            {Opcode.SMSG_PET_STABLE_LIST, 0x04E2},
            {Opcode.SMSG_PLAY_OBJECT_SOUND, 0x1BB9},
            {Opcode.SMSG_PLAY_SOUND, 0x1B79},
            {Opcode.SMSG_PLAYED_TIME, 0x0B71},
            {Opcode.SMSG_PONG, 0x0C34},
            {Opcode.SMSG_POWER_UPDATE, 0x1B0A},
            {Opcode.SMSG_PVP_SEASON, 0x13A1},
            {Opcode.SMSG_QUERY_BATTLE_PET_NAME_RESPONSE, 0x0584},
            {Opcode.SMSG_QUESTGIVER_STATUS_MULTIPLE, 0x030F},
            {Opcode.SMSG_QUEST_QUERY_RESPONSE, 0x0508},
            {Opcode.SMSG_RANDOMIZE_CHAR_NAME, 0x195B},
            {Opcode.SMSG_REDIRECT_CLIENT, 0x0413},
            {Opcode.SMSG_RESUME_COMMS, 0x068A},
            {Opcode.SMSG_RESPOND_INSPECT_ACHIEVEMENTS, 0x0974},
            {Opcode.SMSG_SEND_SPELL_CHARGES, 0x0CEB},
            {Opcode.SMSG_SEND_SPELL_HISTORY, 0x168C},
            {Opcode.SMSG_SEND_UNLEARN_SPELLS, 0x16CC},
            {Opcode.SMSG_SETUP_CURRENCY, 0x0969},
            {Opcode.SMSG_SET_FLAT_SPELL_MODIFIER, 0x0E59},
            {Opcode.SMSG_SET_PHASE_SHIFT_CHANGE, 0x17F9},
            {Opcode.SMSG_SET_PROFICIENCY, 0x092A},
            {Opcode.SMSG_SET_TIME_ZONE_INFORMATION, 0x15B4},
            {Opcode.SMSG_SET_VEHICLE_REC_ID, 0x0971},
            {Opcode.SMSG_SET_VIGNETTE, 0x11E4},
            {Opcode.SMSG_SERVER_FIRST_ACHIEVEMENTS, 0x0834},
            {Opcode.SMSG_SPELL_EXECUTE_LOG, 0x044C},
            {Opcode.SMSG_SPELL_GO, 0x1281},
            {Opcode.SMSG_SPELL_HEAL_LOG, 0x1043},
            {Opcode.SMSG_SPELL_START, 0x0629},
            {Opcode.SMSG_SUSPEND_COMMS, 0x068B},
            {Opcode.SMSG_SUSPEND_TOKEN, 0x1BB4},
            {Opcode.SMSG_TALENTS_INFO, 0x04C4},
            {Opcode.SMSG_TIME_SYNC_REQ, 0x0A01},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x0A39},
            {Opcode.SMSG_UI_TIME, 0x05E3},
            {Opcode.SMSG_UNDELETE_COOLDOWN_STATUS_RESPONSE, 0x1DDB},
            {Opcode.SMSG_UPDATE_ACCOUNT_DATA, 0x093B},
            {Opcode.SMSG_UPDATE_OBJECT, 0x1762},
            {Opcode.SMSG_UPDATE_WORLD_STATE, 0x15BA},
            {Opcode.SMSG_WARDEN_DATA, 0x110A},
            {Opcode.SMSG_WEATHER, 0x0939},
            {Opcode.SMSG_WEEKLY_SPELL_USAGE, 0x0CEC},
            {Opcode.SMSG_WHO, 0x14F2},
            {Opcode.SMSG_WORLD_SERVER_INFO, 0x0864},
        };

        private static readonly BiDictionary<Opcode, int> MiscOpcodes = new BiDictionary<Opcode, int>();
    }
}
