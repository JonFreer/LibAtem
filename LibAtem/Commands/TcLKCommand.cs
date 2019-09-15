using LibAtem.Serialization;

namespace LibAtem.Commands.DeviceProfile
{
    [CommandName("TcLk", 4), NoCommandId]
    public class TimecodeLockedCommand : SerializableCommandBase
    {
        [Serialize(0), Bool]
        public bool Locked { get; set; }
    }
}