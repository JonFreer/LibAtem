using LibAtem.Commands;
using LibAtem.Commands.SuperSource;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.MacroOperations.SuperSource
{
    [MacroOperation(MacroOperationType.SuperSourceBorderEnable, 8)]
    public class SuperSourceBorderEnableMacroOp : SuperSourceMacroOpBase
    {
        [Serialize(4), Bool]
        [MacroField("Enable")]
        public bool Enable { get; set; }

        public override ICommand ToCommand()
        {
            return new SuperSourceBorderSetCommand()
            {
                Mask = SuperSourceBorderSetCommand.MaskFlags.BorderEnabled,
                SSrcId = SSrcId,
                BorderEnabled = Enable,
            };
        }
    }
}