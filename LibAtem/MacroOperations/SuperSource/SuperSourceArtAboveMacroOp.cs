using LibAtem.Commands;
using LibAtem.Commands.SuperSource;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.MacroOperations.SuperSource
{
    [MacroOperation(MacroOperationType.SuperSourceArtAbove, 8)]
    public class SuperSourceArtAboveMacroOp : SuperSourceMacroOpBase
    {
        [Serialize(4), Bool]
        [MacroField("SuperSourceArtAbove", "artAbove")]
        public bool ArtAbove { get; set; }

        public override ICommand ToCommand()
        {
            return new SuperSourcePropertiesSetCommand()
            {
                Mask = SuperSourcePropertiesSetCommand.MaskFlags.ArtOption,
                SSrcId = SSrcId,
                ArtOption = ArtAbove ? SuperSourceArtOption.Foreground : SuperSourceArtOption.Background,
            };
        }
    }
}