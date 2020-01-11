namespace Ping_Pong
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.canvas = new System.Windows.Forms.Panel();
            this.gameInfo = new System.Windows.Forms.Label();
            this.gameScore = new System.Windows.Forms.Label();
            this.bat = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.Label();
            this.canvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // canvas
            // 
            this.canvas.AutoSize = true;
            this.canvas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.canvas.Controls.Add(this.info);
            this.canvas.Controls.Add(this.gameInfo);
            this.canvas.Controls.Add(this.gameScore);
            this.canvas.Controls.Add(this.bat);
            this.canvas.Controls.Add(this.ball);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(899, 475);
            this.canvas.TabIndex = 0;
            // 
            // gameInfo
            // 
            this.gameInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameInfo.AutoSize = true;
            this.gameInfo.Font = new System.Drawing.Font("Arial Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameInfo.Location = new System.Drawing.Point(328, 198);
            this.gameInfo.Name = "gameInfo";
            this.gameInfo.Size = new System.Drawing.Size(295, 46);
            this.gameInfo.TabIndex = 3;
            this.gameInfo.Text = "Вы проиграли!";
            this.gameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameInfo.Visible = false;
            // 
            // gameScore
            // 
            this.gameScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gameScore.AutoSize = true;
            this.gameScore.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameScore.Location = new System.Drawing.Point(800, 10);
            this.gameScore.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.gameScore.Name = "gameScore";
            this.gameScore.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.gameScore.Size = new System.Drawing.Size(93, 24);
            this.gameScore.TabIndex = 2;
            this.gameScore.Text = "Счёт: 0";
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Blue;
            this.bat.Location = new System.Drawing.Point(300, 440);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(200, 20);
            this.bat.TabIndex = 1;
            this.bat.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(375, 100);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(10, 10);
            this.info.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.info.Name = "info";
            this.info.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.info.Size = new System.Drawing.Size(79, 24);
            this.info.TabIndex = 4;
            this.info.Text = "Инфо";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 475);
            this.Controls.Add(this.canvas);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.canvas.ResumeLayout(false);
            this.canvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label gameScore;
        private System.Windows.Forms.Label gameInfo;
        private System.Windows.Forms.Label info;
    }
}

