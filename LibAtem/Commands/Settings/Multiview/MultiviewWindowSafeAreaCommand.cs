using LibAtem.Serialization;

namespace LibAtem.Commands.Settings.Multiview
{
    [CommandName("SaMw", 4)]
    public class MultiviewWindowSafeAreaCommand : SerializableCommandBase
    {
        [CommandId]
        [Serialize(0), UInt8]
        public uint MultiviewIndex { get; set; }
        [CommandId]
        [Serialize(1), UInt8Range(0, 15)] // TODO - more specific than that?
        public uint WindowIndex { get; set; }
        [Serialize(2), Bool]
        public bool SafeAreaEnabled { get; set; }
    }
}