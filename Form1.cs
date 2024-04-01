using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int red, green = 5, yellow = 3;
        int time_total;


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            time_total = green + yellow;
            yr.Hide();
            yr_count.Hide();
            gr.Hide();
            gr_count.Hide();
            rl.Hide();
            rl_count.Hide();
            yl.Hide();
            yl_count.Hide();


            label14.Text = red.ToString();
            right.Show();
            left.Show();
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            time_total--;
            rr.Show();
            rr_count.Show();
            rr_count.Text = time_total.ToString();


            if (time_total > yellow)
            {
                gl.Show();
                gl_count.Show();
                gl_count.Text = time_total.ToString();
            }
            else if (time_total > 0)
            {
                gl.Hide();
                gl_count.Hide();

                yl.Show();
                yl_count.Text = time_total.ToString();
                yl_count.Show();
            }
            else
            {
                rr.Hide();
                rr_count.Hide();
                yl.Hide();
                yl_count.Hide();
                time_total = green + yellow;
                timer2.Enabled = true;
            };
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void button3_Click(object sender, EventArgs e)

        {
            timer1.Enabled = true;
            time_total = green + yellow;
                    yr.Hide();
                    yr_count.Hide();
                    gr.Hide();
                    gr_count.Hide();
                    rl.Hide();
                    rl_count.Hide();
                    yl.Hide();
                    yl_count.Hide();


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            time_total--;
            rl.Show();
            rl_count.Show();
            rl_count.Text = time_total.ToString();


            if (time_total > yellow)
            {
                gr.Show();
                gr_count.Show();
                gr_count.Text = time_total.ToString();
            }
            else if (time_total > 0)
            {
                gr.Hide();
                gr_count.Hide();

                yr.Show();
                yr_count.Text = time_total.ToString();
                yr_count.Show();
            }
            else
            {
                rl.Hide();
                rl_count.Hide();
                yr.Hide();
                yr_count.Hide();
                time_total = green + yellow;
                timer1.Enabled = true;

            };

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Int32.Parse(textBox1.Text) < 1)  || (Int32.Parse(textBox2.Text) < 1))
                {
                    MessageBox.Show("Interval cannot be set!");
                }
                else
                {
                    yr.Hide();
                    yr_count.Hide();
                    gr.Hide();
                    gr_count.Hide();
                    rl.Hide();
                    rl_count.Hide();
                    yl.Hide();
                    yl_count.Hide();

                    right.Show();
                    left.Show();

                    timer1.Interval = 1000;
                    timer2.Interval = 1000;
                    timer1.Enabled = true;

                    green = int.Parse(textBox1.Text);
                    yellow = int.Parse(textBox2.Text);
                    time_total = green + yellow;
                    red = green + yellow;
                    label14.Text = red.ToString();


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rr.Hide();
            yr.Hide();
            gr.Hide();
            rl.Hide();
            yl.Hide();
            gl.Hide();
            right.Hide();
            left.Hide();
            time_total = green + yellow;
            red = green + yellow;
        }
    }
}