using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Better
{
    public class DbContext
    {
        public string ConnectionString { get; set; }

        public IDbCommand CreateCommand(string sql)
        {
            return null;
        }

        public void ExecuteNonQuery(IDbCommand command)
        {
            //execute query
        }

        public IDataReader ExecuteReader(IDbCommand command)
        {
            return null;
        }
    }
}
