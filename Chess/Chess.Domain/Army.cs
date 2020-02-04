using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess.Domain
{
	public class Army
	{
		private Dictionary<Rank, int[]> _initialXPositions = new Dictionary<Rank, int[]>()
		{
			[Rank.King] = new int[] { 3 },
			[Rank.Queen] = new int[] { 4 },
			[Rank.Bishop] = new int[] { 2, 5 },
			[Rank.Knight] = new int[] { 1, 6 },
			[Rank.Rook] = new int[] { 0, 7 },
			[Rank.Pawn] = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }
		};

		public Piece[] Pieces;

		public Army(PieceColor color)
		{
			SetUpArmy(color);
		}

		public void SetUpArmy(PieceColor color)
		{
			List<Piece> army = new List<Piece>();
			
			int pawnY = color == PieceColor.White ? 1 : 6;
			int higherRanksY = color == PieceColor.White ? 0 : 7;

			for (Rank i = Rank.King; i < Rank.Rook; i++)
			{
				int[] xArray = _initialXPositions[i];

				for (int j = 0; j < xArray.Length; j++)
				{
					Piece piece = new Rook(color);

					switch (i)
					{
						case Rank.King:
							piece = new King(color);
							break;
						case Rank.Queen:
							piece = new Queen(color);
							break;
						case Rank.Bishop:
							piece = new Bishop(color);
							break;
						case Rank.Knight:
							piece = new Knight(color);
							break;
						default:
							break;
					}

					piece.X = j;
					piece.Y = higherRanksY;
					army.Add(piece);
				}
			}

			for (int i = 0; i < 8; i++)
			{
				Piece piece = new Pawn(color);
				piece.X = i;
				piece.Y = pawnY;
				army.Add(piece);
			}

			Pieces = army.ToArray();
		}
	}
}
