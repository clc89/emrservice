using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using EMRServiceModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace EMRService.DataAccess
{
    //This class will lookup relationship between api consumer and api key.
    class TenantDal
    {
        private MongoDatabase database;
        private MongoClient client;
        MongoCollection<Tenant> tenants;

        public TenantDal()
        {
            //MongoServerSettings settings = new MongoServerSettings();
            //settings.Server = new MongoServerAddress("localhost", 27017);
            //MongoServer server = new MongoServer(settings);

            client = new MongoClient(ConfigurationManager.ConnectionStrings["default"].ToString());
            MongoServer server = client.GetServer();
            database = server.GetDatabase("db");

            tenants = database.GetCollection<Tenant>("tenant");
        }

        public Tenant getTenantByKey(string key)
        {
            var query = Query.EQ("guid", key);
            Tenant t = tenants.FindOneAs<Tenant>(query);
            return t;
        }

        public void insertTenantData(Tenant t)
        {
            tenants.Save<Tenant>(t);
        }
    }
}
