using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess.Domain
{
	public class Rook : Piece
	{
		public Rook(PieceColor color) : base(color)
		{
			this.Rank = Rank.Rook;
		}

		public override bool IsValidMove(Vector[] vectors, bool hasMoved)
		{
			throw new NotImplementedException();
		}
	}
}
