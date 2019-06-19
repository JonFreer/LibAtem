using LibAtem.Commands;
using LibAtem.Commands.SuperSource;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.MacroOperations.SuperSource
{
    [MacroOperation(MacroOperationType.SuperSourceArtFillInput, 8)]
    public class SuperSourceArtFillInputMacroOp : MacroOpBase
    {
        [Serialize(4), Enum16]
        [MacroField("Input")]
        public VideoSource Source { get; set; }

        public override ICommand ToCommand()
        {
            return new SuperSourcePropertiesSetCommand()
            {
                Mask = SuperSourcePropertiesSetCommand.MaskFlags.ArtFillSource,
                SSrcId = SuperSourceId.One,
                ArtFillSource = Source,
            };
        }
    }

    [MacroOperation(MacroOperationType.SuperSourceV2ArtFillInput, 8)]
    public class SuperSourceV2ArtFillInputMacroOp : SuperSourceMacroOpBase
    {
        [Serialize(6), Enum16]
        [MacroField("Input")]
        public VideoSource Source { get; set; }

        public override ICommand ToCommand()
        {
            return new SuperSourcePropertiesSetCommand()
            {
                Mask = SuperSourcePropertiesSetCommand.MaskFlags.ArtFillSource,
                SSrcId = SSrcId,
                ArtFillSource = Source,
            };
        }
    }
}