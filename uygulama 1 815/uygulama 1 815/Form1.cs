﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_1_815
{
    public partial class Form1 : Form
    {
        ArrayList sehirler = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sehirler.Add(txtSehirAdi.Text);
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sehirler.Count; i++)
            {
                lbListe.Items.Add(sehirler[i]);
            }
        }
    }
}
