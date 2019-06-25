using System;
using System.Collections.Generic;
using LibAtem.Common;
using LibAtem.MacroOperations;
using LibAtem.MacroOperations.Settings;
using LibAtem.Serialization;

namespace LibAtem.Commands.Settings.Multiview
{
    [CommandName("CMvP", 4)]
    public class MultiviewPropertiesSetCommand : SerializableCommandBase
    {
        [Flags]
        public enum MaskFlags
        {
            Layout = 1 << 0,
            ProgramPreviewSwapped = 1 << 1,
        }

        [Serialize(0), Enum8]
        public MaskFlags Mask { get; set; }
        [CommandId]
        [Serialize(1), UInt8]
        public uint MultiviewIndex { get; set; }
        [Serialize(2), Enum8]
        public MultiViewLayout Layout { get; set; }
        [Serialize(3), Bool]
        public bool ProgramPreviewSwapped { get; set; }

        public override IEnumerable<MacroOpBase> ToMacroOps()
        {
            if (Mask.HasFlag(MaskFlags.Layout))
            {
                if (!Enum.TryParse(Layout.ToString(), true, out MultiViewLayoutOld layout))
                    layout = 0;

                yield return new MultiViewLayoutMacroOp { MultiViewIndex = MultiviewIndex, Layout = layout };
            }
        }
    }
}