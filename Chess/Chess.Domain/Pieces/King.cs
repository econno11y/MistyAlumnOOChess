using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess.Domain
{
	public class King : Piece
	{
		public King(PieceColor color) : base(color)
		{
			this.Rank = Rank.King;
		}

		public override bool IsValidMove(Vector[] vectors, bool hasMoved)
		{
			throw new NotImplementedException();
		}
	}
}
