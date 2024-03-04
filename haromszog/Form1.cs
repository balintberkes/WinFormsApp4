namespace haromszog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button g = new Button();
                    g.Text = (i*j).ToString();
                    g.Height = 40;
                    g.Width = 40;
                    g.Top = i * 40;
                    g.Left = j * 40;

                    if (i < j)
                    {
                        g.Visible = false;
                    }

                    Controls.Add(g);
                }
            }
            

        }
    }
}
