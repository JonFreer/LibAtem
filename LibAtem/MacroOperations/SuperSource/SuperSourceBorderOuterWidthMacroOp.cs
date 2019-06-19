using LibAtem.Commands;
using LibAtem.Commands.SuperSource;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.MacroOperations.SuperSource
{
    [MacroOperation(MacroOperationType.SuperSourceBorderOuterWidth, 8)]
    public class SuperSourceBorderOuterWidthMacroOp : SuperSourceMacroOpBase
    {
        [Serialize(4), UInt32D(65536, 0, 16 * 65536)]
        [MacroField("OuterWidth")]
        public double OuterWidth { get; set; }

        public override ICommand ToCommand()
        {
            return new SuperSourceBorderSetCommand()
            {
                Mask = SuperSourceBorderSetCommand.MaskFlags.BorderOuterWidth,
                SSrcId = SSrcId,
                BorderOuterWidth = OuterWidth,
            };
        }
    }
}