using System.Windows.Forms;

namespace Kamatszamitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            decimal hitel�sszeg = decimal.Parse(tbHitel�sszege.Text);
            decimal haviKamat = decimal.Parse(tbHaviKamat.Text);
            decimal haviT�rleszt� = decimal.Parse(cbHaviT�rleszt�.Text);

            decimal h�tral�k = hitel�sszeg;
            decimal befizet�s = 0;

            List<Sor> sorok = new List<Sor>();

            int h�nap = 1;
            while (h�tral�k > 0)
            {
                h�tral�k += haviKamat * (h�tral�k / 100m);
                h�tral�k -= haviT�rleszt�;
                befizet�s += haviT�rleszt�;
                h�nap++;

                Sor �jSor = new Sor();
                �jSor.H�tral�k = Math.Round(h�tral�k);
                �jSor.H�nap = h�nap;

                sorok.Add(�jSor);
            }

            dataGridView1.DataSource = sorok;
        }
    }
}
