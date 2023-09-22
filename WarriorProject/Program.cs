/*
 * A feladat a github-on olvasható!
 */

using System;

namespace WarriorProject
{
    public class Position
    {

        private int _x;
        private int _y;

        public int X { get => _x; }
        public int Y { get => _y; set => _y; }

        public Position(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
        public void ToConsole()
        {
            Console.Write($"({_x};{_y})");
        }
       
    }
    public class Warrior
    {
        private string _name;
        private Position _position;

        public Warrior(string name, Position position)
        {
            this._name=name;
            this._position = position;
        }
        public void ToConsole()
        {
            Console.WriteLine($"{_name}, ({_position.X};{_position.Y})");
        }
        public void MoveHorizontal(int distance)
        {
            _position.X += distance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
