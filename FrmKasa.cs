﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //required for sqllibrary.
using DevExpress.Charts; //required for chart control.

namespace Ticari_Otomasyon
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void musterihareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute MusteriHareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void firmahareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute FirmaHareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }
        void giderler()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_GIDERLER ORDER BY ID ASC", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        public string ad;


        private void FrmKasa_Load(object sender, EventArgs e)
        {
            LblAktifKullanici.Text = ad;
            musterihareket();
            firmahareket();
            giderler();

            //Toplam Tutarı Hesaplama
            SqlCommand cmd = new SqlCommand("Select Sum(Tutar) From TBL_FATURADETAY", bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblKasaToplam.Text = dr[0].ToString() + " TL ";
            }
            bgl.baglanti().Close();

            //Son Ayın Faturaları
            SqlCommand cmd2 = new SqlCommand("Select (ELEKTRIK + SU + DOGALGAZ + INTERNET+EKSTRA)  From TBL_GIDERLER order by ID ASC", bgl.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while(dr2.Read())
            {
                LblOdemeler.Text = dr2[0].ToString() + " TL ";
            }
            bgl.baglanti().Close();

            //Son Ayın Personel Maaşları.
            SqlCommand cmd3 = new SqlCommand("Select MAASLAR From TBL_GIDERLER order by ID ASC ", bgl.baglanti());
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while(dr3.Read())
            {
                LblPersonelMaas.Text = dr3[0].ToString() + " TL ";
            }
            bgl.baglanti().Close();

            //Toplam Müşteri Sayısı

            SqlCommand cmd4 = new SqlCommand("Select Count(*) From TBL_MUSTERILER", bgl.baglanti());    
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while(dr4.Read())
            {
                LblMusteriSayisi.Text = dr4[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Firma Sayısı
            SqlCommand cmd5 = new SqlCommand("Select Count(*) From TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
              LblFirmaSayisi.Text = dr5[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Firma Şehir Sayıso
            SqlCommand cmd6 = new SqlCommand("Select Count(Distinct(IL)) From TBL_FIRMALAR", bgl.baglanti()); //Distinct tekrarsız olarak saymaya yarar.
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while(dr6.Read())
            {
                LblSehirSayisi.Text = dr6[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Müşteri Şehir Sayısı
            SqlCommand cmd7 = new SqlCommand("Select Count(Distinct(IL)) From TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr7 = cmd7.ExecuteReader();
            while (dr7.Read())
            {
                LblSehirSayisi2.Text = dr7[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Personel Sayısı
            SqlCommand cmd8 = new SqlCommand("Select Count(*) From TBL_PERSONELLER", bgl.baglanti());
            SqlDataReader dr8 = cmd8.ExecuteReader();
            while(dr8.Read())
            {
                LblPersonelSayisi.Text = dr8[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Ürün Sayısı
            SqlCommand cmd9 = new SqlCommand("Select Sum(ADET) From TBL_URUNLER", bgl.baglanti());
            SqlDataReader dr9 = cmd9.ExecuteReader();
            while (dr9.Read())
            {
             LblStokSayisi.Text = dr9[0].ToString();
            }
            bgl.baglanti().Close();

            

        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if(sayac>0 && sayac <=5)
            {
                //1.CHART KONTROLE ELEKTRIK FATURASI SON 4 AY LİSTELENMESİ.
                groupControl10.Text = "Elektrik";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd10 = new SqlCommand("Select top 4 AY,ELEKTRIK From TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr10 = cmd10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));  //yeni bir konum alanı tanımladıgımızı düşünebiliriz.
                }
                bgl.baglanti().Close();

                
            }
            if(sayac>5 && sayac<=10)
            {

                //1.CHART KONTROLE SU FATURASI SON 4 AY LİSTELENMESİ.
                groupControl10.Text = "Su";
                chartControl1.Series["Aylar"].Points.Clear(); //buraya geçmeden önce chartcontrol1'i temizlesin.
                SqlCommand cmd11 = new SqlCommand("Select top 4 AY,SU From TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = cmd11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            if(sayac>10 && sayac<=15)
            {
                //1.CHART KONTRELE DOGALGAZ FATURASI SON 4 AY LİSTELENMESİ
                groupControl10.Text = "Doğalgaz";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd12 = new SqlCommand("Select top 4 AY,DOGALGAZ From TBL_GIDERLER ORDER BY ID DESC",bgl.baglanti());
                SqlDataReader dr12 = cmd12.ExecuteReader();
                while(dr12.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));
                }
                bgl.baglanti().Close();
            }
            if(sayac>15 && sayac<=20)
            {
                //1.CHART KONTRELE İNTERNET FATURASI SON 4 AY LİSTELENMESİ
                groupControl10.Text = "İnternet";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd13 = new SqlCommand("Select top 4 AY,INTERNET From TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr13= cmd13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgl.baglanti().Close();
            }
            if(sayac>20 && sayac<=25)
            {
                //1.CHART KONTROLE EKSTRA SON 4 AY LİSTELENMESİ.
                groupControl10.Text = "Ekstra";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd14 = new SqlCommand("Select top 4 AY,EKSTRA From TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr14 = cmd14.ExecuteReader();
                while (dr14.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr14[0], dr14[1]));
                }
                bgl.baglanti().Close();
            }
            if(sayac==26)
            {
                sayac = 0;

            }
        }
        int sayac2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 > 0 && sayac2 <= 5)
            {
                //2.CHART KONTROLE ELEKTRIK FATURASI SON 4 AY LİSTELENMESİ.
                groupControl11.Text = "Elektrik";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand cmd10 = new SqlCommand("Select top 4 AY,ELEKTRIK From TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr10 = cmd10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));  //yeni bir konum alanı tanımladıgımızı düşünebiliriz.
                }
                bgl.baglanti().Close();


            }
            if (sayac2 > 5 && sayac2 <= 10)
            {

                //2.CHART KONTROLE SU FATURASI SON4 AY LİSTELENMESİ.
                groupControl11.Text = "Su";
                chartControl2.Series["Aylar"].Points.Clear(); //buraya geçmeden önce chartcontrol1'i temizlesin.
                SqlCommand cmd11 = new SqlCommand("Select top 4 AY,SU From TBL_GIDERLER ORDER BY ID desc", bgl.baglanti());
                SqlDataReader dr11 = cmd11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2 > 10 && sayac2 <= 15)
            {
                //2.CHART KONTRELE DOGALGAZ FATURASI SON 4 AY LİSTELENMESİ
                groupControl11.Text = "Doğalgaz";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand cmd12 = new SqlCommand("Select top 4 AY,DOGALGAZ From TBL_GIDERLER ORDER BY ID desc", bgl.baglanti());
                SqlDataReader dr12 = cmd12.ExecuteReader();
                while (dr12.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2 > 15 && sayac2 <= 20)
            {
                //2.CHART KONTRELE İNTERNET FATURASI SON 4 AY LİSTELENMESİ
                groupControl11.Text = "İnternet";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand cmd13 = new SqlCommand("Select top 4 AY,INTERNET From TBL_GIDERLER ORDER BY ID desc", bgl.baglanti());
                SqlDataReader dr13 = cmd13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac > 20 && sayac <= 25)
            {
                //2.CHART KONTROLE EKSTRA SON 4 AY LİSTELENMESİ.
                groupControl11.Text = "Ekstra";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand cmd14 = new SqlCommand("Select top 4 AY,EKSTRA From TBL_GIDERLER ORDER BY ID desc", bgl.baglanti());
                SqlDataReader dr14 = cmd14.ExecuteReader();
                while (dr14.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr14[0], dr14[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2 == 26)
            {
                sayac2 = 0;

            }


        }
    }
}
