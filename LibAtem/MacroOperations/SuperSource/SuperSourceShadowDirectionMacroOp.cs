using LibAtem.Commands;
using LibAtem.Commands.SuperSource;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.MacroOperations.SuperSource
{
    [MacroOperation(MacroOperationType.SuperSourceShadowDirection, 8)]
    public class SuperSourceShadowDirectionMacroOp : SuperSourceMacroOpBase
    {
        [Serialize(4), UInt32D(65536, 0, 65536 * 360)]
        [MacroField("Direction")]
        public double Direction { get; set; }

        public override ICommand ToCommand()
        {
            return new SuperSourceBorderSetCommand()
            {
                Mask = SuperSourceBorderSetCommand.MaskFlags.BorderLightSourceDirection,
                SSrcId = SSrcId,
                BorderLightSourceDirection = Direction,
            };
        }
    }
}