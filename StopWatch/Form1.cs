namespace StropWatch
{
    public partial class Form1 : Form
    {
        int time = 20 * 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;

                int minutos = 0;
                int segundos = 0;

                minutos = time / 60;
                segundos = time % 60;

                label_counter.Text = String.Format("{0,2:D2}:{1,2:D2}", minutos, segundos);

                if(time < 10)
                {
                    if((time % 2) <= 0)
                    {
                        label_counter.BackColor = Color.Black;
                        label_counter.ForeColor = Color.Red;
                    }
                    else
                    {
                        label_counter.BackColor = Color.Red;
                        label_counter.ForeColor = Color.Black;
                    }
                }
            }
            else
            {
                label_counter.Text = "YOU LOSE.";
                label_counter.Location = new Point(300, label_counter.Location.Y );
                timer1.Enabled = false;
                textBox_pswd.Visible = false;
                button_ok.Visible = false;
            }


        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button_start.Visible = false;
            button_ok.Visible = true;
            textBox_pswd.Visible = true;

        }

        private void textBox_pswd_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_pswd.Text = "";
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if((string.Compare(textBox_pswd.Text, "472120360") == 0) && (time > 0))
            {
                pictureBox_hint.Visible = true;
                pictureBox_hint.BringToFront();
                timer1.Enabled = false;
            }
            else
            {
                textBox_pswd.Text = "ERROR";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}