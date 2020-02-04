using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess.Domain
{
	public class Bishop : Piece
	{
		public Bishop(PieceColor color) : base(color)
		{
			this.Rank = Rank.Bishop;
		}

		public override bool IsValidMove(Vector[] vectors, bool hasMoved)
		{
			throw new NotImplementedException();
		}
	}
}
