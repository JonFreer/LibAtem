using LibAtem.Commands;
using LibAtem.Commands.Settings.Multiview;
using LibAtem.Common;
using LibAtem.Serialization;
using System;

namespace LibAtem.MacroOperations.Settings
{
    [MacroOperation(MacroOperationType.MultiViewLayout, 8)]
    public class MultiViewLayoutMacroOp : MacroOpBase
    {
        [Serialize(4), UInt8]
        [MacroField("MultiViewIndex")]
        public uint MultiViewIndex { get; set; }
        
        [Serialize(5), Enum8]
        [MacroField("Layout")]
        public MultiViewLayoutOld Layout { get; set; }

        public override ICommand ToCommand()
        {
            if (!Enum.TryParse(Layout.ToString(), true, out MultiViewLayout layout))
                layout = 0;

            return new MultiviewPropertiesSetCommand
            {
                Mask = MultiviewPropertiesSetCommand.MaskFlags.Layout,
                MultiviewIndex = MultiViewIndex,
                Layout = layout
            };
        }
    }
}