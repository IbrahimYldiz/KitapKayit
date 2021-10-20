using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace KitapKayit
{
    
    class KitapDbcs
    {
        

        public List<Kitap> liste()
        {
            ConnectionCLass connection2 = new ConnectionCLass();

            
            List < Kitap > ktp= new List<Kitap>();

            
            OleDbCommand olecommand = new OleDbCommand("select ID as 'Kayıt Numarası',KitapAd as 'Kitap Adı',Cikistarihi as 'Çıkış Tarihi',Yazar as 'Yazarın Adı' from Kitaplar", connection2.oleconnection());
            OleDbDataReader dr = olecommand.ExecuteReader();
            while (dr.Read())
            {
                Kitap k = new Kitap();
                k.Id = Convert.ToInt32(dr[0].ToString());
                k.Ad = dr[1].ToString();
                k.Tarih = dr[2].ToString();
                k.Yazar = dr[3].ToString();

                ktp.Add(k);
            }
            connection2.oleconnection().Close();
            return ktp;
        }
        
    }
}
