﻿using NUnit.Framework;

namespace Chess.Domain
{
    [TestFixture]
    public class When_creating_a_chess_board
    {
        private ChessBoard _chessBoard;

        [SetUp]
        public void SetUp()
        {
            _chessBoard = new ChessBoard();
        }

        [Test]
        public void _001_the_playing_board_should_have_a_Max_Board_Width_of_7()
        {
            Assert.That(ChessBoard.MaxY, Is.EqualTo(7));
        }

        [Test]
        public void _002_the_playing_board_should_have_a_Max_Board_Height_of_7()
        {
            Assert.That(ChessBoard.MaxX, Is.EqualTo(7));
        }

        [Test]
        public void _005_the_playing_board_should_know_that_X_equals_0_and_Y_equals_0_is_a_valid_board_position()
        {
            Position pos = new Position(0, 0);
            var isValidPosition = _chessBoard.IsLegalBoardPosition(pos);
            Assert.That(isValidPosition, Is.True);
        }

        [Test]
        public void _006_the_playing_board_should_know_that_X_equals_5_and_Y_equals_5_is_a_valid_board_position()
        {
            Position pos = new Position(5,5);
            var isValidPosition = _chessBoard.IsLegalBoardPosition(pos);
            Assert.That(isValidPosition, Is.True);
        }

        [Test]
        public void _010_the_playing_board_should_know_that_X_equals_11_and_Y_equals_5_is_an_invalid_board_position()
        {
            Position pos = new Position(11, 5);
            var isValidPosition = _chessBoard.IsLegalBoardPosition(pos);
            Assert.That(isValidPosition, Is.False);
        }

        [Test]
        public void _011_the_playing_board_should_know_that_X_equals_0_and_Y_equals_8_is_an_invalid_board_position()
        {
            Position pos = new Position(0, 9);
            var isValidPosition = _chessBoard.IsLegalBoardPosition(pos);
            Assert.That(isValidPosition, Is.False);
        }

        [Test]
        public void _011_the_playing_board_should_know_that_X_equals_11_and_Y_equals_0_is_an_invalid_board_position()
        {
            Position pos = new Position(11, 0);
            var isValidPosition = _chessBoard.IsLegalBoardPosition(pos);
            Assert.That(isValidPosition, Is.False);
        }

        [Test]
        public void _012_the_playing_board_should_know_that_X_equals_minus_1_and_Y_equals_5_is_an_invalid_board_position()
        {
            Position pos = new Position(-1, 5);
            var isValidPosition = _chessBoard.IsLegalBoardPosition(pos);
            Assert.That(isValidPosition, Is.False);
        }

        [Test]
        public void _012_the_playing_board_should_know_that_X_equals_5_and_Y_equals_minus_1_is_an_invalid_board_position()
        {
            Position pos = new Position(5, -1);
            var isValidPosition = _chessBoard.IsLegalBoardPosition(pos);
            Assert.That(isValidPosition, Is.False);
        }
    }

    [TestFixture]
    public class When_using_a_black_pawn_and
    {
        private ChessBoard _chessBoard;
        private Pawn _pawn;

        [SetUp]
        public void SetUp()
        {
            _chessBoard = new ChessBoard();
            _pawn = new Pawn(PieceColor.Black);
        }

        [Test]
        public void _01_placing_the_black_pawn_on_X_equals_6_and_Y_equals_3_should_place_the_black_pawn_on_that_place_on_the_board()
        {
            Position pos = new Position(6, 3);
            _chessBoard.Add(pos, _pawn);
            Assert.That(_pawn.X, Is.EqualTo(6));
            Assert.That(_pawn.Y, Is.EqualTo(3));
        }

        [Test]
        public void _10_making_an_illegal_move_by_placing_the_black_pawn_on_X_equals_6_and_Y_eqauls_3_and_moving_to_X_equals_7_and_Y_eqauls_3_should_not_move_the_pawn()
        {
            Position pos = new Position(6, 3);
            _chessBoard.Add(pos, _pawn);
            //_pawn.Move(MovementType.Move, 7, 3);
            Assert.That(_pawn.X, Is.EqualTo(6));
            Assert.That(_pawn.Y, Is.EqualTo(3));
        }

        [Test]
        public void _11_making_an_illegal_move_by_placing_the_black_pawn_on_X_equals_6_and_Y_eqauls_3_and_moving_to_X_equals_4_and_Y_eqauls_3_should_not_move_the_pawn()
        {
            Position pos = new Position(6, 3);
            _chessBoard.Add(pos, _pawn);
            //_pawn.Move(MovementType.Move, 4, 3);
            Assert.That(_pawn.X, Is.EqualTo(6));
            Assert.That(_pawn.Y, Is.EqualTo(3));
        }

        [Test]
        public void _20_making_a_legal_move_by_placing_the_black_pawn_on_X_equals_6_and_Y_eqauls_3_and_moving_to_X_equals_6_and_Y_eqauls_2_should_move_the_pawn()
        {
            Position pos = new Position(6, 3);
            _chessBoard.Add(pos, _pawn);
            //_pawn.Move(MovementType.Move, 6, 2);
            Assert.That(_pawn.X, Is.EqualTo(6));
            Assert.That(_pawn.Y, Is.EqualTo(2));
        }

    }

    [TestFixture]
    public class When_using_a_white_pawn_and
    {
        private ChessBoard _chessBoard;
        private Pawn _pawn;

        [SetUp]
        public void SetUp()
        {
            _chessBoard = new ChessBoard();
            _pawn = new Pawn(PieceColor.White);
        }

        [Test]
        public void _01_placing_the_white_pawn_on_X_equals_6_and_Y_equals_1_should_place_the_white_pawn_on_that_place_on_the_board()
        {
            Position pos = new Position(6, 1);
            _chessBoard.Add(pos, _pawn);
            Assert.That(_pawn.X, Is.EqualTo(6));
            Assert.That(_pawn.Y, Is.EqualTo(1));
        }

        [Test]
        public void _10_making_an_illegal_move_by_placing_the_white_pawn_on_X_equals_6_and_Y_eqauls_1_and_moving_to_X_equals_7_and_Y_eqauls_2_should_not_move_the_pawn()
        {
            Position pos = new Position(6, 1);
            _chessBoard.Add(pos, _pawn);
            //_pawn.Move(MovementType.Move, 7, 2);
            Assert.That(_pawn.X, Is.EqualTo(6));
            Assert.That(_pawn.Y, Is.EqualTo(1));
        }

        [Test]
        public void _11_making_an_illegal_move_by_placing_the_white_pawn_on_X_equals_6_and_Y_eqauls_1_and_moving_to_X_equals_6_and_Y_eqauls_4_should_not_move_the_pawn()
        {
            Position pos = new Position(6, 1);
            _chessBoard.Add(pos, _pawn);
            //_pawn.Move(MovementType.Move, 6, 4);
            Assert.That(_pawn.X, Is.EqualTo(6));
            Assert.That(_pawn.Y, Is.EqualTo(1));
        }

        [Test]
        public void _20_making_a_legal_move_by_placing_the_white_pawn_on_X_equals_6_and_Y_eqauls_1_and_moving_to_X_equals_6_and_Y_eqauls_2_should_move_the_pawn()
        {
            Position pos = new Position(6, 1);
            _chessBoard.Add(pos, _pawn);
           // _pawn.Move(MovementType.Move, 6, 2);
            Assert.That(_pawn.X, Is.EqualTo(6));
            Assert.That(_pawn.Y, Is.EqualTo(2));
        }

    }

}
