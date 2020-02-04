using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess.Domain
{
    public abstract class Piece
    {
        public int? X { get; set; }
        public int? Y { get; set; }
        protected Rank Rank { get; set; }
        public PieceColor Color { get; }

        protected Piece(PieceColor color)
        {
            Color = color;
        }

        public abstract bool IsValidMove(Vector[] vectors, bool hasMoved);
    }
}
