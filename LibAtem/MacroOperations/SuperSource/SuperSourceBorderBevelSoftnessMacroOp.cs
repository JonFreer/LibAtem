using LibAtem.Commands;
using LibAtem.Commands.SuperSource;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.MacroOperations.SuperSource
{
    [MacroOperation(MacroOperationType.SuperSourceBorderBevelSoftness, 8)]
    public class SuperSourceBorderBevelSoftnessMacroOp : SuperSourceMacroOpBase
    {
        [Serialize(4), UInt8Range(0, 100)]
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