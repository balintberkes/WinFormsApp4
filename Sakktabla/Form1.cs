namespace Sakktabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Button g = new Button();
                    g.Left = i * 40;
                    g.Top = j * 40;
                    g.Width = 40;
                    g.Height = 40;
                    g.Text = (i * j).ToString();

                    if (i % 2 == 0 & j % 2 == 0)
                    {
                        g.Visible = true;
                       
                    }

                    else
                    {
                        if (i % 2 == 1 & j % 2 == 1)
                        {
                            g.Visible = true;
                        }
                        else
                        {
                            g.Visible = false;
                        }
                        
                    }

                    Controls.Add(g);
                }
            }
        }
    }
}
