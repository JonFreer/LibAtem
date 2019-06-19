using LibAtem.Commands;
using LibAtem.Commands.SuperSource;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.MacroOperations.SuperSource
{
    [MacroOperation(MacroOperationType.SuperSourceBorderInnerWidth, 8)]
    public class SuperSourceBorderInnerWidthMacroOp : SuperSourceMacroOpBase
    {
        [Serialize(4), UInt32D(65536, 0, 16 * 65536)]
        [MacroField("InnerWidth")]
        public double InnerWidth { get; set; }

        public override ICommand ToCommand()
        {
            return new SuperSourceBorderSetCommand()
            {
                Mask = SuperSourceBorderSetCommand.MaskFlags.BorderInnerWidth,
                SSrcId = SSrcId,
                BorderInnerWidth = InnerWidth,
            };
        }
    }
}