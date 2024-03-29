﻿

namespace board
{
     class Board
    {
        public int lines { get; set; }
        public int columns { get; set; }
        public Piece[,] pieces;

        public Board(int lines, int columns)
        {
            this.lines = lines;
            this.columns = columns;
            pieces = new Piece[lines, columns];
        }

        public Piece piece(int line, int column)
        {
            return pieces[line, column];
        }
        public Piece piece(Position pos)
        {
            return pieces[pos.line, pos.column];
        }

        public bool isThereApiece(Position pos)
        {
            validatePosition(pos);
            return piece(pos) != null;
        }

        public void insertPiece(Piece p, Position pos)
        {
            if (isThereApiece(pos))
            {
                throw new BoardException("There is already a piece at that position!");
            }
            else
            {
                pieces[pos.line, pos.column] = p;
                p.position = pos;
            }
        }
        public Piece removePiece(Position pos)
        {
            if(piece(pos) == null)
            {
                return null;
            }
            else
            {
                Piece aux = piece(pos);
                aux.position = null;
                pieces[pos.line, pos.column] = null;
                return aux;
            }
        }
        public bool validPosition(Position pos)
        {
            if (pos.line < 0 || pos.line >= lines || pos.column < 0 || pos.column >= columns) 
            {
                return false;
            }
            else
            {
                return true;    
            }
        }
        public void validatePosition(Position pos)
        {
            if(!validPosition(pos))
            {
                throw new BoardException("Invalid Position!");
            }

        }
    }
}
