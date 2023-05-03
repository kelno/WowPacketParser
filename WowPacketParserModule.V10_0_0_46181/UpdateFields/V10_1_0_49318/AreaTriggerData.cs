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
        public System.Nullable<uint> Field_B0 { get; set; }
        public System.Nullable<int> SpellID { get; set; }
        public System.Nullable<int> SpellForVisuals { get; set; }
        public ISpellCastVisual SpellVisual { get; set; }
        public System.Nullable<float> BoundsRadius2D { get; set; }
        public System.Nullable<uint> DecalPropertiesID { get; set; }
        public WowGuid CreatingEffectGUID { get; set; }
        public System.Nullable<uint> Field_80 { get; set; }
        public System.Nullable<uint> Field_84 { get; set; }
        public WowGuid Field_88 { get; set; }
        public Vector3 Field_F8 { get; set; }
        public IScaleCurve OverrideScaleCurve { get; set; }
        public IScaleCurve ExtraScaleCurve { get; set; }
        public IScaleCurve Field_C38 { get; set; }
        public IScaleCurve Field_C54 { get; set; }
        public IScaleCurve Field_C70 { get; set; }
        public IVisualAnim VisualAnim { get; set; }
        public System.Nullable<bool> Field_260 { get; set; }
        public System.Nullable<bool> Field_261 { get; set; }
    }
}

