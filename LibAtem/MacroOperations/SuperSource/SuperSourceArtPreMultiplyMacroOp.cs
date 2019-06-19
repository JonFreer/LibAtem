using LibAtem.Commands;
using LibAtem.Commands.SuperSource;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.MacroOperations.SuperSource
{
    [MacroOperation(MacroOperationType.SuperSourceArtPreMultiply, 8)]
    public class SuperSourceArtPreMultiplyMacroOp : SuperSourceMacroOpBase
    {
        [Serialize(4), Bool]
        [MacroField("PreMultiply")]
        public bool PreMultiply { get; set; }

        public override ICommand ToCommand()
        {
            return new SuperSourcePropertiesSetCommand()
            {
                Mask = SuperSourcePropertiesSetCommand.MaskFlags.ArtPreMultiplied,
                SSrcId = SSrcId,
                ArtPreMultiplied = PreMultiply,
            };
        }
    }
}