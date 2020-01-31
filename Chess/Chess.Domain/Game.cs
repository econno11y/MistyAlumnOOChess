using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess.Domain
{
    public class Game
    {
        private readonly ChessBoard _board;
        private readonly PieceColor _originColor;

        public Game(PieceColor originColor)
        {
            _board = new ChessBoard();
            _originColor = originColor;
        }

        public void Move(Piece piece, Position destination)
        {
            Position currentPos = _board.GetCurrentPosition(piece);
            
            int deltaX = destination.X - currentPos.X;
            int deltaY = destination.Y - currentPos.Y;

            Vector moveVector;
            if (_originColor == piece.Color)
            {
                Direction direction = (Direction)0;

                if (deltaX > 0)
                {
                    direction |= Direction.Forward;
                }
                else if (deltaX < 0)
                {
                    direction |= Direction.Backward;
                }

                if (deltaY > 0)
                {
                    direction |= Direction.Left;
                }
                else if (deltaY < 0)
                {
                    direction |= Direction.Right;
                }

                if (!Enum.IsDefined(typeof(Direction), direction))
                {
                    throw new InvalidOperationException();
                }

            }
        }
    }
}
