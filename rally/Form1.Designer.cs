namespace rally
{
    partial class Rally
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rally));
            this.bg = new System.Windows.Forms.Panel();
            this.finalScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.test_text = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.explosion = new System.Windows.Forms.PictureBox();
            this.AIcar2 = new System.Windows.Forms.PictureBox();
            this.AIcar1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.road2 = new System.Windows.Forms.PictureBox();
            this.road = new System.Windows.Forms.PictureBox();
            this.bg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIcar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIcar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).BeginInit();
            this.SuspendLayout();
            // 
            // bg
            // 
            this.bg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.bg.Controls.Add(this.explosion);
            this.bg.Controls.Add(this.finalScore);
            this.bg.Controls.Add(this.AIcar2);
            this.bg.Controls.Add(this.AIcar1);
            this.bg.Controls.Add(this.player);
            this.bg.Controls.Add(this.road2);
            this.bg.Controls.Add(this.road);
            this.bg.Location = new System.Drawing.Point(12, 12);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(470, 519);
            this.bg.TabIndex = 0;
            // 
            // finalScore
            // 
            this.finalScore.BackColor = System.Drawing.Color.White;
            this.finalScore.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalScore.Location = new System.Drawing.Point(109, 191);
            this.finalScore.Name = "finalScore";
            this.finalScore.Size = new System.Drawing.Size(261, 71);
            this.finalScore.TabIndex = 5;
            this.finalScore.Text = "GAME OVER\r\nFinal Score : 0";
            this.finalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(188, 572);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 41);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // score
            // 
            this.score.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.White;
            this.score.Location = new System.Drawing.Point(13, 540);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(469, 29);
            this.score.TabIndex = 2;
            this.score.Text = "Score: 0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // test_text
            // 
            this.test_text.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_text.ForeColor = System.Drawing.Color.White;
            this.test_text.Location = new System.Drawing.Point(12, 622);
            this.test_text.Name = "test_text";
            this.test_text.Size = new System.Drawing.Size(470, 121);
            this.test_text.TabIndex = 3;
            this.test_text.Text = "Press LEFT and RIGHT to move\r\n\r\nPress START to restart the game";
            this.test_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimeEvent);
            // 
            // explosion
            // 
            this.explosion.BackColor = System.Drawing.Color.Transparent;
            this.explosion.Image = global::rally.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(103, 424);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 6;
            this.explosion.TabStop = false;
            // 
            // AIcar2
            // 
            this.AIcar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.AIcar2.Image = global::rally.Properties.Resources.car2;
            this.AIcar2.Location = new System.Drawing.Point(315, 56);
            this.AIcar2.Name = "AIcar2";
            this.AIcar2.Size = new System.Drawing.Size(55, 100);
            this.AIcar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AIcar2.TabIndex = 4;
            this.AIcar2.TabStop = false;
            this.AIcar2.Tag = "carRight";
            // 
            // AIcar1
            // 
            this.AIcar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.AIcar1.Image = global::rally.Properties.Resources.car1;
            this.AIcar1.Location = new System.Drawing.Point(112, 56);
            this.AIcar1.Name = "AIcar1";
            this.AIcar1.Size = new System.Drawing.Size(55, 100);
            this.AIcar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AIcar1.TabIndex = 3;
            this.AIcar1.TabStop = false;
            this.AIcar1.Tag = "carLeft";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.player.Image = global::rally.Properties.Resources.car;
            this.player.Location = new System.Drawing.Point(205, 388);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(55, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // road2
            // 
            this.road2.Image = global::rally.Properties.Resources.roadtrack;
            this.road2.Location = new System.Drawing.Point(0, -490);
            this.road2.Name = "road2";
            this.road2.Size = new System.Drawing.Size(475, 520);
            this.road2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road2.TabIndex = 1;
            this.road2.TabStop = false;
            // 
            // road
            // 
            this.road.Image = global::rally.Properties.Resources.new_road;
            this.road.Location = new System.Drawing.Point(0, 0);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(475, 520);
            this.road.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road.TabIndex = 0;
            this.road.TabStop = false;
            // 
            // Rally
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(494, 773);
            this.Controls.Add(this.test_text);
            this.Controls.Add(this.score);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.bg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rally";
            this.Text = "Rally";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.bg.ResumeLayout(false);
            this.bg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIcar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIcar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bg;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label test_text;
        private System.Windows.Forms.PictureBox road;
        private System.Windows.Forms.PictureBox road2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox AIcar2;
        private System.Windows.Forms.PictureBox AIcar1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.Label finalScore;
    }
}

