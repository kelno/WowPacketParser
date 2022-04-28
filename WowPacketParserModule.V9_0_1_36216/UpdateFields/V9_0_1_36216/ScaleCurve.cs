using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

namespace WowPacketParserModule.V9_0_1_36216.UpdateFields.V9_0_1_36216
{
    public class ScaleCurve : IScaleCurve
    {
        public uint StartTimeOffset { get; set; }
        public Vector2[] Points { get; } = new Vector2[2];
        public uint ParameterCurve { get; set; }
        public bool OverrideActive { get; set; }
    }
}

