namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button uj = new Button();
            uj.Width = 100;
            uj.Height = 50;

            uj.Left = ClientRectangle.Width / 2 -50;
            uj.Top = ClientRectangle.Height / 2 - 25;

            Controls.Add(uj);
        }
    }
}