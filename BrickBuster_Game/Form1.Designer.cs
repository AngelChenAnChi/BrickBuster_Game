
namespace Brick_Buster_Game
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_level = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_life3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_life2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_life = new System.Windows.Forms.PictureBox();
            this.pictureBox_bar = new System.Windows.Forms.PictureBox();
            this.pictureBox_ball = new System.Windows.Forms.PictureBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.label_count = new System.Windows.Forms.Label();
            this.label_instruction = new System.Windows.Forms.Label();
            this.pictureBox_brick = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_countDown = new System.Windows.Forms.Timer(this.components);
            this.label_over = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_life)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_brick)).BeginInit();
            this.SuspendLayout();
            // 
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_level.ForeColor = System.Drawing.Color.White;
            this.label_level.Location = new System.Drawing.Point(12, 9);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(117, 38);
            this.label_level.TabIndex = 0;
            this.label_level.Text = "label1";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.SystemColors.InfoText;
            this.label_score.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.ForeColor = System.Drawing.Color.Gold;
            this.label_score.Location = new System.Drawing.Point(567, 10);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(147, 38);
            this.label_score.TabIndex = 1;
            this.label_score.Text = "SCORE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(947, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Life:";
            // 
            // pictureBox_life3
            // 
            this.pictureBox_life3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_life3.Image")));
            this.pictureBox_life3.Location = new System.Drawing.Point(1046, 9);
            this.pictureBox_life3.Name = "pictureBox_life3";
            this.pictureBox_life3.Size = new System.Drawing.Size(46, 40);
            this.pictureBox_life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_life3.TabIndex = 3;
            this.pictureBox_life3.TabStop = false;
            // 
            // pictureBox_life2
            // 
            this.pictureBox_life2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_life2.Image")));
            this.pictureBox_life2.Location = new System.Drawing.Point(1112, 8);
            this.pictureBox_life2.Name = "pictureBox_life2";
            this.pictureBox_life2.Size = new System.Drawing.Size(46, 40);
            this.pictureBox_life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_life2.TabIndex = 4;
            this.pictureBox_life2.TabStop = false;
            // 
            // pictureBox_life
            // 
            this.pictureBox_life.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_life.Image")));
            this.pictureBox_life.Location = new System.Drawing.Point(1179, 8);
            this.pictureBox_life.Name = "pictureBox_life";
            this.pictureBox_life.Size = new System.Drawing.Size(46, 40);
            this.pictureBox_life.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_life.TabIndex = 5;
            this.pictureBox_life.TabStop = false;
            // 
            // pictureBox_bar
            // 
            this.pictureBox_bar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_bar.Image")));
            this.pictureBox_bar.Location = new System.Drawing.Point(549, 609);
            this.pictureBox_bar.Name = "pictureBox_bar";
            this.pictureBox_bar.Size = new System.Drawing.Size(205, 31);
            this.pictureBox_bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bar.TabIndex = 6;
            this.pictureBox_bar.TabStop = false;
            // 
            // pictureBox_ball
            // 
            this.pictureBox_ball.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ball.Image")));
            this.pictureBox_ball.Location = new System.Drawing.Point(617, 441);
            this.pictureBox_ball.Name = "pictureBox_ball";
            this.pictureBox_ball.Size = new System.Drawing.Size(58, 52);
            this.pictureBox_ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ball.TabIndex = 7;
            this.pictureBox_ball.TabStop = false;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_exit.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(544, 209);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(210, 50);
            this.button_exit.TabIndex = 8;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Visible = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_start.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(544, 282);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(210, 50);
            this.button_start.TabIndex = 9;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Cooper Black", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count.ForeColor = System.Drawing.Color.White;
            this.label_count.Location = new System.Drawing.Point(931, 242);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(130, 137);
            this.label_count.TabIndex = 10;
            this.label_count.Text = "3";
            this.label_count.Visible = false;
            // 
            // label_instruction
            // 
            this.label_instruction.AutoSize = true;
            this.label_instruction.BackColor = System.Drawing.Color.GreenYellow;
            this.label_instruction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_instruction.Location = new System.Drawing.Point(316, 354);
            this.label_instruction.Name = "label_instruction";
            this.label_instruction.Size = new System.Drawing.Size(669, 128);
            this.label_instruction.TabIndex = 11;
            this.label_instruction.Text = "-> : right     <- : left  \r\nEnter : start    Space : pause   Esc : exit\r\nWhen you" +
    " break one brick, you will get 5 points.\r\nWhen you miss the ball, you will loose" +
    " 10 points.\r\n";
            this.label_instruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_brick
            // 
            this.pictureBox_brick.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_brick.Image")));
            this.pictureBox_brick.Location = new System.Drawing.Point(71, 107);
            this.pictureBox_brick.Name = "pictureBox_brick";
            this.pictureBox_brick.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_brick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_brick.TabIndex = 12;
            this.pictureBox_brick.TabStop = false;
            this.pictureBox_brick.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_countDown
            // 
            this.timer_countDown.Interval = 1000;
            this.timer_countDown.Tick += new System.EventHandler(this.timer_countDown_Tick);
            // 
            // label_over
            // 
            this.label_over.AutoSize = true;
            this.label_over.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_over.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_over.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_over.Location = new System.Drawing.Point(537, 354);
            this.label_over.Name = "label_over";
            this.label_over.Size = new System.Drawing.Size(231, 38);
            this.label_over.TabIndex = 13;
            this.label_over.Text = "GAME OVER";
            this.label_over.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1250, 652);
            this.Controls.Add(this.label_over);
            this.Controls.Add(this.pictureBox_brick);
            this.Controls.Add(this.label_instruction);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.pictureBox_ball);
            this.Controls.Add(this.pictureBox_bar);
            this.Controls.Add(this.pictureBox_life);
            this.Controls.Add(this.pictureBox_life2);
            this.Controls.Add(this.pictureBox_life3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_level);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brick Buster Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_life)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_brick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_life3;
        private System.Windows.Forms.PictureBox pictureBox_life2;
        private System.Windows.Forms.PictureBox pictureBox_life;
        private System.Windows.Forms.PictureBox pictureBox_bar;
        private System.Windows.Forms.PictureBox pictureBox_ball;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label_instruction;
        private System.Windows.Forms.PictureBox pictureBox_brick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer_countDown;
        private System.Windows.Forms.Label label_over;
    }
}

