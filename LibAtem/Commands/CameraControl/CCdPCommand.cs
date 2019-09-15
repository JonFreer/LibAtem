namespace LibAtem.Commands.CameraControl
{
    [CommandName("CCdP"), NoCommandId]
    public class CCdPCommand : ICommand
    {
        public void Serialize(ByteArrayBuilder cmd)
        {
        }

        public void Deserialize(ParsedByteArray cmd)
        {
            // Ignore all
            while (!cmd.HasFinished) cmd.Skip();
        }
    }
}