using LibAtem.Serialization;

namespace LibAtem.Commands.Audio
{
    [CommandName("ATMP", 4), NoCommandId]
    public class AudioMixerTalkbackPropertiesGetCommand : SerializableCommandBase
    {
        [Serialize(1), Bool]
        public bool MuteSDI { get; set; }
    }
}