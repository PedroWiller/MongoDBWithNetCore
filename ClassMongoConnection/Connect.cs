using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Linq.Expressions;

namespace ClassMongoConnection
{
    public class Connect
    {
        public void Execute()
        {
            var client = new MongoClient("mongodb://localhost");
            var dataBase = client.GetDatabase("dbname");
            var collection = dataBase.GetCollection<CollectionExemple>("collectionname");

            Expression<Func<CollectionExemple, bool>> filter = x => x._id.Equals(ObjectId.Parse("5b7a016b424dc5eb2cd769de"));
            var col = collection.Find(filter).FirstOrDefault();
        }
    }
}
