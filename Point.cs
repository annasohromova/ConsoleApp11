﻿using System;
using System.Collections.Generic;
using System.Drawing; // Подключение пространства имен для Point класса
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;



namespace ConsoleApp1
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char sym { get; set; }

        public Point()
        {
        }

        public Point(int x, int y, char sym)
        {
            X = x;
            Y = y;
            this.sym = sym;
        }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            sym = p.sym;
        }

        public bool IsHit(Point p)
        {
            return X == p.X && Y == p.Y;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return X + ", " + Y + ", " + sym;
        }
    }
}