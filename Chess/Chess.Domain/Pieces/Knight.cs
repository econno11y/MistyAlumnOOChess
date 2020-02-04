using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess.Domain
{
	public class Knight : Piece
	{
		public Knight(PieceColor color) : base(color)
		{
			this.Rank = Rank.Knight;
		}

		public override bool IsValidMove(Vector[] vectors, bool hasMoved)
		{
			throw new NotImplementedException();
		}
	}
}
