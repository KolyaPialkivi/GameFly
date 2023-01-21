namespace CarGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxCar1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar4 = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCar1
            // 
            this.pictureBoxCar1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCar1.Image = global::CarGame.Properties.Resources.car2_green;
            this.pictureBoxCar1.Location = new System.Drawing.Point(12, 30);
            this.pictureBoxCar1.Name = "pictureBoxCar1";
            this.pictureBoxCar1.Size = new System.Drawing.Size(71, 84);
            this.pictureBoxCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar1.TabIndex = 0;
            this.pictureBoxCar1.TabStop = false;
            this.pictureBoxCar1.Click += new System.EventHandler(this.pictureBoxCar1_Click);
            // 
            // pictureBoxCar2
            // 
            this.pictureBoxCar2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCar2.Image = global::CarGame.Properties.Resources.car2_yellow;
            this.pictureBoxCar2.Location = new System.Drawing.Point(12, 120);
            this.pictureBoxCar2.Name = "pictureBoxCar2";
            this.pictureBoxCar2.Size = new System.Drawing.Size(71, 71);
            this.pictureBoxCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar2.TabIndex = 1;
            this.pictureBoxCar2.TabStop = false;
            // 
            // pictureBoxCar3
            // 
            this.pictureBoxCar3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCar3.Image = global::CarGame.Properties.Resources.car21;
            this.pictureBoxCar3.Location = new System.Drawing.Point(12, 197);
            this.pictureBoxCar3.Name = "pictureBoxCar3";
            this.pictureBoxCar3.Size = new System.Drawing.Size(71, 84);
            this.pictureBoxCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar3.TabIndex = 2;
            this.pictureBoxCar3.TabStop = false;
            // 
            // pictureBoxCar4
            // 
            this.pictureBoxCar4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCar4.Image = global::CarGame.Properties.Resources.car2_green1;
            this.pictureBoxCar4.Location = new System.Drawing.Point(12, 287);
            this.pictureBoxCar4.Name = "pictureBoxCar4";
            this.pictureBoxCar4.Size = new System.Drawing.Size(71, 84);
            this.pictureBoxCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar4.TabIndex = 3;
            this.pictureBoxCar4.TabStop = false;
            // 
            // timerGame
            // 
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Enabled = false;
            this.buttonFinish.Location = new System.Drawing.Point(653, 30);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(10, 341);
            this.buttonFinish.TabIndex = 4;
            this.buttonFinish.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonStart.Location = new System.Drawing.Point(1, 360);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(103, 38);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarGame.Properties.Resources.road_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(704, 400);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBoxCar4);
            this.Controls.Add(this.pictureBoxCar3);
            this.Controls.Add(this.pictureBoxCar2);
            this.Controls.Add(this.pictureBoxCar1);
            this.Controls.Add(this.buttonFinish);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "CarGame v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCar1;
        private System.Windows.Forms.PictureBox pictureBoxCar2;
        private System.Windows.Forms.PictureBox pictureBoxCar3;
        private System.Windows.Forms.PictureBox pictureBoxCar4;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonStart;
    }
}

