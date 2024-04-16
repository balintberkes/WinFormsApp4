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
    public partial class FormAddItem : Form
    {
        public ClassVersenyzok UjVersenyzo = new ClassVersenyzok();
        public FormAddItem()
        {
            InitializeComponent();
        }

        private void FormAddItem_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = UjVersenyzo;
        }
    }
}
