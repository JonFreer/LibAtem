using LibAtem.Serialization;
using System.Collections.Generic;

namespace LibAtem.Commands.Media
{
    [CommandName("CMPS", CommandDirection.ToServer, 8), NoCommandId]
    public class MediaPoolSettingsSetCommand : SerializableCommandBase
    {
        [Serialize(0), UInt16]

        public uint Clip1MaxLength { get; set; }
        //  public List<uint> MaxFrames { get; set; }

        // public void Serialize(ByteArrayBuilder cmd)
        // {
        //      foreach (uint fr in MaxFrames)
        //          cmd.AddUInt16(fr);
        //
        //      cmd.PadToNearestMultipleOf4();
        //  }

        //  public void Deserialize(ParsedByteArray cmd)
        //   {
        //      MaxFrames = new List<uint>();
        //
        //       for (int i = 0; i < cmd.BodyLength; i += 2)
        //           MaxFrames.Add(cmd.GetUInt16());

        //      cmd.SkipToNearestMultipleOf4();
        //  }
    }
}