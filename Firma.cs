﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projee
{
    public partial class Firma : Form
    {
        public Firma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Koltuksecme ksec = new Koltuksecme();
            ksec.Show();
            this.Hide();
        }
    }
}
