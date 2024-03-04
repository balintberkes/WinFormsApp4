using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamoloGomb
{
    internal class SzámolóGomb : Button
    {
        int szám = 1;
        public SzámolóGomb()
        {
            Height = 20;
            Width = 20;
            Click += SzámolóGomb_Click;
            Text = szám.ToString();
        }

        private void SzámolóGomb_Click(object? sender, EventArgs e)
        {
            if (szám != 5)
            {
                szám++;
                Text = szám.ToString();
            }
            else
            {
                szám = 1;
                Text = szám.ToString();
            }
        }
    }
}
