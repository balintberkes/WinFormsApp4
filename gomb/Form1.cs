namespace gomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int s = 0; s < 10; s++)
            {
                for (int o = 0; o < 10; o++)
                {
                    Button button = new Button();
                    button.Height = 20;
                    button.Width = 20;
                    button.Left = o * 20;
                    button.Top = s * 20;

                    Controls.Add(button);
                }
            }


        }
    }
}
