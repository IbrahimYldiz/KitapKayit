using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace KitapKayit
{
    class DbDelete
    {
        
        ConnectionCLass connection2 = new ConnectionCLass();
        public void Kdelete(Kitap kt)
        {

            OleDbCommand command = new OleDbCommand("delete from Kitaplar where ID=@p4", connection2.oleconnection());
            
            command.Parameters.AddWithValue("@p4", kt.Id);
            command.ExecuteNonQuery();



            connection2.oleconnection().Close();
        }
    }
}
