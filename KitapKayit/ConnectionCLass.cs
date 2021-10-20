using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace KitapKayit
{
    class ConnectionCLass
    {
        
           public OleDbConnection oleconnection()
        {
            OleDbConnection connection1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\fenny\Desktop\Kitaplik.accdb");
            connection1.Open();
            return connection1;
        }
        
    }
}
