using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace KitapKayit
{
    class Save
    {
        
        ConnectionCLass connection2 = new ConnectionCLass();
        public void Ksave(Kitap kt)
        {
            
                OleDbCommand command = new OleDbCommand("insert into Kitaplar (KitapAd,Cikistarihi,Yazar) values (@p1,@p2,@p3)", connection2.oleconnection());
                command.Parameters.AddWithValue("@p1", kt.Ad);
                command.Parameters.AddWithValue("@p2", kt.Tarih);
                command.Parameters.AddWithValue("@p3", kt.Yazar);
                command.ExecuteNonQuery();


            
            connection2.oleconnection().Close();
        }
    }
}
