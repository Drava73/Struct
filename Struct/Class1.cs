using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Vector
    {
        private int x;
        private int y;
        private int z;
        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void Show()
        {
            Console.WriteLine($"x:{x} y:{y} z:{z}");
        }
        public static Vector operator +(Vector opl, Vector op2)
        {
            Vector result = new Vector();
            result.x = opl.x + op2.x;
            result.y = opl.y + op2.y;
            result.z = opl.z + op2.z;
            return result;
        }
        public static Vector operator -(Vector opl, Vector op2)
        {
            Vector result = new Vector();
            result.x = opl.x - op2.x;
            result.y = opl.y - op2.y;
            result.z = opl.z - op2.z;
            return result;
        }
        public static Vector operator *(Vector opl, int op2)
        {
            Vector result = new Vector();
            result.x = opl.x * op2;
            result.y = opl.y * op2;
            result.z = opl.z * op2;
            return result;
        }
    }
    struct Numbers
    {
        public int num;
        public Numbers(int num)
        {
            this.num = num;
        }
        public void InTwoSystem()
        {
            string BinaryCode = Convert.ToString(num, 2);
            Console.Write(BinaryCode);
        }
        public void InVosSystem()
        {
            string BinaryCode = Convert.ToString(num, 8);
            Console.Write(BinaryCode);
        }
        public void InSixSystem()
        {
            string BinaryCode = Convert.ToString(num, 16);
            Console.Write(BinaryCode);
        }
    }
    struct RGBColor
    {
        private RGBColor Color = new RGBColor();
        public int r;
        public int g;
        public int b;
        /*byte[] bytes = { r, g, b };
        string hex = BitConverter.ToString(bytes).Replace("-", "");*/
        public RGBColor(int r, int g, int b)
        {
            int color = new Color(r, g, b);
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }
}
