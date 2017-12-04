namespace nfs
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.mainCar = new System.Windows.Forms.PictureBox();
            this.rm12 = new System.Windows.Forms.PictureBox();
            this.rm13 = new System.Windows.Forms.PictureBox();
            this.rm14 = new System.Windows.Forms.PictureBox();
            this.rm15 = new System.Windows.Forms.PictureBox();
            this.rm11 = new System.Windows.Forms.PictureBox();
            this.rm21 = new System.Windows.Forms.PictureBox();
            this.rm31 = new System.Windows.Forms.PictureBox();
            this.rm41 = new System.Windows.Forms.PictureBox();
            this.rm25 = new System.Windows.Forms.PictureBox();
            this.rm24 = new System.Windows.Forms.PictureBox();
            this.rm23 = new System.Windows.Forms.PictureBox();
            this.rm22 = new System.Windows.Forms.PictureBox();
            this.rm35 = new System.Windows.Forms.PictureBox();
            this.rm34 = new System.Windows.Forms.PictureBox();
            this.rm33 = new System.Windows.Forms.PictureBox();
            this.rm32 = new System.Windows.Forms.PictureBox();
            this.rm45 = new System.Windows.Forms.PictureBox();
            this.rm44 = new System.Windows.Forms.PictureBox();
            this.rm43 = new System.Windows.Forms.PictureBox();
            this.rm42 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.enemy5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1141, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.exit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(640, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.start_Click);
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.BackgroundImage = global::nfs.Properties.Resources.enemy1;
            this.enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy1.Location = new System.Drawing.Point(913, 200);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(111, 182);
            this.enemy1.TabIndex = 3;
            this.enemy1.TabStop = false;
            // 
            // mainCar
            // 
            this.mainCar.BackColor = System.Drawing.Color.Transparent;
            this.mainCar.BackgroundImage = global::nfs.Properties.Resources.mainCar;
            this.mainCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainCar.Location = new System.Drawing.Point(623, 555);
            this.mainCar.Name = "mainCar";
            this.mainCar.Size = new System.Drawing.Size(111, 165);
            this.mainCar.TabIndex = 4;
            this.mainCar.TabStop = false;
            this.mainCar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.updateMainCar);
            // 
            // rm12
            // 
            this.rm12.BackColor = System.Drawing.Color.Transparent;
            this.rm12.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm12.Location = new System.Drawing.Point(454, 450);
            this.rm12.Name = "rm12";
            this.rm12.Size = new System.Drawing.Size(10, 156);
            this.rm12.TabIndex = 6;
            this.rm12.TabStop = false;
            // 
            // rm13
            // 
            this.rm13.BackColor = System.Drawing.Color.Transparent;
            this.rm13.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm13.Location = new System.Drawing.Point(454, 297);
            this.rm13.Name = "rm13";
            this.rm13.Size = new System.Drawing.Size(10, 156);
            this.rm13.TabIndex = 7;
            this.rm13.TabStop = false;
            // 
            // rm14
            // 
            this.rm14.BackColor = System.Drawing.Color.Transparent;
            this.rm14.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm14.Location = new System.Drawing.Point(454, 144);
            this.rm14.Name = "rm14";
            this.rm14.Size = new System.Drawing.Size(10, 156);
            this.rm14.TabIndex = 8;
            this.rm14.TabStop = false;
            // 
            // rm15
            // 
            this.rm15.BackColor = System.Drawing.Color.Transparent;
            this.rm15.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm15.Location = new System.Drawing.Point(454, -9);
            this.rm15.Name = "rm15";
            this.rm15.Size = new System.Drawing.Size(10, 156);
            this.rm15.TabIndex = 9;
            this.rm15.TabStop = false;
            // 
            // rm11
            // 
            this.rm11.BackColor = System.Drawing.Color.Transparent;
            this.rm11.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm11.Location = new System.Drawing.Point(454, 603);
            this.rm11.Name = "rm11";
            this.rm11.Size = new System.Drawing.Size(10, 156);
            this.rm11.TabIndex = 10;
            this.rm11.TabStop = false;
            // 
            // rm21
            // 
            this.rm21.BackColor = System.Drawing.Color.Transparent;
            this.rm21.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm21.Location = new System.Drawing.Point(600, 603);
            this.rm21.Name = "rm21";
            this.rm21.Size = new System.Drawing.Size(10, 156);
            this.rm21.TabIndex = 11;
            this.rm21.TabStop = false;
            // 
            // rm31
            // 
            this.rm31.BackColor = System.Drawing.Color.Transparent;
            this.rm31.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm31.Location = new System.Drawing.Point(746, 603);
            this.rm31.Name = "rm31";
            this.rm31.Size = new System.Drawing.Size(10, 156);
            this.rm31.TabIndex = 12;
            this.rm31.TabStop = false;
            // 
            // rm41
            // 
            this.rm41.BackColor = System.Drawing.Color.Transparent;
            this.rm41.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm41.Location = new System.Drawing.Point(892, 603);
            this.rm41.Name = "rm41";
            this.rm41.Size = new System.Drawing.Size(10, 156);
            this.rm41.TabIndex = 13;
            this.rm41.TabStop = false;
            // 
            // rm25
            // 
            this.rm25.BackColor = System.Drawing.Color.Transparent;
            this.rm25.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm25.Location = new System.Drawing.Point(600, -9);
            this.rm25.Name = "rm25";
            this.rm25.Size = new System.Drawing.Size(10, 156);
            this.rm25.TabIndex = 17;
            this.rm25.TabStop = false;
            // 
            // rm24
            // 
            this.rm24.BackColor = System.Drawing.Color.Transparent;
            this.rm24.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm24.Location = new System.Drawing.Point(600, 144);
            this.rm24.Name = "rm24";
            this.rm24.Size = new System.Drawing.Size(10, 156);
            this.rm24.TabIndex = 16;
            this.rm24.TabStop = false;
            // 
            // rm23
            // 
            this.rm23.BackColor = System.Drawing.Color.Transparent;
            this.rm23.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm23.Location = new System.Drawing.Point(600, 297);
            this.rm23.Name = "rm23";
            this.rm23.Size = new System.Drawing.Size(10, 156);
            this.rm23.TabIndex = 15;
            this.rm23.TabStop = false;
            // 
            // rm22
            // 
            this.rm22.BackColor = System.Drawing.Color.Transparent;
            this.rm22.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm22.Location = new System.Drawing.Point(600, 450);
            this.rm22.Name = "rm22";
            this.rm22.Size = new System.Drawing.Size(10, 156);
            this.rm22.TabIndex = 14;
            this.rm22.TabStop = false;
            // 
            // rm35
            // 
            this.rm35.BackColor = System.Drawing.Color.Transparent;
            this.rm35.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm35.Location = new System.Drawing.Point(746, -9);
            this.rm35.Name = "rm35";
            this.rm35.Size = new System.Drawing.Size(10, 156);
            this.rm35.TabIndex = 21;
            this.rm35.TabStop = false;
            // 
            // rm34
            // 
            this.rm34.BackColor = System.Drawing.Color.Transparent;
            this.rm34.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm34.Location = new System.Drawing.Point(746, 144);
            this.rm34.Name = "rm34";
            this.rm34.Size = new System.Drawing.Size(10, 156);
            this.rm34.TabIndex = 20;
            this.rm34.TabStop = false;
            // 
            // rm33
            // 
            this.rm33.BackColor = System.Drawing.Color.Transparent;
            this.rm33.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm33.Location = new System.Drawing.Point(746, 297);
            this.rm33.Name = "rm33";
            this.rm33.Size = new System.Drawing.Size(10, 156);
            this.rm33.TabIndex = 19;
            this.rm33.TabStop = false;
            // 
            // rm32
            // 
            this.rm32.BackColor = System.Drawing.Color.Transparent;
            this.rm32.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm32.Location = new System.Drawing.Point(746, 450);
            this.rm32.Name = "rm32";
            this.rm32.Size = new System.Drawing.Size(10, 156);
            this.rm32.TabIndex = 18;
            this.rm32.TabStop = false;
            // 
            // rm45
            // 
            this.rm45.BackColor = System.Drawing.Color.Transparent;
            this.rm45.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm45.Location = new System.Drawing.Point(892, -9);
            this.rm45.Name = "rm45";
            this.rm45.Size = new System.Drawing.Size(10, 156);
            this.rm45.TabIndex = 25;
            this.rm45.TabStop = false;
            // 
            // rm44
            // 
            this.rm44.BackColor = System.Drawing.Color.Transparent;
            this.rm44.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm44.Location = new System.Drawing.Point(892, 144);
            this.rm44.Name = "rm44";
            this.rm44.Size = new System.Drawing.Size(10, 156);
            this.rm44.TabIndex = 24;
            this.rm44.TabStop = false;
            // 
            // rm43
            // 
            this.rm43.BackColor = System.Drawing.Color.Transparent;
            this.rm43.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm43.Location = new System.Drawing.Point(892, 297);
            this.rm43.Name = "rm43";
            this.rm43.Size = new System.Drawing.Size(10, 156);
            this.rm43.TabIndex = 23;
            this.rm43.TabStop = false;
            // 
            // rm42
            // 
            this.rm42.BackColor = System.Drawing.Color.Transparent;
            this.rm42.BackgroundImage = global::nfs.Properties.Resources.roadMarking;
            this.rm42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rm42.Location = new System.Drawing.Point(892, 450);
            this.rm42.Name = "rm42";
            this.rm42.Size = new System.Drawing.Size(10, 156);
            this.rm42.TabIndex = 22;
            this.rm42.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.BackgroundImage = global::nfs.Properties.Resources.enemy2;
            this.enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy2.Location = new System.Drawing.Point(333, 200);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(111, 182);
            this.enemy2.TabIndex = 26;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Transparent;
            this.enemy3.BackgroundImage = global::nfs.Properties.Resources.enemy3;
            this.enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy3.Location = new System.Drawing.Point(478, 407);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(111, 182);
            this.enemy3.TabIndex = 27;
            this.enemy3.TabStop = false;
            // 
            // enemy4
            // 
            this.enemy4.BackColor = System.Drawing.Color.Transparent;
            this.enemy4.BackgroundImage = global::nfs.Properties.Resources.enemy4;
            this.enemy4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy4.Location = new System.Drawing.Point(768, 144);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(111, 182);
            this.enemy4.TabIndex = 28;
            this.enemy4.TabStop = false;
            // 
            // enemy5
            // 
            this.enemy5.BackColor = System.Drawing.Color.Transparent;
            this.enemy5.BackgroundImage = global::nfs.Properties.Resources.enemy2;
            this.enemy5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy5.Location = new System.Drawing.Point(768, 424);
            this.enemy5.Name = "enemy5";
            this.enemy5.Size = new System.Drawing.Size(111, 182);
            this.enemy5.TabIndex = 29;
            this.enemy5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::nfs.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.enemy5);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.rm45);
            this.Controls.Add(this.rm44);
            this.Controls.Add(this.rm43);
            this.Controls.Add(this.rm42);
            this.Controls.Add(this.rm35);
            this.Controls.Add(this.rm34);
            this.Controls.Add(this.rm33);
            this.Controls.Add(this.rm32);
            this.Controls.Add(this.rm25);
            this.Controls.Add(this.rm24);
            this.Controls.Add(this.rm23);
            this.Controls.Add(this.rm22);
            this.Controls.Add(this.rm41);
            this.Controls.Add(this.rm31);
            this.Controls.Add(this.rm21);
            this.Controls.Add(this.rm11);
            this.Controls.Add(this.rm15);
            this.Controls.Add(this.rm14);
            this.Controls.Add(this.rm13);
            this.Controls.Add(this.rm12);
            this.Controls.Add(this.mainCar);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rm42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox mainCar;
        private System.Windows.Forms.PictureBox rm12;
        private System.Windows.Forms.PictureBox rm13;
        private System.Windows.Forms.PictureBox rm14;
        private System.Windows.Forms.PictureBox rm15;
        private System.Windows.Forms.PictureBox rm11;
        private System.Windows.Forms.PictureBox rm21;
        private System.Windows.Forms.PictureBox rm31;
        private System.Windows.Forms.PictureBox rm41;
        private System.Windows.Forms.PictureBox rm25;
        private System.Windows.Forms.PictureBox rm24;
        private System.Windows.Forms.PictureBox rm23;
        private System.Windows.Forms.PictureBox rm22;
        private System.Windows.Forms.PictureBox rm35;
        private System.Windows.Forms.PictureBox rm34;
        private System.Windows.Forms.PictureBox rm33;
        private System.Windows.Forms.PictureBox rm32;
        private System.Windows.Forms.PictureBox rm45;
        private System.Windows.Forms.PictureBox rm44;
        private System.Windows.Forms.PictureBox rm43;
        private System.Windows.Forms.PictureBox rm42;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.PictureBox enemy5;
    }
}

