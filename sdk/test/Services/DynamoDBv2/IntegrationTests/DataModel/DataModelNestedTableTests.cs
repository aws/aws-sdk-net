using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [Trait("Category", "DynamoDBv2")]
    public class DataModelNestedTableTests : IClassFixture<NestedTableFixture>, IAsyncLifetime
    {
        private readonly NestedTableFixture _fixture;
        private DynamoDBContext _context;

        public DataModelNestedTableTests(NestedTableFixture fixture)
        {
            _fixture = fixture;
        }

        public async ValueTask InitializeAsync()
        {
            _context = new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => _fixture.Client)
                .ConfigureContext(x =>
                {
                    x.Conversion = DynamoDBEntryConversion.V2;
                    x.ConsistentRead = true;
                    x.IsEmptyStringValueEnabled = true;
                    x.TableNamePrefix = _fixture.TableNamePrefix;
                })
                .Build();
            await _fixture.CleanupTables();
        }

        public ValueTask DisposeAsync()
        {
            _context?.Dispose();
            return default;
        }

        /// <summary>
        /// Tests that the DynamoDB operations can read and write polymorphic items.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task TestContext_SaveAndLoad_WithDerivedTypeItems()
        {
            var model = CreateNestedTypeItem(out var id);

            await _context.SaveAsync(model);

            var storedModel = await _context.LoadAsync<ModelA>(id);
            Assert.Equal(model.Id, storedModel.Id);
            Assert.Equal(model.GetType(), storedModel.GetType());
            Assert.NotNull(storedModel.FlatAddress);

            var myType = model as ModelA1;
            var myStoredModel = storedModel as ModelA1;

            Assert.Equal(myType.MyType.GetType(), myStoredModel.MyType.GetType());
            Assert.Equal(myType.MyType.MyPropA, myStoredModel.MyType.MyPropA);
            Assert.Equal(myType.MyType.Name, myStoredModel.MyType.Name);
            Assert.Equal(((B)myType.MyType).MyPropB, ((B)myStoredModel.MyType).MyPropB);

            Assert.Equal(myType.MyInterface.GetType(), myStoredModel.MyInterface.GetType());

            var myInterface = myType.MyInterface as InterfaceA;
            var storedInterface = myStoredModel.MyInterface as InterfaceA;

            Assert.Equal(myInterface.S3, storedInterface.S3);

            Assert.Equal(myType.MyClasses.Count, myStoredModel.MyClasses.Count);
            Assert.Equal(myType.MyClasses[0].GetType(), myStoredModel.MyClasses[0].GetType());
            Assert.Equal(myType.MyClasses[1].GetType(), myStoredModel.MyClasses[1].GetType());
        }

        /// <summary>
        /// Tests that the DynamoDB operations can read and write polymorphic items.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task TestContext_TransactWriteAndLoad_WithDerivedTypeItems()
        {
            var model1 = CreateNestedTypeItem(out var id);
            var model2 = new ModelA2
            {
                Id = Guid.NewGuid(),
                MyType = new A { Name = "A1", MyPropA = 1 },
                MyInterface = new InterfaceB()
                {
                    S2 = 2,
                    S1 = "s1",
                    S4 = "s4"
                },
                DictionaryClasses = new Dictionary<string, A>()
                {
                    { "A", new A { Name = "A1", MyPropA = 1 } },
                    { "B", new B { Name = "A1", MyPropA = 1, MyPropB = 2 } }
                }
            };

            var transactWrite = _context.CreateTransactWrite<ModelA>();
            transactWrite.AddSaveItems(new[] { model1, model2 });
            await transactWrite.ExecuteAsync();

            var storedModel1 = await _context.LoadAsync<ModelA>(id);
            var storedModel2 = await _context.LoadAsync<ModelA>(model2.Id);
            Assert.Equal(model1.Id, storedModel1.Id);
            Assert.Equal(model1.GetType(), storedModel1.GetType());
            Assert.Equal(model2.Id, storedModel2.Id);
            Assert.Equal(model2.GetType(), storedModel2.GetType());

            var myInterface = model2.MyInterface as InterfaceB;
            var storedInterface = model2.MyInterface as InterfaceB;

            Assert.Equal(myInterface.S4, storedInterface.S4);
        }

        [Fact]
        public async Task TestContext_SaveAndBatchGet_WithDerivedTypeItems_ByHashKey()
        {
            var model1 = CreateNestedTypeItem(out var id1);
            var model2 = new ModelA2
            {
                Id = Guid.NewGuid(),
                MyType = new A { Name = "A1", MyPropA = 1 },
                MyInterface = new InterfaceB
                {
                    S2 = 2,
                    S1 = "s1",
                    S4 = "s4"
                },
                DictionaryClasses = new Dictionary<string, A>
                {
                    { "A", new A { Name = "A1", MyPropA = 1 } },
                    { "B", new B { Name = "A1", MyPropA = 1, MyPropB = 2 } }
                }
            };

            var transactWrite = _context.CreateTransactWrite<ModelA>();
            transactWrite.AddSaveItems(new[] { model1, model2 });
            await transactWrite.ExecuteAsync();

            var batchGet = _context.CreateBatchGet<ModelA>();
            batchGet.AddKey(id1);
            batchGet.AddKey(model2.Id);
            await batchGet.ExecuteAsync();

            Assert.Equal(2, batchGet.Results.Count);

            var storedModel1 = batchGet.Results.FirstOrDefault(m => m.Id == id1);
            var storedModel2 = batchGet.Results.FirstOrDefault(m => m.Id == model2.Id);

            Assert.NotNull(storedModel1);
            Assert.NotNull(storedModel2);
            Assert.IsType<ModelA1>(storedModel1);
            Assert.IsType<ModelA2>(storedModel2);
        }

        [Fact]
        public async Task TestContext_TransactWriteAndLoad_WithLocalSecondaryIndexRangeKey()
        {
            var model = new ModelA2
            {
                Id = Guid.NewGuid(),
                MyType = new A { Name = "AType", MyPropA = 5 },
                DictionaryClasses = new Dictionary<string, A>
                {
                    { "A", new A { Name = "A1", MyPropA = 1 } },
                    { "B", new B { Name = "B1", MyPropA = 2, MyPropB = 3 } }
                },
                ManagerName = "TestManager"
            };

            var transactWrite = _context.CreateTransactWrite<ModelA>();
            transactWrite.AddSaveItems(new[] { model });
            await transactWrite.ExecuteAsync();

            var storedModel = await _context.LoadAsync<ModelA>(model.Id);
            Assert.Equal(model.Id, storedModel.Id);
            Assert.Equal(model.GetType(), storedModel.GetType());
            var myStoredModel = storedModel as ModelA2;
            Assert.Equal(model.MyType.GetType(), myStoredModel.MyType.GetType());
            Assert.Equal(model.DictionaryClasses.Count, myStoredModel.DictionaryClasses.Count);
            Assert.Equal(model.DictionaryClasses["A"].GetType(), myStoredModel.DictionaryClasses["A"].GetType());
            Assert.Equal(model.DictionaryClasses["B"].GetType(), myStoredModel.DictionaryClasses["B"].GetType());
            Assert.Equal(((B)model.DictionaryClasses["B"]).MyPropB,
                ((B)myStoredModel.DictionaryClasses["B"]).MyPropB);
            Assert.Equal(model.ManagerName, myStoredModel.ManagerName);
        }

        [Fact]
        public async Task TestContext_SaveAndScan_WithGlobalSecondaryIndexRangeKey()
        {
            var model1 = new ModelA1
            {
                Id = Guid.NewGuid(),
                MyType = new B { Name = "BType1", MyPropA = 5, MyPropB = 10 },
                MyClasses = new List<A>
                {
                    new A { Name = "A1", MyPropA = 1 },
                    new B { Name = "B1", MyPropA = 2, MyPropB = 3 }
                },
                CompanyName = "TestCompany",
                Price = 100
            };

            var model2 = new ModelA1
            {
                Id = Guid.NewGuid(),
                MyType = new B { Name = "BType2", MyPropA = 6, MyPropB = 12 },
                MyClasses = new List<A>
                {
                    new A { Name = "A2", MyPropA = 2 },
                    new B { Name = "B2", MyPropA = 3, MyPropB = 4 }
                },
                CompanyName = "TestCompany",
                Price = 200
            };

            var transactWrite = _context.CreateTransactWrite<ModelA>();
            transactWrite.AddSaveItems(new[] { model1, model2 });
            await transactWrite.ExecuteAsync();

            var scanConditions = new[]
            {
                new ScanCondition("CompanyName", ScanOperator.Equal, "TestCompany")
            };

            var results = await _context.ScanAsync<ModelA>(scanConditions).GetRemainingAsync();
            Assert.Equal(2, results.Count);

            var storedModel1 = results.FirstOrDefault(m => m.Id == model1.Id) as ModelA1;
            var storedModel2 = results.FirstOrDefault(m => m.Id == model2.Id) as ModelA1;

            Assert.NotNull(storedModel1);
            Assert.NotNull(storedModel2);

            Assert.Equal(model1.Id, storedModel1.Id);
            Assert.Equal(model1.MyType.GetType(), storedModel1.MyType.GetType());
            Assert.Equal(((B)model1.MyType).MyPropB, ((B)storedModel1.MyType).MyPropB);
            Assert.Equal(model1.MyClasses.Count, storedModel1.MyClasses.Count);
            Assert.Equal(model1.CompanyName, storedModel1.CompanyName);
            Assert.Equal(model1.Price, storedModel1.Price);

            Assert.Equal(model2.Id, storedModel2.Id);
            Assert.Equal(model2.MyType.GetType(), storedModel2.MyType.GetType());
            Assert.Equal(((B)model2.MyType).MyPropB, ((B)storedModel2.MyType).MyPropB);
            Assert.Equal(model2.MyClasses.Count, storedModel2.MyClasses.Count);
            Assert.Equal(model2.CompanyName, storedModel2.CompanyName);
            Assert.Equal(model2.Price, storedModel2.Price);
        }

        [Fact]
        public async Task TestContext_SaveAndScan_WithLocalSecondaryIndexRangeKey()
        {
            var model1 = new ModelA2
            {
                Id = Guid.NewGuid(),
                MyType = new C { Name = "AType1", MyPropA = 5, MyPropC = "test" },
                DictionaryClasses = new Dictionary<string, A>
                {
                    { "A", new A { Name = "A1", MyPropA = 1 } },
                    { "B", new B { Name = "B1", MyPropA = 2, MyPropB = 3 } }
                },
                ManagerName = "Manager1"
            };

            var model2 = new ModelA2
            {
                Id = Guid.NewGuid(),
                MyType = new A { Name = "AType2", MyPropA = 6 },
                DictionaryClasses = new Dictionary<string, A>
                {
                    { "A", new A { Name = "A2", MyPropA = 2 } },
                    { "B", new B { Name = "B2", MyPropA = 3, MyPropB = 4 } }
                },
                ManagerName = "Manager2"
            };

            var transactWrite = _context.CreateTransactWrite<ModelA>();
            transactWrite.AddSaveItems(new[] { model1, model2 });
            await transactWrite.ExecuteAsync();

            var scanConditions = new[]
            {
                new ScanCondition("ManagerName", ScanOperator.Equal, "Manager1")
            };

            var results = await _context.ScanAsync<ModelA>(scanConditions).GetRemainingAsync();
            Assert.Equal(1, results.Count);

            var storedModel = results.FirstOrDefault(m => m.Id == model1.Id) as ModelA2;

            Assert.NotNull(storedModel);
            Assert.Equal(model1.Id, storedModel.Id);
            Assert.Equal(model1.MyType.GetType(), storedModel.MyType.GetType());
            Assert.Equal(model1.DictionaryClasses.Count, storedModel.DictionaryClasses.Count);
            Assert.Equal(model1.DictionaryClasses["A"].GetType(), storedModel.DictionaryClasses["A"].GetType());
            Assert.Equal(model1.DictionaryClasses["B"].GetType(), storedModel.DictionaryClasses["B"].GetType());
            Assert.Equal(((B)model1.DictionaryClasses["B"]).MyPropB,
                ((B)storedModel.DictionaryClasses["B"]).MyPropB);
            Assert.Equal(model1.ManagerName, storedModel.ManagerName);
        }

        private ModelA CreateNestedTypeItem(out Guid id)
        {
            var a1 = new A { Name = "A1", MyPropA = 1 };
            var b1 = new B { Name = "B1", MyPropA = 2, MyPropB = 3 };

            id = Guid.NewGuid();

            var model = new ModelA1
            {
                Id = id,
                MyType = b1,
                MyInterface = new InterfaceA()
                {
                    S1 = "s1",
                    S2 = 2,
                    S3 = 3
                },
                MyClasses = new List<A> { a1, b1 },
                FlatAddress = new Address()
                {
                    City = "Seattle",
                    Street = "Street"
                }
            };
            return model;
        }
    }
}
