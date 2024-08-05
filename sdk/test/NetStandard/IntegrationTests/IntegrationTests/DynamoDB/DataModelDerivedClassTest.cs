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
        public async Task TestDerivedPropertyOverrides()
        {
            foreach (var conversion in new DynamoDBEntryConversion[] { DynamoDBEntryConversion.V1, DynamoDBEntryConversion.V2 })
            {
                var d = new Derived { Name = "Norm", Age = 1000, Data = "Man of the woods" };

                await SharedTestFixture.Context.SaveAsync<Derived>(d);

                var loaded = await SharedTestFixture.Context.LoadAsync<Derived>(d.Name, d.Age);
                Assert.Equal(d.Name, loaded.Name);
                Assert.Equal(d.Age, loaded.Age);
                Assert.Equal(d.Data, loaded.Data);

                await SharedTestFixture.Context.DeleteAsync<Derived>(loaded);
            }
        }
        
        [Fact]
        [Trait(CategoryAttribute, "DynamoDB")]
        public async Task TestDerivedProperties_MaskedUsingNew()
        {
            foreach (var conversion in new DynamoDBEntryConversion[] { DynamoDBEntryConversion.V1, DynamoDBEntryConversion.V2 })
            {
                var d = new DerivedClassExample { Name = "Name", Age = 200, Data = "Test data"};

                await SharedTestFixture.Context.SaveAsync<DerivedClassExample>(d);

                var loaded = await SharedTestFixture.Context.LoadAsync<DerivedClassExample>(d.Name, d.Age);
                Assert.Equal(d.Name, loaded.Name);
                Assert.Equal(d.Age, loaded.Age);
                Assert.Equal(d.Data, loaded.Data);

                await SharedTestFixture.Context.DeleteAsync<DerivedClassExample>(loaded);
            }
        }

        private class Base
        {
            public virtual int Age { get; set; }
        }

        [DynamoDBTable("HashRangeTable")]
        private class Derived : Base
        {
            [DynamoDBHashKey]
            public string Name { get; set; }
            [DynamoDBRangeKey]
            public override int Age { get; set; }

            public string Data { get; set; }
        }
        
        public class BaseClassExample
        {
            public string Name { get; set; }
        
            public int Age { get; set; }

            public string Data { get; set; }
        }
        
        [DynamoDBTable("HashRangeTable")]
        public class DerivedClassExample: BaseClassExample
        {
            [DynamoDBHashKey]
            public new string Name
            {
                get => base.Name;
                set => base.Name = value;
            }
            public new int Age { get; set; }
        }
    }
}
