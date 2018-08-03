using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.DocumentModel;
using System.IO;
using Amazon.DynamoDBv2.DataModel;

using Xunit;


namespace Amazon.DNXCore.IntegrationTests.DynamoDB
{
    public partial class DynamoDBTests
    {
        [Fact]
        [Trait(CategoryAttribute, "DynamoDB")]
        public async Task TestDerived()
        {
            foreach (var conversion in new DynamoDBEntryConversion[] { DynamoDBEntryConversion.V1, DynamoDBEntryConversion.V2 })
            {
                SharedTestFixture.TableCache.Clear();
                // Cleanup existing data
                await SharedTestFixture.CleanupTables();
                // Recreate context
                SharedTestFixture.CreateContext(conversion);

                var d = new Derived { Name = "Norm", Age = 1000, Data = "Man of the woods" };

                await SharedTestFixture.Context.SaveAsync<Derived>(d);

                var loaded = await SharedTestFixture.Context.LoadAsync<Derived>(d.Name, d.Age);
            }
        }

        public class Base
        {
            public virtual int Age { get; set; }
        }

        [DynamoDBTable("HashRangeTable")]
        public class Derived : Base
        {
            [DynamoDBHashKey]
            public string Name { get; set; }
            [DynamoDBRangeKey]
            public override int Age { get; set; }

            public string Data { get; set; }
        }
    }
}
