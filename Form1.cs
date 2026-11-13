namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int t1Score = 0;
        int t2Score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1Score++;
            t1.Text = "Team 1: " + t1Score;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t2Score++;
            t2.Text = "Team 2: " + t2Score;
        }
    }
}
