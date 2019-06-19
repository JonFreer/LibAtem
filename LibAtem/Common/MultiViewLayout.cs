namespace LibAtem.Common
{
    public enum MultiViewLayout
    {
        //Default = 0, // TODO - means all large (2x2)
        TopLeftSmall = 1,
        TopRightSmall = 2,
        ProgramBottom = TopLeftSmall | TopRightSmall,
        BottomLeftSmall = 4,
        ProgramRight = TopLeftSmall | BottomLeftSmall,
        BottomRightSmall = 8,
        ProgramLeft = TopRightSmall | BottomRightSmall,
        ProgramTop = BottomLeftSmall | BottomRightSmall
    }
}