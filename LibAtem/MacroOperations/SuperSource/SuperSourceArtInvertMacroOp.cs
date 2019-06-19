﻿using LibAtem.Commands;
using LibAtem.Commands.SuperSource;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.MacroOperations.SuperSource
{
    [MacroOperation(MacroOperationType.SuperSourceArtInvert, 8)]
    public class SuperSourceArtInvertMacroOp : SuperSourceMacroOpBase
    {
        [Serialize(4), Bool]
        [MacroField("Invert")]
        public bool Invert { get; set; }

        public override ICommand ToCommand()
        {
            return new SuperSourcePropertiesSetCommand()
            {
                Mask = SuperSourcePropertiesSetCommand.MaskFlags.ArtInvertKey,
                SSrcId = SSrcId,
                ArtInvertKey = Invert,
            };
        }
    }
}