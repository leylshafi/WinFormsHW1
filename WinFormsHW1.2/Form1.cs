namespace WinFormsHW1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_MouseHover(object sender, EventArgs e)
        {
          
            int x = Random.Shared.Next(0, 600);
            int y = Random.Shared.Next(10, 370);
            label1.Location = new Point(x, y);

        }
    }
}