using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess.Domain
{
    public abstract class Piece
    {
        protected int? X { get; set; }
        protected int? Y { get; set; }
        public PieceColor Color { get; }

        protected Piece(PieceColor color)
        {
            Color = color;
        }

        public abstract bool IsValidMove(Vector[] vectors, bool hasMoved);
    }
}
