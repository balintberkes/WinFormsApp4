using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futoverseny
{

    public partial class FormEdit : Form
    {
        public ClassVersenyzok UjVersenyzo = new ClassVersenyzok();
        public FormEdit()
        {
            InitializeComponent();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = UjVersenyzo;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
