using System;

namespace Chess.Domain
{
    [Flags]
    public enum Direction
    {
        Forward =   1,  // 0b0001
        Right =     2,  // 0b0010
        Backward = 4,  // 0b0100
        Left =      8,  // 0b1000
        ForwardLeft = Forward | Left,
        ForwardRight = Forward | Right,
        BackwardLeft = Backward | Left,
        BackwardRight = Backward | Right
    }

    public static class DirectionExtensions
    {
        public static bool IsForwardLeft(this Direction dir)
        {
            return 
                dir.HasFlag(Direction.Forward) &&
                dir.HasFlag(Direction.Left);
        }
    }
}
