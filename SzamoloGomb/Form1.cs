namespace SzamoloGomb
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
                    SzámolóGomb g = new SzámolóGomb();
                    g.Top = i*20;
                    g.Left = j*20;

                    Controls.Add(g);
                    
                }
            }
        }
    }
}
