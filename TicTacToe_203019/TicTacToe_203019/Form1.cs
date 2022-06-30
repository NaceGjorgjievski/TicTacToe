using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_203019
{
    public partial class Form1 : Form
    {
        public Boolean gameMode = false;
        public Boolean playTime = true;
        int winLine;
        public Scene scene;
        public Player p1 = new Player(0,'X',Color.Red,"P1");
        public Player p2 = new Player(0,'O',Color.Blue,"P2");
        public Player current;
        public Random random = new Random();
        int i = 0;
        int j = 0;
        int moveCount = 0;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            DoubleBuffered = true;
            
            winLine = 0;
            /*
            int startFirst = random.Next(2);
            if(startFirst == 0)
            {
                current = p1;
                p1.value = 'X';
                p2.value = 'O';
                lblP1Turn.Visible = true;
            }
            else
            {
                current = p2;
                p1.value = 'O';
                p2.value = 'X';
                lblP2Turn.Visible = true;
            }
            */
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void menu()
        {
            this.Width = 834;
            this.Height = 580;
            lblTitle.Show();
            btnExit.Show();
            btnStart.Show();
        }

        public void game()
        {
            int startFirst = random.Next(2);
            if (startFirst == 0)
            {
                current = p1;
                p1.value = 'X';
                p2.value = 'O';
                lblP1Turn.Visible = true;
            }
            else
            {
                current = p2;
                p1.value = 'O';
                p2.value = 'X';
                lblP2Turn.Visible = true;
            }
            this.Height = 600;
            this.Width = 1000;
            lblTitle.Hide();
            btnStart.Hide();
            btnExit.Hide();
            gameMode = true;

            Block block1 = new Block(new Point(270, 80), 140);
            Block block2 = new Block(new Point(415, 80), 140);
            Block block3 = new Block(new Point(560, 80), 140);
            Block block4 = new Block(new Point(270, 225), 140);
            Block block5 = new Block(new Point(415, 225), 140);
            Block block6 = new Block(new Point(560, 225), 140);
            Block block7 = new Block(new Point(270, 370), 140);
            Block block8 = new Block(new Point(415, 370), 140);
            Block block9 = new Block(new Point(560, 370), 140);
            scene.addBlock(block1);
            scene.addBlock(block2);
            scene.addBlock(block3);
            scene.addBlock(block4);
            scene.addBlock(block5);
            scene.addBlock(block6);
            scene.addBlock(block7);
            scene.addBlock(block8);
            scene.addBlock(block9);
            lblBlock1.Location = new Point(block1.point.X + 40, block1.point.Y + 40);
            lblBlock2.Location = new Point(block2.point.X + 40, block2.point.Y + 40);
            lblBlock3.Location = new Point(block3.point.X + 40, block3.point.Y + 40);
            lblBlock4.Location = new Point(block4.point.X + 40, block4.point.Y + 40);
            lblBlock5.Location = new Point(block5.point.X + 40, block5.point.Y + 40);
            lblBlock6.Location = new Point(block6.point.X + 40, block6.point.Y + 40);
            lblBlock7.Location = new Point(block7.point.X + 40, block7.point.Y + 40);
            lblBlock8.Location = new Point(block8.point.X + 40, block8.point.Y + 40);
            lblBlock9.Location = new Point(block9.point.X + 40, block9.point.Y + 40);
            lblP2.Location = new Point(lblP2.Location.X + 250, lblP2.Location.Y);
            lblP2Turn.Location = new Point(lblP2Turn.Location.X + 250,lblP2Turn.Location.Y);
            lblP2Points.Location = new Point(lblP2Points.Location.X + 250, lblP2Points.Location.Y);
            lblP1.Show();
            lblP2.Show();
            lblP1Points.Show();
            lblP2Points.Show();

        }

        public void draw(Graphics g)
        {
            Pen pen = new Pen(Color.Green, 7);
            if(gameMode)
                scene.drawAll(g,current);
            switch (winLine)
            {
                case 1:g.DrawLine(pen, 270, 150, 700, 150);break;
                case 2:g.DrawLine(pen, 270, 295, 700, 295);break;
                case 3:g.DrawLine(pen, 270, 440, 700, 440);break;
                case 4:g.DrawLine(pen, 340, 80, 340, 510);break;
                case 5:g.DrawLine(pen, 486, 80, 486, 510);break;
                case 6:g.DrawLine(pen, 627, 80, 627, 510);break;
                case 7:g.DrawLine(pen, 270, 80, 700, 510);break;
                case 8:g.DrawLine(pen, 270, 510, 700, 80);break;
               
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            game();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            draw(e.Graphics);
        }

        public bool inGame(Point p)
        {
            if(p.X>=270 && p.X < 700 && p.Y>=80 && p.Y < 510)
            {
                return true;
            }
            return false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (gameMode)
            {
                scene.isHit(e.Location);
                Cursor = Cursors.Hand;
                Invalidate();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (inGame(e.Location) && gameMode && playTime)
            {
                if (scene.selected == scene.blocks[0] && scene.blocks[0].isSet ==false)
                {
                    scene.blocks[0].isSet = true;
                    lblBlock1.Text = current.value.ToString();
                    lblBlock1.ForeColor = current.color;
                    moveCount++;
                    lblBlock1.Show();
                    win();
                }
                else if (scene.selected == scene.blocks[1] && scene.blocks[1].isSet == false)
                {
                    scene.blocks[1].isSet = true;
                    lblBlock2.Text = current.value.ToString();
                    lblBlock2.ForeColor = current.color;
                    moveCount++;
                    lblBlock2.Show();
                    win();
                }
                else if (scene.selected == scene.blocks[2] && scene.blocks[2].isSet == false)
                {
                    scene.blocks[2].isSet = true;
                    lblBlock3.Text = current.value.ToString();
                    lblBlock3.ForeColor = current.color;
                    moveCount++;
                    lblBlock3.Show();
                    win();
                }
                else if (scene.selected == scene.blocks[3] && scene.blocks[3].isSet == false)
                {
                    scene.blocks[3].isSet = true;
                    lblBlock4.Text = current.value.ToString();
                    lblBlock4.ForeColor = current.color;
                    moveCount++;
                    lblBlock4.Show();
                    win();
                }
                else if (scene.selected == scene.blocks[4] && scene.blocks[4].isSet == false)
                {
                    scene.blocks[4].isSet = true;
                    lblBlock5.Text = current.value.ToString();
                    lblBlock5.ForeColor = current.color;
                    moveCount++;
                    lblBlock5.Show();
                    win();
                }
                else if (scene.selected == scene.blocks[5] && scene.blocks[5].isSet == false)
                {
                    scene.blocks[5].isSet = true;
                    lblBlock6.Text = current.value.ToString();
                    lblBlock6.ForeColor = current.color;
                    moveCount++;
                    lblBlock6.Show();
                    win();
                }
                else if (scene.selected == scene.blocks[6] && scene.blocks[6].isSet == false)
                {
                    scene.blocks[6].isSet = true;
                    lblBlock7.Text = current.value.ToString();
                    lblBlock7.ForeColor = current.color;
                    lblBlock7.Show();
                    moveCount++;
                    win();
                }
                else if (scene.selected == scene.blocks[7] && scene.blocks[7].isSet == false)
                {
                    scene.blocks[7].isSet = true;
                    lblBlock8.Text = current.value.ToString();
                    lblBlock8.ForeColor = current.color;
                    lblBlock8.Show();
                    moveCount++;
                    win();
                }
                else if (scene.selected == scene.blocks[8] && scene.blocks[8].isSet == false)
                {
                    scene.blocks[8].isSet = true;
                    lblBlock9.Text = current.value.ToString();
                    lblBlock9.ForeColor = current.color;
                    lblBlock9.Show();
                    moveCount++;
                    win();
                }
                
            }
            
        }

        public void win()
        {
            if (checkWin())
            {
                current.score++;
                updateScore();
                if (current.score < 3)
                {
                    playTime = false;
                    timer1.Start();

                }

                else
                {
                    playTime = false;
                    timer2.Start();
                }


            }
            else if (moveCount == 9)
            {
                timer1.Start();
            }
            else
            {
                changePlayer();
            }

            Invalidate();
        }

        public void changePlayer()
        {
            if (current == p1)
            {
                current = p2;
                lblP2Turn.Visible = true;
                lblP1Turn.Visible = false;
            }
                
            else if (current == p2)
            {
                current = p1;
                lblP2Turn.Visible = false;
                lblP1Turn.Visible = true;
            }
                
        }
        public void resetGame()
        {

            playTime = true;
            foreach(Block block in scene.blocks)
            {
                block.isSet = false;
            }
            switchFirstPlayer();
            if (current == p1)
            {
                lblP1Turn.Visible = true;
                lblP2Turn.Visible = false;
            }
            else
            {
                lblP1Turn.Visible = false;
                lblP2Turn.Visible = true;
            }
            lblBlock1.Text = "";
            lblBlock2.Text = "";
            lblBlock3.Text = "";
            lblBlock4.Text = "";
            lblBlock5.Text = "";
            lblBlock6.Text = "";
            lblBlock7.Text = "";
            lblBlock8.Text = "";
            lblBlock9.Text = "";
            winLine = 0;
            moveCount = 0;
            Invalidate();
        }
        public void updateScore()
        {
            lblP1Points.Text = String.Format("{0}", p1.score);
            lblP2Points.Text = String.Format("{0}", p2.score);
        }

        public void switchFirstPlayer()
        {
            char tmp = current.value;
            if(current == p1)
            {
                p1.value = p2.value;
                p2.value = tmp;
                current = p2;
            }
            else
            {
                p2.value = p1.value;
                p1.value = tmp;
                current = p1;
            }

        }

        public bool checkWin()
        {
            if (lblBlock1.Text.Equals(current.value.ToString()) && lblBlock2.Text.Equals(current.value.ToString()) && lblBlock3.Text.Equals(current.value.ToString())){
                winLine = 1;
                return true;
            }
            else if(lblBlock4.Text.Equals(current.value.ToString()) && lblBlock5.Text.Equals(current.value.ToString()) && lblBlock6.Text.Equals(current.value.ToString()))
            {
                winLine = 2;
                return true;
            }
            else if (lblBlock7.Text.Equals(current.value.ToString()) && lblBlock8.Text.Equals(current.value.ToString()) && lblBlock9.Text.Equals(current.value.ToString()))
            {
                winLine = 3;
                return true;
            }
            else if (lblBlock1.Text.Equals(current.value.ToString()) && lblBlock4.Text.Equals(current.value.ToString()) && lblBlock7.Text.Equals(current.value.ToString()))
            {
                winLine = 4;
                return true;
            }
            else if (lblBlock2.Text.Equals(current.value.ToString()) && lblBlock5.Text.Equals(current.value.ToString()) && lblBlock8.Text.Equals(current.value.ToString()))
            {
                winLine = 5;
                return true;
            }
            else if (lblBlock3.Text.Equals(current.value.ToString()) && lblBlock6.Text.Equals(current.value.ToString()) && lblBlock9.Text.Equals(current.value.ToString()))
            {
                winLine = 6;
                return true;
            }
            else if (lblBlock1.Text.Equals(current.value.ToString()) && lblBlock5.Text.Equals(current.value.ToString()) && lblBlock9.Text.Equals(current.value.ToString()))
            {
                winLine = 7;
                return true;
            }
            else if (lblBlock7.Text.Equals(current.value.ToString()) && lblBlock5.Text.Equals(current.value.ToString()) && lblBlock3.Text.Equals(current.value.ToString()))
            {
                winLine = 8;
                return true;
            }
            Invalidate();
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i > 0)
            {
                i = 0;
                timer1.Stop();
                resetGame();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            j++;
            if(j > 0)
            {
                j = 0;
                timer2.Stop(); DialogResult dialogResult = MessageBox.Show("Player " + current.name + " has won.\nWould you like to start a new Game", "You Won", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    p1.score = 0;
                    p2.score = 0;
                    resetGame();
                    updateScore();
                }
                else
                {
                    Application.Exit();
                }
            }
           
        }
    }
}
