using System;

namespace Chess.Domain
{
    public struct Vector : IEquatable<Vector>
    {
        public Direction Direction { get; }

        public int Magnitude { get; }

        public Vector(Direction direction, int magnitude)
        {
            Direction = direction;
            Magnitude = magnitude;
        }

        public override bool Equals(object obj)
        {
            return obj is Vector vector && Equals(vector);
        }

        public bool Equals(Vector other)
        {
            return Direction == other.Direction &&
                   Magnitude == other.Magnitude;
        }

        public override int GetHashCode()
        {
            var hashCode = -1069744805;
            hashCode = hashCode * -1521134295 + Direction.GetHashCode();
            hashCode = hashCode * -1521134295 + Magnitude.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Vector left, Vector right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector left, Vector right)
        {
            return !(left == right);
        }
    }
}
