namespace Chess.Domain
{
    public class Pawn : Piece
    {
        public Pawn(PieceColor pieceColor)
            : base(pieceColor)
        {
            this.Rank = Rank.Pawn;
        }

        public override bool IsValidMove(Vector[] vectors, bool hasMoved)
        {
            if (vectors.Length != 1)
            {
                return false;
            }

            Vector vector = vectors[0];

            if (vector.Magnitude == 1)
            {
                return vector.Direction == Direction.Forward ||
                    vector.Direction == Direction.ForwardLeft ||
                    vector.Direction == Direction.ForwardRight;
            }
            else if (vector.Magnitude == 2 && !hasMoved)
            {
                return vector.Direction == Direction.Forward;
            }
            else
            {
                return false;
            }
        }
    }
}
