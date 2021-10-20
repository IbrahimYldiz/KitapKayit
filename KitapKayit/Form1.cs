using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KitapKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KitapDbcs dbclass = new KitapDbcs();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbclass.liste();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            Save save = new Save();
            if (TxtSaveBookName.Text.Trim() != "" && TxtSaveWriterName.Text.Trim() != "" && TxtSaveYears.Text != "")
            {
                kitap.Ad = TxtSaveBookName.Text;
                kitap.Tarih = TxtSaveYears.Text;
                kitap.Yazar = TxtSaveWriterName.Text;

                save.Ksave(kitap);
                MessageBox.Show("Kayıt Edildi");
                
            }
            else
            {
                MessageBox.Show("Lütfen Bütün Değerleri Giriniz");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbclass.liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TxtUpdateYears.Text != "" && TxtUpdateBookName.Text != "" && TxtUpdateWriterName.Text != "" && TxtDeleteID.Text != "")
            {
                Kitap kitap = new Kitap();
                DbUpdate update = new DbUpdate();
                kitap.Id = Convert.ToInt32(TxtDeleteID.Text);
                kitap.Ad = TxtUpdateBookName.Text;
                kitap.Tarih = TxtUpdateYears.Text;
                kitap.Yazar = TxtUpdateWriterName.Text;
                

                update.KUpdate(kitap);
                MessageBox.Show("Kitap Güncellendi");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TxtDeleteID.Text != "")
            {
                Kitap kitap = new Kitap();
                DbDelete dele = new DbDelete();

                kitap.Id = Convert.ToInt32(TxtDeleteID.Text);

                dele.Kdelete(kitap);
                MessageBox.Show("Kitap Silindi");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtDeleteID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtUpdateBookName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtUpdateYears.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtUpdateWriterName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
