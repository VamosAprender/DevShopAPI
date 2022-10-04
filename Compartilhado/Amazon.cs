using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartilhado
{
    public static class Amazon
    {
        public static async Task SalvarAsync<T>(this T objeto)
        {
            var client = new AmazonDynamoDBClient(RegionEndpoint.USEast1);
            var context = new DynamoDBContext(client);
            await context.SaveAsync<T>(objeto);
        }
    }
}
