using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace InterruptProject
{
    public partial class Form1 : Form
    {
        int num = 0;
        int interrupt_num = 0;
        int interrupt_value = 0;
        int check = 0;
        bool correct = false;
        public Form1()
        {
            InitializeComponent();
        }
        private static DateTime Delay(int MS)                               // Delay함수 정의
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            num++;

            label1.Text = num.ToString();
            if (num == 100)
                num = 0;

            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
                progressBar1.Value = 0;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
      
        }
        private void interrupt1_start()                                 // Interrupt1은 progressBar 게이지를 0으로 만드는
        {                                                                              // 인터럽트 입니다.
            progressBar1.Visible = true;
            label1.Visible = true;

            for (int i = interrupt_num; i > 0; i--)
            {
                interrupt_num--;
                label1.Text = interrupt_num.ToString();
                progressBar1.Increment(-1);
                Delay(100);
            }

            check = 1;
        }
        private void interrupt2_start()                                  // Interrupt2는 돌발퀴즈 문제를 준비했습니다.
        {
            int count = 10;
            panel1.Visible = true;
            for (int i = count; i >= 0; i--)
            {
                label3.Text = count.ToString();
                count--;
                Delay(1000);
                if (panel1.Visible == false)
                {
                    check = 1;
                    return;
                }
            }
            MessageBox.Show("시간이 다 되었습니다.");
            check = 1;
            panel1.Visible = false;
            return;
        }
        private void interrupt3_start()                                     // Interrupt3는 숫자 맞추기 게임입니다.
        {
            int count = 7;
            int user = 0;
            panel2.Visible = true;
            for (int i = 0; i < 100; i++)
            {
                label6.Text = i.ToString();
                if(interrupt_value == 1){
                    user = i;
                    if (user == count)
                    {
                        MessageBox.Show("맞았습니다!");
                        check = 1;
                        user = 0;
                        panel2.Visible = false;
                        interrupt_value = 0;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("틀렸습니다!");
                        check = 1;
                        user = 0;
                        panel2.Visible = false;
                        interrupt_value = 0;
                        return;
                    }
                }
                Delay(1000);
            }
            return;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            interrupt_num = num;
            interrupt_value = progressBar1.Value;   

            button1.Text = "Interrupt 진행중";
            button1.Enabled = false;

            pictureBox2.Visible = true;                                         // Interrupt 발생
            pictureBox1.Visible = false;
            Delay(1500);

            pictureBox3.Visible = true;                                         // 문맥 저장
            pictureBox2.Visible = false;
            progressBar2.Visible = true;
            progressBar2.Value = progressBar1.Value;
            progressBar1.Visible = false;
            label1.Visible = false;
            Delay(1500);

            
           
            progressBar1.Visible = false;
            label1.Visible = false;

            pictureBox4.Visible = true;                                         // 인터럽트 처리                                   
            pictureBox3.Visible = false;
            Delay(1500);

            pictureBox5.Visible = true;                                         // ISR-1 이동                                   
            pictureBox4.Visible = false;
            Delay(1500);

            pictureBox6.Visible = true;                                         // ISR-1 호출                                  
            pictureBox5.Visible = false;
            Delay(1500);

            interrupt1_start();                                                      // Interrupt1 시작
            Delay(1500);
            if (check == 1)
            {
                pictureBox7.Visible = true;                                         // Interrupt 처리완료                                       
                pictureBox6.Visible = false;
                progressBar1.Visible = false;
                label1.Visible = false;
                progressBar1.Value = interrupt_value;
                label1.Text = num.ToString();
                Delay(1500);

                pictureBox8.Visible = true;                                         //  문맥 교환                                  
                pictureBox7.Visible = false;
                progressBar1.Visible = true;
                label1.Visible = true;
                Delay(1500);

                pictureBox9.Visible = true;                                         // 중단된 시점부터 다시 실행                                        
                pictureBox8.Visible = false;
                progressBar2.Visible = false;
                progressBar2.Value = 0;
                Delay(1500);

                pictureBox9.Visible = false;
                pictureBox1.Visible = true;

                button1.Text = "Interrupt1";
                button1.Enabled = true;

                check = 0;
                timer1.Start();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            check = 0;
            if (e.KeyCode == Keys.A)
            {
                timer1.Stop();
                button1.Text = "Interrupt 진행중";
                button1.Enabled = false;

                pictureBox2_2.Visible = true;                                         // Interrupt 발생
                pictureBox1.Visible = false;
                Delay(1500);

                pictureBox3.Visible = true;                                         // 문맥 저장
                pictureBox2_2.Visible = false;
                progressBar2.Visible = true;
                progressBar2.Value = progressBar1.Value;
                progressBar1.Visible = false;
                label1.Visible = false;
                Delay(1500);

                pictureBox4.Visible = true;                                         // 인터럽트 처리                                   
                pictureBox3.Visible = false;
                Delay(1500);

                pictureBox5_2.Visible = true;                                         // ISR-2 이동                                   
                pictureBox4.Visible = false;
                Delay(1500);

                pictureBox6_2.Visible = true;                                         // ISR-2 호출                                  
                pictureBox5_2.Visible = false;
                Delay(1500);

                interrupt2_start();                                                         // Interrupt2 시작

                if (check == 1)
                {
                    Delay(1500);
                    pictureBox7.Visible = true;                                         // Interrupt 처리완료                                       
                    pictureBox6_2.Visible = false;
                    Delay(1500);

                    pictureBox8.Visible = true;                                         // 문맥 교환                                  
                    pictureBox7.Visible = false;
                    progressBar1.Visible = true;
                    label1.Visible = true;
                    Delay(1500);

                    pictureBox9.Visible = true;                                         // 중단된 시점부터 다시 실행                                        
                    pictureBox8.Visible = false;
                    progressBar2.Visible = false;
                    progressBar2.Value = 0;
                    Delay(1500);

                    pictureBox9.Visible = false;
                    pictureBox1.Visible = true;

                    button1.Text = "Interrupt1";
                    button1.Enabled = true;

                    check = 0;
                    timer1.Start();
                }
            }
            else if (e.KeyCode == Keys.B)
            {
                timer1.Stop();

                button1.Text = "Interrupt 진행중";
                button1.Enabled = false;

                pictureBox2_3.Visible = true;                                         // Interrupt 발생
                pictureBox1.Visible = false;
                Delay(1500);

                pictureBox3.Visible = true;                                         // 문맥 저장
                pictureBox2_3.Visible = false;
                progressBar2.Visible = true;
                progressBar2.Value = progressBar1.Value;
                progressBar1.Visible = false;
                label1.Visible = false;
                Delay(1500);

                pictureBox4.Visible = true;                                         // 인터럽트 처리                                   
                pictureBox3.Visible = false;
                Delay(1500);

                pictureBox5_3.Visible = true;                                         // ISR-3 이동                                   
                pictureBox4.Visible = false;
                Delay(1500);

                pictureBox6_3.Visible = true;                                         // ISR-3 호출                                  
                pictureBox5_3.Visible = false;
                Delay(1500);

                interrupt3_start();

                if (check == 1)
                {
                    pictureBox7.Visible = true;                                         // Interrupt 처리완료                                       
                    pictureBox6_3.Visible = false;
                    Delay(1500);

                    pictureBox8.Visible = true;                                         // 문맥 교환                                  
                    pictureBox7.Visible = false;
                    progressBar1.Visible = true;
                    label1.Visible = true;
                    Delay(1500);

                    pictureBox9.Visible = true;                                         // 중단된 시점부터 다시 실행                                        
                    pictureBox8.Visible = false;
                    progressBar2.Visible = false;
                    progressBar2.Value = 0;
                    Delay(1500);

                    pictureBox9.Visible = false;
                    pictureBox1.Visible = true;

                    button1.Text = "Interrupt1";
                    button1.Enabled = true;

                    check = 0;
                    timer1.Start();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            correct = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            correct = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!correct)
                MessageBox.Show("안타깝지만, 틀렸습니다.");
            else
                MessageBox.Show("정답입니다 !");

            panel1.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Enter(object sender, EventArgs e)
        {
            
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                interrupt_value = 1;
            }
        }
    }
}