using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;
using System.Data;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;



namespace Data
{
    public class ContactRepository : IContactRepository
    {
        private System.Data.IDbConnection db;



        public ContactRepository(string connString)
        {
            this.db = new SqlConnection(connString);
        }


        public Train Add(Train train)
        {
            this.db.Insert(train);
            return train;
        }
    }
}
