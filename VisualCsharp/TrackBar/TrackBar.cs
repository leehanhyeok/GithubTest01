namespace ProgressBarApp01
{
    public partial class Form1 : Form
    {
        private int progressValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = 100;
            //progressBar1.Value = 0;
            ProgressLabel.Text = "진행도 : 0%";
            //timer1.Interval = 100;
        }

        private void ProgressLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //progressValue = 0;
            //progressBar1.Value = 0;
            //progressLabel.Text = "진행도 : 0%";
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressValue += 1;

            if (progressValue <= 100)
            {
                progressBar1.Value = progressValue;
                ProgressLabel.Text = $"진행도 : {progressValue}%";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("진행완료");
            }
        }
    }
}
