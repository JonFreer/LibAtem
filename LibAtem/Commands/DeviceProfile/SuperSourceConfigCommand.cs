using LibAtem.Common;
using LibAtem.Serialization;

namespace LibAtem.Commands.DeviceProfile
{
    [CommandName("_SSC", 4)]
    public class SuperSourceConfigCommand : SerializableCommandBase
    {
        [CommandId]
        [Serialize(0), Enum8]
        public SuperSourceId SSrcId { get; set; }

        [Serialize(2), UInt8]
        public uint Boxes { get; set; }
    }
}