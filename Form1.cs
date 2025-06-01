using ELEKTRIK.ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELEKTRIK
{
    public partial class Form1 : Form
    {
        ELEKTRIKEntities et = new ELEKTRIKEntities();
        public Form1()
        {
            InitializeComponent();
        }

        int AboneNo;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTuketim.Enabled = false;
            btnTuketimKaydet.Enabled = false;   
            textBoxKapat();
            AboneDoldur();
            try
            {
                AboneNo = Convert.ToInt32(dgvAbone.Rows[0].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Tüketim Kaydı Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // TuketimDoldur(AboneNo);

            TuketimDoldurLinq(AboneNo);
        }

        private void textBoxKapat()
        {
            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            txtMarka.Enabled = false;
            txtTC.Enabled = false;
            txtSeri.Enabled = false;
            txtNumara.Enabled = false;
            btnKaydet.Enabled = false;
            btnYeni.Enabled = true;
        }

        private void textBoxAc()
        {
            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            txtMarka.Enabled = true;
            txtTC.Enabled = true;
            txtSeri.Enabled = true;
            txtNumara.Enabled = true;
            btnKaydet.Enabled = false;
            btnYeni.Enabled = false;
            txtAd.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            et.spAboneKaydet(txtAd.Text, txtSoyad.Text, txtTC.Text, txtMarka.Text, txtSeri.Text, txtNumara.Text);

            textBoxKapat();
            txtAd.Clear();
            txtSoyad.Clear();
            txtMarka.Clear();
            txtSeri.Clear();
            txtTC.Clear();
            txtNumara.Clear();
            MessageBox.Show("Kayıt Başarıyla Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AboneDoldur();
            try
            {
                AboneNo = Convert.ToInt32(dgvAbone.Rows[0].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Tüketim Kaydı Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TuketimDoldur(AboneNo);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            textBoxAc();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            if (txtAd.TextLength > 0 && txtSoyad.TextLength > 0 && txtMarka.TextLength > 0 && txtSeri.TextLength > 0 && txtNumara.TextLength > 0)
            {
                btnKaydet.Enabled = true;
            }
            else
            {
                btnKaydet.Enabled = false;
            }
        }

        private void btnTuketimYeni_Click(object sender, EventArgs e)
        {
            txtTuketim.Enabled = true;
            btnTuketimKaydet.Enabled = false;
            btnTuketimYeni.Enabled = false;
        }

        private void txtTuketim_TextChanged(object sender, EventArgs e)
        {
            if (txtTuketim.TextLength>0)
            {
                btnTuketimKaydet.Enabled = true;
            }
            else
            {
                btnTuketimKaydet.Enabled = false;
            }
        }

        private void btnTuketimKaydet_Click(object sender, EventArgs e)
        {
            et.spTuketimEkle(Convert.ToInt32(txtTuketim.Text.ToString()),AboneNo);
            txtTuketim.Enabled = false;
            btnTuketimKaydet.Enabled = false;
            btnTuketimYeni.Enabled = true;
            txtTuketim.Clear();
            MessageBox.Show("Tüketim Başarıyla Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TuketimDoldur(AboneNo);

        }

        private void AboneDoldur()
        {
            dgvAbone.DataSource = et.spAboneDoldur().ToList();
        }
        private void TuketimDoldur(int AboneNo)
        {
            dgvTuketim.DataSource = et.spTuketimDoldur(AboneNo).ToList();
        }

        private void TuketimDoldurLinq(int AboneNo)
        {
            var TuketimListe = from a in et.ABONE
                               join s in et.SAYAC on a.ABONEID equals s.ABONENO
                               join t in et.TUKETIM on s.SAYACID equals t.SAYACNO
                               where a.ABONEID == AboneNo orderby t.TARIH descending
                               select new
                               {
                                   s.SAYACID,
                                   s.MARKA,
                                   s.SERI,
                                   s.NUMARA,
                                   t.TARIH,
                                   t.ENDEKS,
                                   t.TUKETIM1
                               };
            dgvTuketim.DataSource = TuketimListe.ToList();
            dgvTuketim.Columns[0].HeaderText = "Sayaç No";
        }

        private void dgvAbone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AboneNo=Convert.ToInt32(dgvAbone.CurrentRow.Cells[0].Value.ToString());
            TuketimDoldur(AboneNo);
        }

        private void btnTuketimHesapla_Click(object sender, EventArgs e)
        {
            et.spTuketimHesapla();
            TuketimDoldur(AboneNo);
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.TextLength == 0)
            {
                AboneDoldur();
            }
            else
            {
                dgvAbone.DataSource = et.spAboneAra(txtAra.Text).ToList();
            }
               
        }
    }
}
