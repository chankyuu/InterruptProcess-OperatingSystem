namespace InterruptProject
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox2_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2_3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5_3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6_3 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Interrupt1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterruptProject.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(86, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InterruptProject.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(86, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(639, 350);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InterruptProject.Properties.Resources._3;
            this.pictureBox3.Location = new System.Drawing.Point(86, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(639, 350);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::InterruptProject.Properties.Resources._4;
            this.pictureBox4.Location = new System.Drawing.Point(86, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(639, 350);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::InterruptProject.Properties.Resources._5;
            this.pictureBox5.Location = new System.Drawing.Point(86, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(639, 350);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::InterruptProject.Properties.Resources._6;
            this.pictureBox6.Location = new System.Drawing.Point(86, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(639, 350);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::InterruptProject.Properties.Resources._7;
            this.pictureBox7.Location = new System.Drawing.Point(86, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(639, 350);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::InterruptProject.Properties.Resources._8;
            this.pictureBox8.Location = new System.Drawing.Point(86, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(639, 350);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::InterruptProject.Properties.Resources._9;
            this.pictureBox9.Location = new System.Drawing.Point(86, 12);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(639, 350);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            // 
            // pictureBox2_2
            // 
            this.pictureBox2_2.Image = global::InterruptProject.Properties.Resources._2_2;
            this.pictureBox2_2.Location = new System.Drawing.Point(86, 12);
            this.pictureBox2_2.Name = "pictureBox2_2";
            this.pictureBox2_2.Size = new System.Drawing.Size(639, 350);
            this.pictureBox2_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2_2.TabIndex = 16;
            this.pictureBox2_2.TabStop = false;
            this.pictureBox2_2.Visible = false;
            // 
            // pictureBox2_3
            // 
            this.pictureBox2_3.Image = global::InterruptProject.Properties.Resources._2_3;
            this.pictureBox2_3.Location = new System.Drawing.Point(86, 12);
            this.pictureBox2_3.Name = "pictureBox2_3";
            this.pictureBox2_3.Size = new System.Drawing.Size(639, 350);
            this.pictureBox2_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2_3.TabIndex = 17;
            this.pictureBox2_3.TabStop = false;
            this.pictureBox2_3.Visible = false;
            // 
            // pictureBox5_2
            // 
            this.pictureBox5_2.Image = global::InterruptProject.Properties.Resources._5_2;
            this.pictureBox5_2.Location = new System.Drawing.Point(86, 12);
            this.pictureBox5_2.Name = "pictureBox5_2";
            this.pictureBox5_2.Size = new System.Drawing.Size(639, 350);
            this.pictureBox5_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5_2.TabIndex = 18;
            this.pictureBox5_2.TabStop = false;
            this.pictureBox5_2.Visible = false;
            // 
            // pictureBox5_3
            // 
            this.pictureBox5_3.Image = global::InterruptProject.Properties.Resources._5_3;
            this.pictureBox5_3.Location = new System.Drawing.Point(86, 12);
            this.pictureBox5_3.Name = "pictureBox5_3";
            this.pictureBox5_3.Size = new System.Drawing.Size(639, 350);
            this.pictureBox5_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5_3.TabIndex = 19;
            this.pictureBox5_3.TabStop = false;
            this.pictureBox5_3.Visible = false;
            // 
            // pictureBox6_2
            // 
            this.pictureBox6_2.Image = global::InterruptProject.Properties.Resources._6_2;
            this.pictureBox6_2.Location = new System.Drawing.Point(86, 12);
            this.pictureBox6_2.Name = "pictureBox6_2";
            this.pictureBox6_2.Size = new System.Drawing.Size(639, 350);
            this.pictureBox6_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6_2.TabIndex = 20;
            this.pictureBox6_2.TabStop = false;
            this.pictureBox6_2.Visible = false;
            // 
            // pictureBox6_3
            // 
            this.pictureBox6_3.Image = global::InterruptProject.Properties.Resources._6_3;
            this.pictureBox6_3.Location = new System.Drawing.Point(86, 12);
            this.pictureBox6_3.Name = "pictureBox6_3";
            this.pictureBox6_3.Size = new System.Drawing.Size(639, 350);
            this.pictureBox6_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6_3.TabIndex = 21;
            this.pictureBox6_3.TabStop = false;
            this.pictureBox6_3.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::InterruptProject.Properties.Resources._6_3;
            this.pictureBox10.Location = new System.Drawing.Point(86, 12);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(639, 350);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 22;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(165, 187);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(183, 25);
            this.progressBar1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(249, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "0";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(493, 266);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(67, 25);
            this.progressBar2.TabIndex = 25;
            this.progressBar2.Visible = false;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.rb2);
            this.panel1.Controls.Add(this.rb1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(294, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 168);
            this.panel1.TabIndex = 27;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(10, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Quiz. 1과 2중 더 큰 수는?";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(58, 103);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(29, 16);
            this.rb1.TabIndex = 29;
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(146, 103);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(29, 16);
            this.rb2.TabIndex = 30;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(89, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 29);
            this.button2.TabIndex = 31;
            this.button2.Text = "제출";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(107, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림체", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(38, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "제한시간 10초!";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(277, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 120);
            this.panel2.TabIndex = 28;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.Enter += new System.EventHandler(this.panel2_Enter);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(3, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "7에 맞추어 패널을 클릭하세요!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(119, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "0";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox6_3);
            this.Controls.Add(this.pictureBox6_2);
            this.Controls.Add(this.pictureBox5_3);
            this.Controls.Add(this.pictureBox5_2);
            this.Controls.Add(this.pictureBox2_3);
            this.Controls.Add(this.pictureBox2_2);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "2016136108_이찬규";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox2_2;
        private System.Windows.Forms.PictureBox pictureBox2_3;
        private System.Windows.Forms.PictureBox pictureBox5_2;
        private System.Windows.Forms.PictureBox pictureBox5_3;
        private System.Windows.Forms.PictureBox pictureBox6_2;
        private System.Windows.Forms.PictureBox pictureBox6_3;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

