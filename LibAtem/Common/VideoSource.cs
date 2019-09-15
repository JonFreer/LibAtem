﻿using System;
using System.Linq;
using System.Xml.Serialization;
using LibAtem.Util;

namespace LibAtem.Common
{
    public enum VideoSource
    {
        [VideoSourceType(InternalPortType.Black, 0)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Black", "Blk")]
        [XmlEnum("0")]
        Black = 0,

        [VideoSourceType(InternalPortType.External, 1)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 1", "Cam1")]
        [XmlEnum("1")]
        Input1 = 1,
        [VideoSourceType(InternalPortType.External, 2)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 2", "Cam2")]
        [XmlEnum("2")]
        Input2 = 2,
        [VideoSourceType(InternalPortType.External, 3)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 3", "Cam3")]
        [XmlEnum("3")]
        Input3 = 3,
        [VideoSourceType(InternalPortType.External, 4)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 4", "Cam4")]
        [XmlEnum("4")]
        Input4 = 4,
        [VideoSourceType(InternalPortType.External, 5)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 5", "Cam5")]
        [XmlEnum("5")]
        Input5 = 5,
        [VideoSourceType(InternalPortType.External, 6)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 6", "Cam6")]
        [XmlEnum("6")]
        Input6 = 6,
        [VideoSourceType(InternalPortType.External, 7)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 7", "Cam7")]
        [XmlEnum("7")]
        Input7 = 7,
        [VideoSourceType(InternalPortType.External, 8)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 8", "Cam8")]
        [XmlEnum("8")]
        Input8 = 8,
        [VideoSourceType(InternalPortType.External, 9)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 9", "Cam9")]
        [XmlEnum("9")]
        Input9 = 9,
        [VideoSourceType(InternalPortType.External, 10)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 10", "Cm10")]
        [XmlEnum("10")]
        Input10 = 10,
        [VideoSourceType(InternalPortType.External, 11)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 11", "Cm11")]
        [XmlEnum("11")]
        Input11 = 11,
        [VideoSourceType(InternalPortType.External, 12)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 12", "Cm12")]
        [XmlEnum("12")]
        Input12 = 12,
        [VideoSourceType(InternalPortType.External, 13)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 13", "Cm13")]
        [XmlEnum("13")]
        Input13 = 13,
        [VideoSourceType(InternalPortType.External, 14)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 14", "Cm14")]
        [XmlEnum("14")]
        Input14 = 14,
        [VideoSourceType(InternalPortType.External, 15)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 15", "Cm15")]
        [XmlEnum("15")]
        Input15 = 15,
        [VideoSourceType(InternalPortType.External, 16)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 16", "Cm16")]
        [XmlEnum("16")]
        Input16 = 16,
        [VideoSourceType(InternalPortType.External, 17)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 17", "Cm17")]
        [XmlEnum("17")]
        Input17 = 17,
        [VideoSourceType(InternalPortType.External, 18)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 18", "Cm18")]
        [XmlEnum("18")]
        Input18 = 18,
        [VideoSourceType(InternalPortType.External, 19)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 19", "Cm19")]
        [XmlEnum("19")]
        Input19 = 19,
        [VideoSourceType(InternalPortType.External, 20)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Camera 20", "Cm20")]
        [XmlEnum("20")]
        Input20 = 20,
        // TODO - more

        [VideoSourceType(InternalPortType.ColorBars, 0)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Color Bars", "Bars")]
        [XmlEnum("1000")]
        ColorBars = 1000,

        [VideoSourceType(InternalPortType.ColorGenerator, 1)]
        [VideoSourceAvailability(SourceAvailability.All & ~SourceAvailability.KeySource, MeAvailability.All)]
        [VideoSourceDefaults("Color 1", "Col1")]
        [XmlEnum("2001")]
        Color1 = 2001,
        [VideoSourceType(InternalPortType.ColorGenerator, 2)]
        [VideoSourceAvailability(SourceAvailability.All & ~SourceAvailability.KeySource, MeAvailability.All)]
        [VideoSourceDefaults("Color 2", "Col2")]
        [XmlEnum("2002")]
        Color2 = 2002,

        [VideoSourceType(InternalPortType.MediaPlayerFill, 1)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Media Player 1", "MP1")]
        [XmlEnum("3010")]
        MediaPlayer1 = 3010,
        [VideoSourceType(InternalPortType.MediaPlayerKey, 1)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Media Player 1 Key", "MP1K")]
        [XmlEnum("3011")]
        MediaPlayer1Key = 3011,
        [VideoSourceType(InternalPortType.MediaPlayerFill, 2)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Media Player 2", "MP2")]
        [XmlEnum("3020")]
        MediaPlayer2 = 3020,
        [VideoSourceType(InternalPortType.MediaPlayerKey, 2)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Media Player 2 Key", "MP2K")]
        [XmlEnum("3021")]
        MediaPlayer2Key = 3021,
        [VideoSourceType(InternalPortType.MediaPlayerFill, 3)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Media Player 3", "MP3")]
        [XmlEnum("3030")]
        MediaPlayer3 = 3030,
        [VideoSourceType(InternalPortType.MediaPlayerKey, 3)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Media Player 3 Key", "MP3K")]
        [XmlEnum("3031")]
        MediaPlayer3Key = 3031,
        [VideoSourceType(InternalPortType.MediaPlayerFill, 4)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Media Player 4", "MP4")]
        [XmlEnum("3040")]
        MediaPlayer4 = 3040,
        [VideoSourceType(InternalPortType.MediaPlayerKey, 4)]
        [VideoSourceAvailability(SourceAvailability.All, MeAvailability.All)]
        [VideoSourceDefaults("Media Player 4 Key", "MP4K")]
        [XmlEnum("3041")]
        MediaPlayer4Key = 3041,

        [VideoSourceType(InternalPortType.Mask, 1)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer)]
        [XmlEnum("4010")]
        Key1Mask = 4010,
        [VideoSourceType(InternalPortType.Mask, 2)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer)]
        [XmlEnum("4020")]
        Key2Mask = 4020,
        [VideoSourceType(InternalPortType.Mask, 3, 1)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer)]
        [XmlEnum("4030")]
        Key3Mask = 4030,
        [VideoSourceType(InternalPortType.Mask, 4, 2)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer)]
        [XmlEnum("4040")]
        Key4Mask = 4040,
        [VideoSourceType(InternalPortType.Mask, 0)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer)]
        [VideoSourceDefaults("DSK 1 Mask", "DK1M")]
        [XmlEnum("5010")]
        DSK1Mask = 5010,
        [VideoSourceType(InternalPortType.Mask, 0)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer)]
        [VideoSourceDefaults("DSK 2 Mask", "DK2M")]
        [XmlEnum("5020")]
        DSK2Mask = 5020,

        [VideoSourceType(InternalPortType.SuperSource, 1)]
        [VideoSourceAvailability(SourceAvailability.All & ~SourceAvailability.SuperSourceArt, MeAvailability.All)]
        [VideoSourceDefaults("SuperSource", "SSrc")]
        [XmlEnum("6000")]
        SuperSource = 6000,
        [VideoSourceType(InternalPortType.SuperSource, 1)]
        [VideoSourceAvailability(SourceAvailability.All & ~SourceAvailability.SuperSourceArt, MeAvailability.All)]
        [VideoSourceDefaults("SuperSource 2", "SS2")]
        [XmlEnum("6001")]
        SuperSource2 = 6001,

        [VideoSourceType(InternalPortType.MEOutput, 0)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer)]
        [VideoSourceDefaults("Clean Feed 1", "Cfd1")]
        [XmlEnum("7001")]
        CleanFeed1 = 7001,
        [VideoSourceType(InternalPortType.MEOutput, 0)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer)]
        [VideoSourceDefaults("Clean Feed 2", "Cfd2")]
        [XmlEnum("7002")]
        CleanFeed2 = 7002,
        [VideoSourceType(InternalPortType.MEOutput, 0)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer)]
        [VideoSourceDefaults("Clean Feed 3", "Cfd3")]
        [XmlEnum("7003")]
        CleanFeed3 = 7003,
        [VideoSourceType(InternalPortType.MEOutput, 0)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer)]
        [VideoSourceDefaults("Clean Feed 4", "Cfd4")]
        [XmlEnum("7004")]
        CleanFeed4 = 7004,

        [VideoSourceType(InternalPortType.Auxiliary, 1)]
        [VideoSourceAvailability(SourceAvailability.Multiviewer)]
        [VideoSourceDefaults("Auxiliary 1", "Aux1")]
        [XmlEnum("8001")]
        Auxilary1 = 8001,
        [VideoSourceType(InternalPortType.Auxiliary, 2)]
        [VideoSourceAvailability(SourceAvailability.Multiviewer)]
        [VideoSourceDefaults("Auxiliary 2", "Aux2")]
        [XmlEnum("8002")]
        Auxilary2 = 8002,
        [VideoSourceType(InternalPortType.Auxiliary, 3)]
        [VideoSourceAvailability(SourceAvailability.Multiviewer)]
        [VideoSourceDefaults("Auxiliary 3", "Aux3")]
        [XmlEnum("8003")]
        Auxilary3 = 8003,
        [VideoSourceType(InternalPortType.Auxiliary, 4)]
        [VideoSourceAvailability(SourceAvailability.Multiviewer)]
        [VideoSourceDefaults("Auxiliary 4", "Aux4")]
        [XmlEnum("8004")]
        Auxilary4 = 8004,
        [VideoSourceType(InternalPortType.Auxiliary, 5)]
        [VideoSourceAvailability(SourceAvailability.Multiviewer)]
        [VideoSourceDefaults("Auxiliary 5", "Aux5")]
        [XmlEnum("8005")]
        Auxilary5 = 8005,
        [VideoSourceType(InternalPortType.Auxiliary, 6)]
        [VideoSourceAvailability(SourceAvailability.Multiviewer)]
        [VideoSourceDefaults("Auxiliary 6", "Aux6")]
        [XmlEnum("8006")]
        Auxilary6 = 8006,
        // TODO - more

        [VideoSourceType(InternalPortType.MEOutput, 1)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer)]
        [XmlEnum("10010")]
        ME1Prog = 10010,
        [VideoSourceType(InternalPortType.MEOutput, 1)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer)]
        [XmlEnum("10011")]
        ME1Prev = 10011,
        [VideoSourceType(InternalPortType.MEOutput, 2)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer | SourceAvailability.SuperSourceBox, MeAvailability.Me1)]
        [XmlEnum("10020")]
        ME2Prog = 10020,
        [VideoSourceType(InternalPortType.MEOutput, 2)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer | SourceAvailability.SuperSourceBox, MeAvailability.Me1)]
        [XmlEnum("10021")]
        ME2Prev = 10021,
        [VideoSourceType(InternalPortType.MEOutput, 3)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer | SourceAvailability.SuperSourceBox, MeAvailability.Me1 | MeAvailability.Me2)]
        [XmlEnum("10030")]
        ME3Prog = 10030,
        [VideoSourceType(InternalPortType.MEOutput, 3)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer | SourceAvailability.SuperSourceBox, MeAvailability.Me1 | MeAvailability.Me2)]
        [XmlEnum("10031")]
        ME3Prev = 10031,
        [VideoSourceType(InternalPortType.MEOutput, 4)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer | SourceAvailability.SuperSourceBox, MeAvailability.Me1 | MeAvailability.Me2 | MeAvailability.Me3)]
        [XmlEnum("10040")]
        ME4Prog = 10040,
        [VideoSourceType(InternalPortType.MEOutput, 4)]
        [VideoSourceAvailability(SourceAvailability.Auxiliary | SourceAvailability.Multiviewer | SourceAvailability.SuperSourceBox, MeAvailability.Me1 | MeAvailability.Me2 | MeAvailability.Me3)]
        [XmlEnum("10041")]
        ME4Prev = 10041,
    }

    public static class VideoSourceLists
    {
        public static VideoSource[] All => Enum.GetValues(typeof(VideoSource)).OfType<VideoSource>().ToArray();

        public static VideoSource[] Inputs => All
            .Where(s => s.GetPortType() == InternalPortType.External)
            .ToArray();

        public static VideoSource[] ColorGenerators => new[]
        {
            VideoSource.Color1,
            VideoSource.Color2,
        };

        public static VideoSource[] MediaPlayers => new[]
        {
            VideoSource.MediaPlayer1,
            VideoSource.MediaPlayer2,
            VideoSource.MediaPlayer3,
            VideoSource.MediaPlayer4,
        };

        public static VideoSource[] MediaPlayerKeys => new[]
        {
            VideoSource.MediaPlayer1Key,
            VideoSource.MediaPlayer2Key,
            VideoSource.MediaPlayer3Key,
            VideoSource.MediaPlayer4Key,
        };

        public static VideoSource[] UpstreamKeyMasks => new[]
        {
            VideoSource.Key1Mask,
            VideoSource.Key2Mask,
            VideoSource.Key3Mask,
            VideoSource.Key4Mask,
        };

        public static VideoSource[] DownstreamKeyMasks => new[]
        {
            VideoSource.DSK1Mask,
            VideoSource.DSK2Mask,
        };

        public static VideoSource[] MixEffectPrograms => new[]
        {
            VideoSource.ME1Prog,
            VideoSource.ME2Prog,
        };

        public static VideoSource[] MixEffectPreviews => new[]
        {
            VideoSource.ME1Prev,
            VideoSource.ME2Prev,
        };
    }

    public class VideoSourceTypeAttribute : Attribute
    {
        public InternalPortType PortType { get; }
        public int Me1Index { get; }
        public int Me2Index { get; }

        public VideoSourceTypeAttribute(InternalPortType portType, int me1Index, int me2Index=-1)
        {
            PortType = portType;
            Me1Index = me1Index;
            Me2Index = me2Index == -1 ? me1Index : me2Index;
        }
    }

    public class VideoSourceDefaultsAttribute : Attribute
    {
        public string LongName { get; }
        public string ShortName { get; }

        public VideoSourceDefaultsAttribute(string longName, string shortName)
        {
            if (longName.Length > 20)
                throw new ArgumentException("longName");
            if (shortName.Length > 4)
                throw new ArgumentException("shortName");

            LongName = longName;
            ShortName = shortName;
        }
    }

    public class VideoSourceAvailabilityAttribute : Attribute
    {
        public SourceAvailability SourceAvailability { get; }
        public MeAvailability MeAvailability { get; }

        public VideoSourceAvailabilityAttribute(SourceAvailability sourceAvailability, MeAvailability me = MeAvailability.None)
        {
            SourceAvailability = sourceAvailability;
            MeAvailability = me;
        }
    }

    public static class VideoSourceAvailabilityExtensions
    {
        public static bool IsAvailable(this VideoSource src, MixEffectBlockId meId)
        {
            var attr = src.GetPossibleAttribute<VideoSource, VideoSourceAvailabilityAttribute>();
            if (attr == null)
                return false;

            return attr.MeAvailability.Includes(meId);
        }
        public static bool IsAvailable(this VideoSource src, SourceAvailability available)
        {
            var attr = src.GetPossibleAttribute<VideoSource, VideoSourceAvailabilityAttribute>();
            if (attr == null)
                return false;

            return attr.SourceAvailability.HasFlag(available);
        }
    }

    public static class VideoSourceExtensions
    {
        public static InternalPortType GetPortType(this VideoSource src)
        {
            return src.GetAttribute<VideoSource, VideoSourceTypeAttribute>().PortType;
        }

        public static bool SupportsVuMeter(this VideoSource src)
        {
            switch (src.GetPortType())
            {
                case InternalPortType.External:
                case InternalPortType.MediaPlayerFill:
                case InternalPortType.MediaPlayerKey:
                case InternalPortType.MEOutput:
                case InternalPortType.Auxiliary:
                    return true;
                default:
                    return false;
            }
        }
    }
}
