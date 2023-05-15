using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V3_4_0_45166.UpdateFields.V3_4_0_45166
{
    public class ScaleCurve : IScaleCurve
    {
        public System.Nullable<uint> StartTimeOffset { get; set; }
        public Vector2[] Points { get; } = new Vector2[2];
        public System.Nullable<uint> ParameterCurve { get; set; }
        public System.Nullable<bool> OverrideActive { get; set; }
    }
}

