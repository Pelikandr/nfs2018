using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nfs
{
    public partial class Form1 : Form
    {
        private readonly Timer updateTimer;
        private readonly Timer increaseSpeedTimer;
        private readonly Timer updateEnemyTimer;
        
        public Form1()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            updateTimer = new Timer(); 
            updateTimer.Interval = 200; 
            updateTimer.Tick +=update;
            updateTimer.Enabled = true;
            increaseSpeedTimer = new Timer();
            increaseSpeedTimer.Interval = 5000;
            increaseSpeedTimer.Tick += IncreaseSpeedTimerTick;
            updateEnemyTimer = new Timer();
            updateEnemyTimer.Interval = 200;
            updateEnemyTimer.Tick += updateEnemyTimerTick;
            
            InitializeComponent();
            DoubleBuffered = true;
            
        }

        void updateEnemyTimerTick(object sender, EventArgs e)
        {
            enemy1.Location = new Point(enemy1.Location.X, enemy1.Location.Y + 10);
        }

        private void IncreaseSpeedTimerTick(object sender, EventArgs e)
        {
            if (updateTimer.Interval < 20)
                updateTimer.Interval = 10;
            else
                updateTimer.Interval -= 10;
        }
        

        public void enemyAppearence(PictureBox[] enemy, Point[] line)
        {
            for (int i = 0; i < enemy.Length; i++)
            {
                Random rand = new Random();
                int lineNumber = rand.Next(0, 5);
                enemy[i].Location = line[lineNumber];
            }
        }

        public void updateRoad(PictureBox[] rm, Point[] rmStartPosition, Point border)
        {
            for (int i=0; i<rm.Length; i++)
            {
                rm[i].Location = new Point(rm[i].Location.X, rm[i].Location.Y + 25);
                if (rm[i].Location.Y > border.Y && i<5)
                    rm[i].Location = rmStartPosition[0];
                else if (rm[i].Location.Y > border.Y && i > 4 && i < 10 )
                    rm[i].Location = rmStartPosition[1];
                else if (rm[i].Location.Y > border.Y && i > 9 && i < 15)
                    rm[i].Location = rmStartPosition[2];
                else if (rm[i].Location.Y > border.Y && i > 14 && i < 20)
                    rm[i].Location = rmStartPosition[3];
            }
        }
        private void update(object sender, EventArgs e)
        {
            Point rm1 = new Point(454, -50); // начальные позиции разметки
            Point rm2 = new Point(600, -50);
            Point rm3 = new Point(746, -50);
            Point rm4 = new Point(892, -50);
            Point line1 = new Point(333, -50); //начальные позиции машин
            Point line2 = new Point(478, -50);
            Point line3 = new Point(623, -50);
            Point line4 = new Point(768, -50);
            Point line5 = new Point(913, -50);
            Point border = new Point(0, 714); 
            Point[] line = new Point[] { line1, line2, line3, line4, line5 };
            //Point[] rmLocation = new Point[] { rm11.Location, rm12.Location, rm13.Location, rm14.Location, rm15.Location, rm21.Location, rm22.Location, rm23.Location, rm24.Location, rm25.Location, rm31.Location, rm32.Location, rm33.Location, rm34.Location, rm35.Location, rm41.Location, rm42.Location, rm43.Location, rm44.Location, rm45.Location };
            Point[] rmStartPosition = new Point[] { rm1, rm2, rm3, rm4 };
            PictureBox[] rm = new PictureBox[] { rm11, rm12, rm13, rm14, rm15, rm21, rm22, rm23, rm24, rm25, rm31, rm32, rm33, rm34, rm35, rm41, rm42, rm43, rm44, rm45 };
            PictureBox[] enemy = new PictureBox[] { enemy1 };

            updateRoad(rm, rmStartPosition, border);
            //enemyAppearence(enemy, line);
            
        }

        

        private void updateMainCar(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.A)
                mainCar.Location = new Point(mainCar.Location.X - 145, mainCar.Location.Y);
            if (e.KeyData == Keys.D)
                mainCar.Location = new Point(mainCar.Location.X + 145, mainCar.Location.Y);
        }

        private void start_Click(object sender, EventArgs e)//start
        {
            button2.Hide();
            mainCar.Focus();
            increaseSpeedTimer.Enabled = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
