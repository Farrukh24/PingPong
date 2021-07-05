
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground = new System.Windows.Forms.Panel();
            this.racket = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playground
            // 
            this.playground.Controls.Add(this.label2);
            this.playground.Controls.Add(this.label1);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1182, 653);
            this.playground.TabIndex = 2;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.SystemColors.ControlText;
            this.racket.Location = new System.Drawing.Point(434, 564);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(271, 33);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Crimson;
            this.ball.Location = new System.Drawing.Point(434, 323);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(32, 31);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(750, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 414);
            this.label2.TabIndex = 3;
            this.label2.Text = "GAME OVER\r\n\r\nF - RESTART\r\nQ - QUIT\r\nS - SCORE\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.playground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Ping Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

