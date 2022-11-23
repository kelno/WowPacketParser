using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V10_0_0_46181.UpdateFields.V10_0_2_46479
{
    public class ConversationData : IMutableConversationData
    {
        public System.Nullable<int> LastLineEndTime { get; set; }
        public System.Nullable<uint> Progress { get; set; }
        public IConversationLine[] Lines { get; set; }
        public System.Nullable<uint> Flags { get; set; }
        public System.Nullable<bool> DontPlayBroadcastTextSounds { get; set; }
        public DynamicUpdateField<IConversationActor> Actors { get; } = new DynamicUpdateField<IConversationActor>();
    }
}

