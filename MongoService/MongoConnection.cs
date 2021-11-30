using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYITools.MongoService
{
    public class MongoConnection
    {
        private readonly string connection;
        public MongoClient DBClient { get; set; }
        public MongoConnection()
        {
            connection = ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString;
            DBClient = new(connection);
        }
    }
}
