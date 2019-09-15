using LibAtem.Serialization;

namespace LibAtem.Commands.DeviceProfile
{
    [CommandName("_FAC", 4), NoCommandId]
    public class FairlightAudioMixerConfigCommand : SerializableCommandBase
    {
        [Serialize(0), UInt8]
        public uint Inputs { get; set; }
        [Serialize(1), UInt8]
        public uint Monitors { get; set; }
    }
}