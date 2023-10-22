using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V10_0_0_46181.UpdateFields.V10_1_0_49318
{
    public class AreaTriggerData : IAreaTriggerData
    {
        public WowGuid Caster { get; set; }
        public System.Nullable<uint> Duration { get; set; }
        public System.Nullable<uint> TimeToTarget { get; set; }
        public System.Nullable<uint> TimeToTargetScale { get; set; }
        public System.Nullable<uint> TimeToTargetExtraScale { get; set; }
        public System.Nullable<uint> TimeToTargetPos { get; set; }
        public System.Nullable<int> SpellID { get; set; }
        public System.Nullable<int> SpellForVisuals { get; set; }
        public ISpellCastVisual SpellVisual { get; set; }
        public System.Nullable<float> BoundsRadius2D { get; set; }
        public System.Nullable<uint> DecalPropertiesID { get; set; }
        public WowGuid CreatingEffectGUID { get; set; }
        public System.Nullable<uint> NumUnitsInside { get; set; }
        public System.Nullable<uint> NumPlayersInside { get; set; }
        public WowGuid OrbitPathTarget { get; set; }
        public Vector3 RollPitchYaw { get; set; }
        public IScaleCurve OverrideScaleCurve { get; set; }
        public IScaleCurve ExtraScaleCurve { get; set; }
        public IScaleCurve OverrideMoveCurveX { get; set; }
        public IScaleCurve OverrideMoveCurveY { get; set; }
        public IScaleCurve OverrideMoveCurveZ { get; set; }
        public IVisualAnim VisualAnim { get; set; }
        public System.Nullable<bool> HeightIgnoresScale { get; set; }
        public System.Nullable<bool> Field_261 { get; set; }
    }
}

