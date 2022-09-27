using WinFormsHW1._3.Properties;

namespace WinFormsHW1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool state = false;
        private void Baku_MouseClick_1(object sender, MouseEventArgs e)
        {
            state = true;
            BackgroundImage = Resources._118f2684022887_5d4ea01c02748;
           
        }

        private void London_MouseClick(object sender, MouseEventArgs e)
        {
            state = false;
            BackgroundImage = Resources.London;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new();
            timer.Start();
            timer.Interval = 1000;
            timer.Tick += (s, e) => Time.Text = state ? DateTime.Now.ToLongTimeString() : DateTime.UtcNow.ToLongTimeString();
        }

        
    }
}