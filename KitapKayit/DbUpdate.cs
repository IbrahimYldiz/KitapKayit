using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace KitapKayit
{
    class DbUpdate
    {
        ConnectionCLass connection2 = new ConnectionCLass();
        public void KUpdate(Kitap kt)
        {

            OleDbCommand command = new OleDbCommand("update Kitaplar set KitapAd=@p1,Cikistarihi=@p2,Yazar=@p3 where ID=@p4", connection2.oleconnection());
            command.Parameters.AddWithValue("@p1", kt.Ad);
            command.Parameters.AddWithValue("@p2", kt.Tarih);
            command.Parameters.AddWithValue("@p3", kt.Yazar);
            command.Parameters.AddWithValue("@p4", kt.Id);
            command.ExecuteNonQuery();

            connection2.oleconnection().Close();
        }
        
    }
}
