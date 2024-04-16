using CsvHelper;
using System.ComponentModel;
using System.Diagnostics.PerformanceData;
using System.Globalization;

namespace futoverseny
{
    public partial class Form1 : Form
    {
        BindingList<ClassVersenyzok> listVersenyzok = new();
        public Form1()
        {
            InitializeComponent();
            classVersenyzokBindingSource.DataSource = listVersenyzok;
            dataGridView1.DataSource = classVersenyzokBindingSource;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futoverseny.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t�mb = csv.GetRecords<ClassVersenyzok>();
                foreach (var item in t�mb)
                {
                    listVersenyzok.Add(item);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Valami hiba t�rt�nt, val�sz�n�leg hib�s a forr�sf�jl!",
                                "Hiba",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(listVersenyzok);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hiba t�rt�nt, nincs kijel�lt sor!",
                                "Hiba",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (classVersenyzokBindingSource.Current == null) return;

                if (MessageBox.Show("Biztosan szeretn� t�r�lni a kijel�lt sort?",
                                    "Meger�s�t�s sz�gs�ges!",
                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    classVersenyzokBindingSource.RemoveCurrent();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNewItem_Click(object sender, EventArgs e)
        {
            FormAddItem formAddItem = new FormAddItem();

            if (formAddItem.ShowDialog() == DialogResult.OK)
            {
                listVersenyzok.Add(formAddItem.UjVersenyzo);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //if (classVersenyzokBindingSource == null) return;  
            
            FormEdit formEdit = new FormEdit();
            formEdit.UjVersenyzo = classVersenyzokBindingSource.Current as ClassVersenyzok;
            formEdit.Show();
        }
    }
}
