using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.Commands.Settings.Multiview
{
    [CommandName("MvPr", 4)]
    public class MultiviewPropertiesGetCommand : SerializableCommandBase
    {
        [CommandId]
        [Serialize(0), UInt8Range(0, 15)]
        public uint MultiviewIndex { get; set; }
        [Serialize(1), Enum8]
        public MultiViewLayout Layout { get; set; }
        [Serialize(2), Bool]
        public bool ProgramPreviewSwapped { get; set; }
    }
}