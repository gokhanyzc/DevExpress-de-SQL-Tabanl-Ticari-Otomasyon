﻿namespace Ticari_Otomasyon
{
    partial class FrmGiderler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtMaas = new DevExpress.XtraEditors.TextEdit();
            this.TxtSu = new DevExpress.XtraEditors.TextEdit();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.TxtEkstra = new DevExpress.XtraEditors.TextEdit();
            this.CmbYil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CmbAy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RchNotlar = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDogalgaz = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Txtinternet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtElektrik = new DevExpress.XtraEditors.TextEdit();
            this.labelcontrol2 = new DevExpress.XtraEditors.LabelControl();
            this.Txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEkstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbYil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbAy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDogalgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtinternet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtElektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1095, 561);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtMaas);
            this.groupControl1.Controls.Add(this.TxtSu);
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.TxtEkstra);
            this.groupControl1.Controls.Add(this.CmbYil);
            this.groupControl1.Controls.Add(this.CmbAy);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.RchNotlar);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.TxtDogalgaz);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.Txtinternet);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtElektrik);
            this.groupControl1.Controls.Add(this.labelcontrol2);
            this.groupControl1.Controls.Add(this.Txtid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1101, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(270, 561);
            this.groupControl1.TabIndex = 6;
            // 
            // TxtMaas
            // 
            this.TxtMaas.Location = new System.Drawing.Point(84, 235);
            this.TxtMaas.Name = "TxtMaas";
            this.TxtMaas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtMaas.Properties.Appearance.Options.UseFont = true;
            this.TxtMaas.Size = new System.Drawing.Size(151, 24);
            this.TxtMaas.TabIndex = 8;
            // 
            // TxtSu
            // 
            this.TxtSu.Location = new System.Drawing.Point(85, 145);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtSu.Properties.Appearance.Options.UseFont = true;
            this.TxtSu.Size = new System.Drawing.Size(151, 24);
            this.TxtSu.TabIndex = 5;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(84, 499);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(151, 28);
            this.BtnTemizle.TabIndex = 30;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(32, 271);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(45, 18);
            this.labelControl11.TabIndex = 29;
            this.labelControl11.Text = "Ekstra:";
            // 
            // TxtEkstra
            // 
            this.TxtEkstra.Location = new System.Drawing.Point(83, 265);
            this.TxtEkstra.Name = "TxtEkstra";
            this.TxtEkstra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtEkstra.Properties.Appearance.Options.UseFont = true;
            this.TxtEkstra.Size = new System.Drawing.Size(151, 24);
            this.TxtEkstra.TabIndex = 9;
            // 
            // CmbYil
            // 
            this.CmbYil.Location = new System.Drawing.Point(85, 86);
            this.CmbYil.Name = "CmbYil";
            this.CmbYil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbYil.Properties.Appearance.Options.UseFont = true;
            this.CmbYil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbYil.Properties.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019"});
            this.CmbYil.Size = new System.Drawing.Size(150, 24);
            this.CmbYil.TabIndex = 3;
            // 
            // CmbAy
            // 
            this.CmbAy.Location = new System.Drawing.Point(84, 56);
            this.CmbAy.Name = "CmbAy";
            this.CmbAy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbAy.Properties.Appearance.Options.UseFont = true;
            this.CmbAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbAy.Properties.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.CmbAy.Size = new System.Drawing.Size(150, 24);
            this.CmbAy.TabIndex = 1;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(32, 295);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(43, 18);
            this.labelControl10.TabIndex = 23;
            this.labelControl10.Text = "Notlar:";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(84, 465);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(151, 28);
            this.BtnGuncelle.TabIndex = 21;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(83, 431);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(151, 28);
            this.BtnSil.TabIndex = 20;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(82, 397);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(151, 28);
            this.BtnKaydet.TabIndex = 19;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RchNotlar
            // 
            this.RchNotlar.Location = new System.Drawing.Point(81, 295);
            this.RchNotlar.Name = "RchNotlar";
            this.RchNotlar.Size = new System.Drawing.Size(151, 96);
            this.RchNotlar.TabIndex = 10;
            this.RchNotlar.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(54, 147);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(21, 18);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Su:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(23, 238);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 18);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Maaşlar:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(18, 211);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(58, 18);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "İnternet:";
            // 
            // TxtDogalgaz
            // 
            this.TxtDogalgaz.Location = new System.Drawing.Point(83, 175);
            this.TxtDogalgaz.Name = "TxtDogalgaz";
            this.TxtDogalgaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtDogalgaz.Properties.Appearance.Options.UseFont = true;
            this.TxtDogalgaz.Size = new System.Drawing.Size(151, 24);
            this.TxtDogalgaz.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 181);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Doğalgaz:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(27, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Elektrik:";
            // 
            // Txtinternet
            // 
            this.Txtinternet.Location = new System.Drawing.Point(84, 208);
            this.Txtinternet.Name = "Txtinternet";
            this.Txtinternet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Txtinternet.Properties.Appearance.Options.UseFont = true;
            this.Txtinternet.Size = new System.Drawing.Size(151, 24);
            this.Txtinternet.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(56, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(19, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Yıl:";
            // 
            // TxtElektrik
            // 
            this.TxtElektrik.Location = new System.Drawing.Point(85, 116);
            this.TxtElektrik.Name = "TxtElektrik";
            this.TxtElektrik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtElektrik.Properties.Appearance.Options.UseFont = true;
            this.TxtElektrik.Size = new System.Drawing.Size(151, 24);
            this.TxtElektrik.TabIndex = 4;
            // 
            // labelcontrol2
            // 
            this.labelcontrol2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelcontrol2.Appearance.Options.UseFont = true;
            this.labelcontrol2.Location = new System.Drawing.Point(54, 59);
            this.labelcontrol2.Name = "labelcontrol2";
            this.labelcontrol2.Size = new System.Drawing.Size(22, 18);
            this.labelcontrol2.TabIndex = 3;
            this.labelcontrol2.Text = "Ay:";
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(83, 23);
            this.Txtid.Name = "Txtid";
            this.Txtid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Txtid.Properties.Appearance.Options.UseFont = true;
            this.Txtid.Size = new System.Drawing.Size(151, 24);
            this.Txtid.TabIndex = 120;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(56, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // FrmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 561);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmGiderler";
            this.Text = "GİDERLER";
            this.Load += new System.EventHandler(this.FrmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEkstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbYil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbAy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDogalgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtinternet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtElektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit TxtEkstra;
        private DevExpress.XtraEditors.ComboBoxEdit CmbYil;
        private DevExpress.XtraEditors.ComboBoxEdit CmbAy;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox RchNotlar;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtDogalgaz;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit Txtinternet;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtElektrik;
        private DevExpress.XtraEditors.LabelControl labelcontrol2;
        private DevExpress.XtraEditors.TextEdit Txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtSu;
        private DevExpress.XtraEditors.TextEdit TxtMaas;
    }
}