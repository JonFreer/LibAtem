using LibAtem.Commands;
using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.MacroOperations.SuperSource
{
    public abstract class SuperSourceBoxMacroOpBase : SuperSourceMacroOpBase
    {
        [CommandId]
        [Serialize(5), Enum8]
        [MacroField("SuperSourceBoxIndex", "boxIndex")]
        public SuperSourceBoxId BoxIndex { get; set; }
    }
}