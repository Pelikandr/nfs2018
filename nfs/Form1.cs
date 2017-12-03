uusing System;
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
        private readonly Timer updateRoadTimer;
        public Form1()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            updateRoadTimer = new Timer();
            updateRoadTimer.Interval = 20;
            updateRoadTimer.Tick += updateRoadTimerTick;
            updateRoadTimer.Enabled = true;
            InitializeComponent();
            DoubleBuffered = true;

        }

        private void updateRoadTimerTick(object sender, EventArgs e)
        {
            Point rm1 = new Point(454, -22); // начальные позиции разметки
            Point rm2 = new Point(600, -22);
            Point rm3 = new Point(746, -22);
            Point rm4 = new Point(892, -22);
            Point border = new Point(0, 750);

            rm11.Location = new Point(rm11.Location.X, rm11.Location.Y + 10);
            rm12.Location = new Point(rm12.Location.X, rm12.Location.Y + 10);
            rm13.Location = new Point(rm13.Location.X, rm13.Location.Y + 10);
            rm14.Location = new Point(rm14.Location.X, rm14.Location.Y + 10);
            rm15.Location = new Point(rm15.Location.X, rm15.Location.Y + 10);
            rm21.Location = new Point(rm21.Location.X, rm21.Location.Y + 10);
            rm22.Location = new Point(rm22.Location.X, rm22.Location.Y + 10);
            rm23.Location = new Point(rm23.Location.X, rm23.Location.Y + 10);
            rm24.Location = new Point(rm24.Location.X, rm24.Location.Y + 10);
            rm25.Location = new Point(rm25.Location.X, rm25.Location.Y + 10);
            rm31.Location = new Point(rm31.Location.X, rm31.Location.Y + 10);
            rm32.Location = new Point(rm32.Location.X, rm32.Location.Y + 10);
            rm33.Location = new Point(rm33.Location.X, rm33.Location.Y + 10);
            rm34.Location = new Point(rm34.Location.X, rm34.Location.Y + 10);
            rm35.Location = new Point(rm35.Location.X, rm35.Location.Y + 10);
            rm41.Location = new Point(rm41.Location.X, rm41.Location.Y + 10);
            rm42.Location = new Point(rm42.Location.X, rm42.Location.Y + 10);
            rm43.Location = new Point(rm43.Location.X, rm43.Location.Y + 10);
            rm44.Location = new Point(rm44.Location.X, rm44.Location.Y + 10);
            rm45.Location = new Point(rm45.Location.X, rm45.Location.Y + 10);

            if (rm11.Location.Y > border.Y)
                rm11.Location = rm1;
            if (rm12.Location.Y > border.Y)
                rm12.Location = rm1;
            if (rm13.Location.Y > border.Y)
                rm13.Location = rm1;
            if (rm14.Location.Y > border.Y)
                rm14.Location = rm1;
            if (rm15.Location.Y > border.Y)
                rm15.Location = rm1;
            if (rm21.Location.Y > border.Y)
                rm21.Location = rm2;
            if (rm22.Location.Y > border.Y)
                rm22.Location = rm2;
            if (rm23.Location.Y > border.Y)
                rm23.Location = rm2;
            if (rm24.Location.Y > border.Y)
                rm24.Location = rm2;
            if (rm25.Location.Y > border.Y)
                rm25.Location = rm2;
            if (rm31.Location.Y > border.Y)
                rm31.Location = rm3;
            if (rm32.Location.Y > border.Y)
                rm32.Location = rm3;
            if (rm33.Location.Y > border.Y)
                rm33.Location = rm3;
            if (rm34.Location.Y > border.Y)
                rm34.Location = rm3;
            if (rm35.Location.Y > border.Y)
                rm35.Location = rm3;
            if (rm41.Location.Y > border.Y)
                rm41.Location = rm4;
            if (rm42.Location.Y > border.Y)
                rm42.Location = rm4;
            if (rm43.Location.Y > border.Y)
                rm43.Location = rm4;
            if (rm44.Location.Y > border.Y)
                rm44.Location = rm4;
            if (rm45.Location.Y > border.Y)
                rm45.Location = rm4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        }
    }
}
