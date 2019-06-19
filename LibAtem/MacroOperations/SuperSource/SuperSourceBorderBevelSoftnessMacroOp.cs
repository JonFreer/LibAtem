﻿using LibAtem.Commands;
using LibAtem.Commands.SuperSource;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.MacroOperations.SuperSource
{
    [MacroOperation(MacroOperationType.SuperSourceBorderBevelSoftness, 8)]
    public class SuperSourceBorderBevelSoftnessMacroOp : MacroOpBase
    {
        [Serialize(4), UInt8Range(0, 100)]
        [MacroField("BevelSoftness")]
        public uint BevelSoftness { get; set; }

        public override ICommand ToCommand()
        {
            return new SuperSourceBorderSetCommand()
            {
                Mask = SuperSourceBorderSetCommand.MaskFlags.BorderBevelSoftness,
                SSrcId = SuperSourceId.One,
                BorderBevelSoftness = BevelSoftness,
            };
        }
    }

    [MacroOperation(MacroOperationType.SuperSourceV2BorderBevelSoftness, 8)]
    public class SuperSourceV2BorderBevelSoftnessMacroOp : SuperSourceMacroOpBase
    {
        [Serialize(6), UInt8Range(0, 100)]
        [MacroField("BevelSoftness")]
        public uint BevelSoftness { get; set; }

        public override ICommand ToCommand()
        {
            return new SuperSourceBorderSetCommand()
            {
                Mask = SuperSourceBorderSetCommand.MaskFlags.BorderBevelSoftness,
                SSrcId = SSrcId,
                BorderBevelSoftness = BevelSoftness,
            };
        }
    }
}