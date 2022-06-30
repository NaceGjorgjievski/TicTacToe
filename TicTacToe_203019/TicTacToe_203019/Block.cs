using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_203019
{
    public class Block
    {
        public bool isSelected { get; set; } = false;
        public int size { get; set; }
        public Point point { get; set; }  
        public bool isSet { get; set; } = false;
        public Block(Point point, int size)
        {
            this.point = point;
            this.size = size;
        }

        public bool isHit(Point p)
        {
            if (p.X >= point.X && p.X<point.X+size && p.Y >= point.Y && p.Y<point.Y+size)
            {
                isSelected = true;
                return true;
            } 
            return false;
        }

        public void draw(Graphics g,Player p)
        {
            if (isSelected)
            {
                Pen pen = new Pen(p.color,2);
                g.DrawRectangle(pen,point.X,point.Y,size,size);
                pen.Dispose();
            }
            Brush brush = new SolidBrush(Color.White);
            g.FillRectangle(brush, point.X, point.Y, size, size);
            brush.Dispose();
        }

        
    }
}
