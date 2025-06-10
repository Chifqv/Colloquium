using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colloquium
{
    public class Cube
    {
        internal int length;//длина
        internal int width;//ширина
        internal int height;//высота
        internal int x;
        internal int y;
        internal int z;

        public Cube(int l, int w, int h, int X, int Y, int Z)
        {
            length = l; width = w;
            height = h;
            x = X; y = Y; z = Z;
        }

        public string Print()
        {
            return $"{GetType().Name}: длинна={length}, ширина={width}, высота={height}, координаты: ({x},{y},{z})";
        }
    }
    public class Sea: Cube
    {
        public Sea(int width, int length, int height, int x, int y, int z)
            : base(width, length, height, x, y, z)
        {

        }

        public bool CheckIn(Cube obj)// Проверяем, что объект полностью находится внутри моря
        {
            return obj.x >= this.x &&
                   obj.y >= this.y &&
                   obj.z >= this.z &&
                   obj.x + obj.width <= this.x + this.width &&
                   obj.y + obj.height <= this.y + this.height &&
                   obj.z + obj.length <= this.z + this.length;     
        }
    }
}
