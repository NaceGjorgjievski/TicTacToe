namespace TicTacToe_203019
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblP1Points = new System.Windows.Forms.Label();
            this.lblP2Points = new System.Windows.Forms.Label();
            this.lblBlock1 = new System.Windows.Forms.Label();
            this.lblBlock2 = new System.Windows.Forms.Label();
            this.lblBlock3 = new System.Windows.Forms.Label();
            this.lblBlock4 = new System.Windows.Forms.Label();
            this.lblBlock5 = new System.Windows.Forms.Label();
            this.lblBlock6 = new System.Windows.Forms.Label();
            this.lblBlock7 = new System.Windows.Forms.Label();
            this.lblBlock8 = new System.Windows.Forms.Label();
            this.lblBlock9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblP1Turn = new System.Windows.Forms.Label();
            this.lblP2Turn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(309, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tic-Tac-Toe";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(193, 198);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(435, 66);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "New Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(193, 318);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(435, 66);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.ForeColor = System.Drawing.Color.Red;
            this.lblP1.Location = new System.Drawing.Point(100, 179);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(52, 36);
            this.lblP1.TabIndex = 3;
            this.lblP1.Text = "P1";
            this.lblP1.Visible = false;
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.ForeColor = System.Drawing.Color.Blue;
            this.lblP2.Location = new System.Drawing.Point(784, 179);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(52, 36);
            this.lblP2.TabIndex = 4;
            this.lblP2.Text = "P2";
            this.lblP2.Visible = false;
            // 
            // lblP1Points
            // 
            this.lblP1Points.AutoSize = true;
            this.lblP1Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1Points.ForeColor = System.Drawing.Color.Red;
            this.lblP1Points.Location = new System.Drawing.Point(67, 291);
            this.lblP1Points.Name = "lblP1Points";
            this.lblP1Points.Size = new System.Drawing.Size(120, 132);
            this.lblP1Points.TabIndex = 5;
            this.lblP1Points.Text = "0";
            this.lblP1Points.Visible = false;
            // 
            // lblP2Points
            // 
            this.lblP2Points.AutoSize = true;
            this.lblP2Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2Points.ForeColor = System.Drawing.Color.Blue;
            this.lblP2Points.Location = new System.Drawing.Point(755, 291);
            this.lblP2Points.Name = "lblP2Points";
            this.lblP2Points.Size = new System.Drawing.Size(120, 132);
            this.lblP2Points.TabIndex = 6;
            this.lblP2Points.Text = "0";
            this.lblP2Points.Visible = false;
            // 
            // lblBlock1
            // 
            this.lblBlock1.AutoSize = true;
            this.lblBlock1.BackColor = System.Drawing.Color.Transparent;
            this.lblBlock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlock1.Location = new System.Drawing.Point(62, 457);
            this.lblBlock1.Name = "lblBlock1";
            this.lblBlock1.Size = new System.Drawing.Size(0, 76);
            this.lblBlock1.TabIndex = 7;
            this.lblBlock1.Visible = false;
            // 
            // lblBlock2
            // 
            this.lblBlock2.AutoSize = true;
            this.lblBlock2.BackColor = System.Drawing.Color.Transparent;
            this.lblBlock2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlock2.Location = new System.Drawing.Point(193, 228);
            this.lblBlock2.Name = "lblBlock2";
            this.lblBlock2.Size = new System.Drawing.Size(0, 76);
            this.lblBlock2.TabIndex = 8;
            this.lblBlock2.Visible = false;
            // 
            // lblBlock3
            // 
            this.lblBlock3.AutoSize = true;
            this.lblBlock3.BackColor = System.Drawing.Color.Transparent;
            this.lblBlock3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlock3.Location = new System.Drawing.Point(148, 363);
            this.lblBlock3.Name = "lblBlock3";
            this.lblBlock3.Size = new System.Drawing.Size(0, 76);
            this.lblBlock3.TabIndex = 9;
            this.lblBlock3.Visible = false;
            // 
            // lblBlock4
            // 
            this.lblBlock4.AutoSize = true;
            this.lblBlock4.BackColor = System.Drawing.Color.Transparent;
            this.lblBlock4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlock4.Location = new System.Drawing.Point(212, 387);
            this.lblBlock4.Name = "lblBlock4";
            this.lblBlock4.Size = new System.Drawing.Size(0, 76);
            this.lblBlock4.TabIndex = 10;
            this.lblBlock4.Visible = false;
            // 
            // lblBlock5
            // 
            this.lblBlock5.AutoSize = true;
            this.lblBlock5.BackColor = System.Drawing.Color.Transparent;
            this.lblBlock5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlock5.Location = new System.Drawing.Point(295, 397);
            this.lblBlock5.Name = "lblBlock5";
            this.lblBlock5.Size = new System.Drawing.Size(0, 76);
            this.lblBlock5.TabIndex = 11;
            this.lblBlock5.Visible = false;
            // 
            // lblBlock6
            // 
            this.lblBlock6.AutoSize = true;
            this.lblBlock6.BackColor = System.Drawing.Color.Transparent;
            this.lblBlock6.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlock6.Location = new System.Drawing.Point(378, 397);
            this.lblBlock6.Name = "lblBlock6";
            this.lblBlock6.Size = new System.Drawing.Size(0, 76);
            this.lblBlock6.TabIndex = 12;
            this.lblBlock6.Visible = false;
            // 
            // lblBlock7
            // 
            this.lblBlock7.AutoSize = true;
            this.lblBlock7.BackColor = System.Drawing.Color.Transparent;
            this.lblBlock7.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlock7.Location = new System.Drawing.Point(472, 397);
            this.lblBlock7.Name = "lblBlock7";
            this.lblBlock7.Size = new System.Drawing.Size(0, 76);
            this.lblBlock7.TabIndex = 13;
            this.lblBlock7.Visible = false;
            // 
            // lblBlock8
            // 
            this.lblBlock8.AutoSize = true;
            this.lblBlock8.BackColor = System.Drawing.Color.Transparent;
            this.lblBlock8.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlock8.Location = new System.Drawing.Point(567, 397);
            this.lblBlock8.Name = "lblBlock8";
            this.lblBlock8.Size = new System.Drawing.Size(0, 76);
            this.lblBlock8.TabIndex = 14;
            this.lblBlock8.Visible = false;
            // 
            // lblBlock9
            // 
            this.lblBlock9.AutoSize = true;
            this.lblBlock9.BackColor = System.Drawing.Color.Transparent;
            this.lblBlock9.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlock9.Location = new System.Drawing.Point(662, 397);
            this.lblBlock9.Name = "lblBlock9";
            this.lblBlock9.Size = new System.Drawing.Size(0, 76);
            this.lblBlock9.TabIndex = 15;
            this.lblBlock9.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 800;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblP1Turn
            // 
            this.lblP1Turn.AutoSize = true;
            this.lblP1Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1Turn.ForeColor = System.Drawing.Color.Red;
            this.lblP1Turn.Location = new System.Drawing.Point(57, 446);
            this.lblP1Turn.Name = "lblP1Turn";
            this.lblP1Turn.Size = new System.Drawing.Size(169, 29);
            this.lblP1Turn.TabIndex = 16;
            this.lblP1Turn.Text = "YOUR TURN";
            this.lblP1Turn.Visible = false;
            // 
            // lblP2Turn
            // 
            this.lblP2Turn.AutoSize = true;
            this.lblP2Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2Turn.ForeColor = System.Drawing.Color.Blue;
            this.lblP2Turn.Location = new System.Drawing.Point(752, 446);
            this.lblP2Turn.Name = "lblP2Turn";
            this.lblP2Turn.Size = new System.Drawing.Size(169, 29);
            this.lblP2Turn.TabIndex = 17;
            this.lblP2Turn.Text = "YOUR TURN";
            this.lblP2Turn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 533);
            this.Controls.Add(this.lblP2Turn);
            this.Controls.Add(this.lblP1Turn);
            this.Controls.Add(this.lblBlock9);
            this.Controls.Add(this.lblBlock8);
            this.Controls.Add(this.lblBlock7);
            this.Controls.Add(this.lblBlock6);
            this.Controls.Add(this.lblBlock5);
            this.Controls.Add(this.lblBlock4);
            this.Controls.Add(this.lblBlock3);
            this.Controls.Add(this.lblBlock2);
            this.Controls.Add(this.lblBlock1);
            this.Controls.Add(this.lblP2Points);
            this.Controls.Add(this.lblP1Points);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label lblP1Points;
        private System.Windows.Forms.Label lblP2Points;
        private System.Windows.Forms.Label lblBlock1;
        private System.Windows.Forms.Label lblBlock2;
        private System.Windows.Forms.Label lblBlock3;
        private System.Windows.Forms.Label lblBlock4;
        private System.Windows.Forms.Label lblBlock5;
        private System.Windows.Forms.Label lblBlock6;
        private System.Windows.Forms.Label lblBlock7;
        private System.Windows.Forms.Label lblBlock8;
        private System.Windows.Forms.Label lblBlock9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblP1Turn;
        private System.Windows.Forms.Label lblP2Turn;
    }
}

