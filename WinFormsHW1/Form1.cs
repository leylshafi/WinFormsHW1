namespace WinFormsHW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point start, end;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            start.X = e.X;
            start.Y = e.Y;
        }

        

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            end.X = e.X;
            end.Y = e.Y;

            if (Math.Abs(start.X - end.X) < 10 || Math.Abs(start.Y - end.Y) < 10)
                MessageBox.Show("Minimal Requied size is 10x10", "Warning");
            else
            {
                Label label = new Label()
                {
                    Size = new Size(Math.Abs(start.X - end.X), Math.Abs(start.Y - end.Y)),
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                var point = new Point(start.X < end.X ? start.X : end.X, start.Y < end.Y ? start.Y : end.Y);

                label.Location = point;

                if (Controls.Count != 0)
                    label.Text = (int.Parse(Controls[Controls.Count - 1].Text) + 1).ToString();
                else
                    label.Text = 1.ToString();

                label.Click += (s, e) => (s as Label)?.Dispose();

                Controls.Add(label);
            }
        }
    }
}