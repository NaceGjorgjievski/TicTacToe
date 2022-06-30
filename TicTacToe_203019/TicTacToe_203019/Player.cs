using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_203019
{
    public class Player
    {
        public int score { get; set; }
        public string name { get; set; }
        public char value { get; set; }
        public Color color { get; set; }
        public Player(int score,char Value,Color color,string name)
        {
            this.name = name;
            this.score = score;
            this.value = Value;
            this.color = color;
        }


    }
}
