﻿using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;

namespace WowPacketParserModule.V7_0_3_22248.Parsers
{
    public static class BattlePayHandler
    {
        [Parser(Opcode.SMSG_BATTLE_PAY_ACK_FAILED)]
        [Parser(Opcode.SMSG_BATTLE_PAY_BATTLE_PET_DELIVERED)]
        [Parser(Opcode.SMSG_BATTLE_PAY_COLLECTION_ITEM_DELIVERED)]
        [Parser(Opcode.SMSG_BATTLE_PAY_CONFIRM_PURCHASE)]
        [Parser(Opcode.SMSG_BATTLE_PAY_DELIVERY_ENDED)]
        [Parser(Opcode.SMSG_BATTLE_PAY_DELIVERY_STARTED)]
        [Parser(Opcode.SMSG_BATTLE_PAY_DISTRIBUTION_UNREVOKED)]
        [Parser(Opcode.SMSG_BATTLE_PAY_DISTRIBUTION_UPDATE)]
        [Parser(Opcode.SMSG_BATTLE_PAY_GET_DISTRIBUTION_LIST_RESPONSE)]
        [Parser(Opcode.SMSG_BATTLE_PAY_GET_PRODUCT_LIST_RESPONSE)]
        [Parser(Opcode.SMSG_BATTLE_PAY_GET_PURCHASE_LIST_RESPONSE)]
        [Parser(Opcode.SMSG_BATTLE_PAY_MOUNT_DELIVERED)]
        [Parser(Opcode.SMSG_BATTLE_PAY_PURCHASE_UPDATE)]
        [Parser(Opcode.SMSG_BATTLE_PAY_START_CHECKOUT)]
        [Parser(Opcode.SMSG_BATTLE_PAY_START_DISTRIBUTION_ASSIGN_TO_TARGET_RESPONSE)]
        [Parser(Opcode.SMSG_BATTLE_PAY_START_PURCHASE_RESPONSE)]
        [Parser(Opcode.SMSG_BATTLE_PAY_VALIDATE_PURCHASE_RESPONSE)]
        [Parser(Opcode.CMSG_BATTLE_PAY_START_VAS_PURCHASE)]
        [Parser(Opcode.CMSG_GET_VAS_ACCOUNT_CHARACTER_LIST)]
        [Parser(Opcode.CMSG_GET_VAS_TRANSFER_TARGET_REALM_LIST)]
        [Parser(Opcode.CMSG_UPDATE_VAS_PURCHASE_STATES)]
        [Parser(Opcode.CMSG_VAS_CHECK_TRANSFER_OK)]
        [Parser(Opcode.CMSG_VAS_GET_QUEUE_MINUTES)]
        [Parser(Opcode.CMSG_VAS_GET_SERVICE_STATUS)]
        [Parser(Opcode.SMSG_BATTLE_PAY_VAS_GUILD_FOLLOW_INFO)]
        [Parser(Opcode.SMSG_BATTLE_PAY_VAS_GUILD_MASTER_LIST)]
        [Parser(Opcode.SMSG_ENUM_VAS_PURCHASE_STATES_RESPONSE)]
        [Parser(Opcode.SMSG_GET_VAS_ACCOUNT_CHARACTER_LIST_RESULT)]
        [Parser(Opcode.SMSG_GET_VAS_TRANSFER_TARGET_REALM_LIST_RESULT)]
        [Parser(Opcode.SMSG_VAS_CHECK_TRANSFER_OK_RESPONSE)]
        [Parser(Opcode.SMSG_VAS_GET_QUEUE_MINUTES_RESPONSE)]
        [Parser(Opcode.SMSG_VAS_GET_SERVICE_STATUS_RESPONSE)]
        [Parser(Opcode.SMSG_VAS_PURCHASE_COMPLETE)]
        [Parser(Opcode.SMSG_VAS_PURCHASE_STATE_UPDATE)]
        public static void HandleBattlePay(Packet packet)
        {
            packet.ReadToEnd();
        }
    }
}
