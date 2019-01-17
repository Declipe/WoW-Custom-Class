﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SpellEditor.Sources.DBC
{
    class SpellDBC : AbstractDBC
    {
        public SpellDBC(string path)
        {
            ReadDBCFile<Spell_DBC_Record>(path);
        }

        public Dictionary<string, object>[] GetAllRecords()
        {
            return Body.RecordMaps;
        }

        public string LookupString(uint offset)
        {
            return LookupStringOffset(offset);
        }

        [Serializable()]
        public struct Spell_DBC_Record
        {
            // These fields are used through reflection, disable warning
#pragma warning disable 0649
#pragma warning disable 0169
            public uint ID;
            public uint Category;
            public uint Dispel;
            public uint Mechanic;
            public uint Attributes;
            public uint AttributesEx;
            public uint AttributesEx2;
            public uint AttributesEx3;
            public uint AttributesEx4;
            public uint AttributesEx5;
            public uint AttributesEx6;
            public uint AttributesEx7;
            public uint Stances;
            public uint Unknown1;
            public uint StancesNot;
            public uint Unknown2;
            public uint Targets;
            public uint TargetCreatureType;
            public uint RequiresSpellFocus;
            public uint FacingCasterFlags;
            public uint CasterAuraState;
            public uint TargetAuraState;
            public uint CasterAuraStateNot;
            public uint TargetAuraStateNot;
            public uint CasterAuraSpell;
            public uint TargetAuraSpell;
            public uint ExcludeCasterAuraSpell;
            public uint ExcludeTargetAuraSpell;
            public uint CastingTimeIndex;
            public uint RecoveryTime;
            public uint CategoryRecoveryTime;
            public uint InterruptFlags;
            public uint AuraInterruptFlags;
            public uint ChannelInterruptFlags;
            public uint ProcFlags;
            public uint ProcChance;
            public uint ProcCharges;
            public uint MaximumLevel;
            public uint BaseLevel;
            public uint SpellLevel;
            public uint DurationIndex;
            public uint PowerType;
            public uint ManaCost;
            public uint ManaCostPerLevel;
            public uint ManaPerSecond;
            public uint ManaPerSecondPerLevel;
            public uint RangeIndex;
            public float Speed;
            public uint ModalNextSpell;
            public uint StackAmount;
            public uint Totem1;
            public uint Totem2;
            public int Reagent1;
            public int Reagent2;
            public int Reagent3;
            public int Reagent4;
            public int Reagent5;
            public int Reagent6;
            public int Reagent7;
            public int Reagent8;
            public uint ReagentCount1;
            public uint ReagentCount2;
            public uint ReagentCount3;
            public uint ReagentCount4;
            public uint ReagentCount5;
            public uint ReagentCount6;
            public uint ReagentCount7;
            public uint ReagentCount8;
            public int EquippedItemClass;
            public int EquippedItemSubClassMask;
            public int EquippedItemInventoryTypeMask;
            public uint Effect1;
            public uint Effect2;
            public uint Effect3;
            public int EffectDieSides1;
            public int EffectDieSides2;
            public int EffectDieSides3;
            public float EffectRealPointsPerLevel1;
            public float EffectRealPointsPerLevel2;
            public float EffectRealPointsPerLevel3;
            public int EffectBasePoints1;
            public int EffectBasePoints2;
            public int EffectBasePoints3;
            public uint EffectMechanic1;
            public uint EffectMechanic2;
            public uint EffectMechanic3;
            public uint EffectImplicitTargetA1;
            public uint EffectImplicitTargetA2;
            public uint EffectImplicitTargetA3;
            public uint EffectImplicitTargetB1;
            public uint EffectImplicitTargetB2;
            public uint EffectImplicitTargetB3;
            public uint EffectRadiusIndex1;
            public uint EffectRadiusIndex2;
            public uint EffectRadiusIndex3;
            public uint EffectApplyAuraName1;
            public uint EffectApplyAuraName2;
            public uint EffectApplyAuraName3;
            public uint EffectAmplitude1;
            public uint EffectAmplitude2;
            public uint EffectAmplitude3;
            public float EffectMultipleValue1;
            public float EffectMultipleValue2;
            public float EffectMultipleValue3;
            public uint EffectChainTarget1;
            public uint EffectChainTarget2;
            public uint EffectChainTarget3;
            public uint EffectItemType1;
            public uint EffectItemType2;
            public uint EffectItemType3;
            public int EffectMiscValue1;
            public int EffectMiscValue2;
            public int EffectMiscValue3;
            public int EffectMiscValueB1;
            public int EffectMiscValueB2;
            public int EffectMiscValueB3;
            public uint EffectTriggerSpell1;
            public uint EffectTriggerSpell2;
            public uint EffectTriggerSpell3;
            public float EffectPointsPerComboPoint1;
            public float EffectPointsPerComboPoint2;
            public float EffectPointsPerComboPoint3;
            public uint EffectSpellClassMaskA1;
            public uint EffectSpellClassMaskA2;
            public uint EffectSpellClassMaskA3;
            public uint EffectSpellClassMaskB1;
            public uint EffectSpellClassMaskB2;
            public uint EffectSpellClassMaskB3;
            public uint EffectSpellClassMaskC1;
            public uint EffectSpellClassMaskC2;
            public uint EffectSpellClassMaskC3;
            public uint SpellVisual1;
            public uint SpellVisual2;
            public uint SpellIconID;
            public uint ActiveIconID;
            public uint SpellPriority;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public uint[] SpellName;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public uint[] SpellNameFlag;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public uint[] SpellRank;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public uint[] SpellRankFlags;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public uint[] SpellDescription;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public uint[] SpellDescriptionFlags;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public uint[] SpellToolTip;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public uint[] SpellToolTipFlags;
            public uint ManaCostPercentage;
            public uint StartRecoveryCategory;
            public uint StartRecoveryTime;
            public uint MaximumTargetLevel;
            public uint SpellFamilyName;
            public uint SpellFamilyFlags;
            public uint SpellFamilyFlags1;
            public uint SpellFamilyFlags2;
            public uint MaximumAffectedTargets;
            public uint DamageClass;
            public uint PreventionType;
            public uint StanceBarOrder;
            public float EffectDamageMultiplier1;
            public float EffectDamageMultiplier2;
            public float EffectDamageMultiplier3;
            public uint MinimumFactionId;
            public uint MinimumReputation;
            public uint RequiredAuraVision;
            public uint TotemCategory1;
            public uint TotemCategory2;
            public uint AreaGroupID;
            public uint SchoolMask;
            public uint RuneCostID;
            public uint SpellMissileID;
            public uint PowerDisplayId;
            public float EffectBonusMultiplier1;
            public float EffectBonusMultiplier2;
            public float EffectBonusMultiplier3;
            public uint SpellDescriptionVariableID;
            public uint SpellDifficultyID;
#pragma warning restore 0649
#pragma warning restore 0169
        };
    }
}
