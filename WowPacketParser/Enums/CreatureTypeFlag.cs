using System;

namespace WowPacketParser.Enums
{
    [Flags]
    public enum CreatureTypeFlag : uint
    {
        None                          = 0x00000000,
        Tameable                      = 0x00000001,
        VisibleToGhosts               = 0x00000002,
        BossMob                       = 0x00000004,
        DoNotPlayWoundAnim            = 0x00000008,
        NoFactionTooltip              = 0x00000010,
        MoreAudible                   = 0x00000020, // sound related
        SpellAttackable               = 0x00000040,
        InteractWhileDead             = 0x00000080,
        SkinWithHerbalism             = 0x00000100,
        SkinWithMining                = 0x00000200,
        NoDeathMessage                = 0x00000400,
        AllowMountedCombat            = 0x00000800,
        CanAssist                     = 0x00001000,
        NoPetBar                      = 0x00002000,
        MaskUID                       = 0x00004000,
        SkinWithEngineering           = 0x00008000,
        TameableExotic                = 0x00010000,
        UseModelCollisionSize         = 0x00020000,
        AllowInteractionWhileInCombat = 0x00040000,
        CollideWithMissiles           = 0x00080000,
        NoNamePlate                   = 0x00100000,
        DoNotPlayMountedAnimations    = 0x00200000,
        LinkAll                       = 0x00400000,
        InteractOnlyWithCreator       = 0x00800000,
        DoNotPlayUnitEventSounds      = 0x01000000,
        HasNoShadowBlob               = 0x02000000,
        TreatAsRaidUnit               = 0x04000000,
        ForceGossip                   = 0x08000000,
        DoNotSheathe                  = 0x10000000,
        DoNotTargetOnInteraction      = 0x20000000,
        DoNotRenderObjectName         = 0x40000000,
        QuestBoss                     = 0x80000000 // not verified
    }
}
