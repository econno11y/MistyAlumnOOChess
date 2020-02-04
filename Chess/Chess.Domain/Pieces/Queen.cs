using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess.Domain
{
	public class Queen : Piece
	{
		public Queen(PieceColor color) : base(color)
		{
			this.Rank = Rank.Queen;
		}

		public override bool IsValidMove(Vector[] vectors, bool hasMoved)
		{
			throw new NotImplementedException();
		}
	}
}
