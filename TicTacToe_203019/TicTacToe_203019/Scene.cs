using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_203019
{
    public class Scene
    {
        public List<Block> blocks;
        public Block selected;
        public Scene()
        {
            blocks = new List<Block>();
            selected = null;
        }

        public void addBlock(Block block)
        {
            blocks.Add(block);
        }

        public void drawAll(Graphics g,Player p)
        {
            foreach (Block block in blocks)
            {
                block.draw(g,p);
            }
            Pen pen = new Pen(Color.Black, 3);
            g.DrawLine(pen, 412, 80, 412, 510);
            g.DrawLine(pen, 557, 80, 557, 510);
            g.DrawLine(pen, 270, 222, 700, 222);
            g.DrawLine(pen, 270, 367, 700, 367);
            pen.Dispose();
        }

        public void isHit(Point p)
        {
            foreach(Block block in blocks)
            {
                if (block.isHit(p))
                {
                    selected = block;
                }
                else
                {
                    block.isSelected = false;
                }
            }

        }
    }
}
