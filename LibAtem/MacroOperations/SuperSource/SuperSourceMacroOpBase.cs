using LibAtem.Commands;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.MacroOperations.SuperSource
{
    public abstract class SuperSourceMacroOpBase : MacroOpBase
    {
        [CommandId]
        [Serialize(4), Enum8]
        [MacroField("SuperSourceIndex", "index")] // TODO - verify
        public SuperSourceId SSrcId { get; set; }
    }

}