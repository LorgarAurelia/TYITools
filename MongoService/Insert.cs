using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYITools.Models.Units.Tanks;

namespace TYITools.MongoService
{
    public static class Insert
    {
        public static async Task SaveTankDocsAsync(TankUnit data)
        {
            MongoConnection connection = new();

            IMongoDatabase database = connection.DBClient.GetDatabase("TYTest");
            IMongoCollection<TankUnit> collection = database.GetCollection<TankUnit>("USA_vehicle");

            await collection.InsertOneAsync(data);
        }
    }
}
