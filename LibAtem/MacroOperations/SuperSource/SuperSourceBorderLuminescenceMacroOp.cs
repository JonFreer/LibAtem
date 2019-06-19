﻿using LibAtem.Commands;
using LibAtem.Commands.SuperSource;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.MacroOperations.SuperSource
{
    [MacroOperation(MacroOperationType.SuperSourceBorderLuminescence, 8)]
    public class SuperSourceBorderLuminescenceMacroOp : SuperSourceMacroOpBase
    {
        [Serialize(4), UInt32DScale]
        [MacroField("Luma")]
        public double Luma { get; set; }

        public override ICommand ToCommand()
        {
            return new SuperSourceBorderSetCommand()
            {
                Mask = SuperSourceBorderSetCommand.MaskFlags.BorderLuma,
                SSrcId = SSrcId,
                BorderLuma = Luma,
            };
        }
    }
}