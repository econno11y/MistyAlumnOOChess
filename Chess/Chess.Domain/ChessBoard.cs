using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Domain
{
    public class ChessBoard
    {
        public static readonly int MaxY = 8;
        public static readonly int MaxX = 8;
        
        private readonly Dictionary<Position, Piece> _board;

        public ChessBoard ()
        {
            _board = new Dictionary<Position, Piece>(8 * 4);
        }

        public void Add(Position position, Piece piece)
        {
            if (_board.ContainsKey(position))
            {
                throw new InvalidOperationException();
            }

            _board.Add(position, piece);
        }

        public Position GetCurrentPosition(Piece piece)
        {
            KeyValuePair<Position, Piece> pair = _board.SingleOrDefault(p => ReferenceEquals(p.Value, piece));
            return pair.Key;
        }

        public bool IsLegalBoardPosition(Position position)
        {
            return position.X >= 0 && position.X < MaxX &&
                position.Y >= 0 && position.Y < MaxY;
        }
    }
}
