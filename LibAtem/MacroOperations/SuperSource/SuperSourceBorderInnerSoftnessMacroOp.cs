using LibAtem.Commands;
using LibAtem.Commands.SuperSource;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.MacroOperations.SuperSource
{
    [MacroOperation(MacroOperationType.SuperSourceBorderInnerSoftness, 8)]
    public class SuperSourceBorderInnerSoftnessMacroOp : SuperSourceMacroOpBase
    {
        [Serialize(4), UInt8Range(0, 100)]
        [MacroField("InnerSoftness")]
        public uint InnerSoftness { get; set; }

        public override ICommand ToCommand()
        {
            return new SuperSourceBorderSetCommand()
            {
                Mask = SuperSourceBorderSetCommand.MaskFlags.BorderInnerSoftness,
                SSrcId = SSrcId,
                BorderInnerSoftness = InnerSoftness,
            };
        }
    }
}