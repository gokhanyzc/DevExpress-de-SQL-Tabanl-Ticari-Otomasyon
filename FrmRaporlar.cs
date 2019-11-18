﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DboTicariOtomasyonDataSet7.TBL_PERSONELLER' table. You can move, or remove it, as needed.
            this.TBL_PERSONELLERTableAdapter.Fill(this.DboTicariOtomasyonDataSet7.TBL_PERSONELLER);
            // TODO: This line of code loads data into the 'DboTicariOtomasyonDataSet6.TBL_GIDERLER' table. You can move, or remove it, as needed.
            this.TBL_GIDERLERTableAdapter.Fill(this.DboTicariOtomasyonDataSet6.TBL_GIDERLER);
            // TODO: This line of code loads data into the 'DboTicariOtomasyonDataSet5.TBL_FIRMALAR' table. You can move, or remove it, as needed.
            this.TBL_FIRMALARTableAdapter.Fill(this.DboTicariOtomasyonDataSet5.TBL_FIRMALAR);
            // TODO: This line of code loads data into the 'DboTicariOtomasyonDataSet4.TBL_MUSTERILER' table. You can move, or remove it, as needed.
            this.TBL_MUSTERILERTableAdapter.Fill(this.DboTicariOtomasyonDataSet4.TBL_MUSTERILER);


            this.reportViewer1.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer5.RefreshReport();
        }
    }
}
