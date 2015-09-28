using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.DocumentModel;
using System.IO;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DNXCore.IntegrationTests;
using Xunit;
using System.Threading.Tasks;

namespace Amazon.DNXCore.IntegrationTests.DynamoDB
{
    public partial class DataModelTests : TestBase<AmazonDynamoDBClient>
    {
        static DataModelTests()
        {
            ConfigureContext();
        }

        [Fact]
        //[Category("DynamoDB")]
        public void TestContext()
        {
            RunAsSync(async () =>
            {
                foreach (var conversion in new DynamoDBEntryConversion[] { DynamoDBEntryConversion.V1, DynamoDBEntryConversion.V2 })
                {
                    using (var testSession = new DynamoDBTestSession("TestContext", Client))
                    {
                        await testSession.CreateTestTables();

                        // Recreate context
                        var context = testSession.CreateContext(conversion);                        

                        await TestEmptyCollections(conversion, context);

                        await TestContextConversions(context);
                        await TestUnsupportedTypes(context);

                        await TestHashObjects(context);
                        await TestHashRangeObjects(context);
                        await TestOtherContextOperations(context);
                        await TestBatchOperations(context);
                    }
                }
            });
        }

        private static void ConfigureContext()
        {
            var currentStatusPropertyConfig = new Util.PropertyConfig("CurrentStatus")
            {
                Converter = typeof(StatusConverter)
            };

            var employeeMapping = new Util.TypeMapping(typeof(Employee), "HashRangeTable");
            employeeMapping.AddProperty(new Util.PropertyConfig("ManagerName") { Attribute = "Manager" });
            employeeMapping.AddProperty(new Util.PropertyConfig("CompanyName") { Attribute = "Company" });
            employeeMapping.AddProperty(new Util.PropertyConfig("InternalId") { Ignore = true });
            employeeMapping.AddProperty(currentStatusPropertyConfig);

            var employee2Mapping = new Util.TypeMapping(typeof(Employee2), "HashRangeTable");
            employee2Mapping.AddProperty(currentStatusPropertyConfig);

            var employee3Mapping = new Util.TypeMapping(typeof(Employee3), "HashRangeTable");
            employee3Mapping.AddProperty(currentStatusPropertyConfig);

            var versionedEmployeeMapping = new Util.TypeMapping(typeof(VersionedEmployee), "FakeTable");
            versionedEmployeeMapping.AddProperty(new Util.PropertyConfig("Version") { Ignore = true });

            var context = AWSConfigsDynamoDB.Context;
            context.TableAliases["FakeTable"] = "HashRangeTable";
            context.AddMapping(versionedEmployeeMapping);
            context.AddMapping(employeeMapping);
            context.AddMapping(employee2Mapping);
            context.AddMapping(employee3Mapping);
        }

        private static async Task TestUnsupportedTypes(DynamoDBContext context)
        {
            // Verify that saving objects with invalid properties result in exceptions
            var employee2 = new Employee2
            {
                Name = "Alan",
                Age = 31,
                TimeWithCompany = TimeSpan.FromDays(300)
            };
            await AssertExtensions.ExpectExceptionAsync<InvalidOperationException>(context.SaveAsync(employee2),
                "Type System.TimeSpan is unsupported, it cannot be instantiated");
            var employee3 = new Employee3
            {
                Name = "Alan",
                Age = 31,
                EmptyProperty = new EmptyType()
            };
            await AssertExtensions.ExpectExceptionAsync<InvalidOperationException>(context.SaveAsync(employee3),
                "Type Amazon.DNXCore.IntegrationTests.DynamoDB.DataModelTests+EmptyType is unsupported, it has no supported members");

            // Verify that objects that are invalid result in exceptions
            AssertExtensions.ExpectException<InvalidOperationException>(() => context.ScanAsync<TimeSpan>(new ScanCondition[]{}),
                "Type System.TimeSpan is unsupported, it cannot be instantiated");
            AssertExtensions.ExpectException<InvalidOperationException>(() => context.ScanAsync<EmptyType>(new ScanCondition[] { }),
                "Type Amazon.DNXCore.IntegrationTests.DynamoDB.DataModelTests+EmptyType is unsupported, it has no supported members");
        }

        private async Task TestContextConversions(DynamoDBContext context)
        {
            var conversionV1 = DynamoDBEntryConversion.V1;
            var conversionV2 = DynamoDBEntryConversion.V2;

            Product product = new Product
            {
                Id = 1,
                Name = "CloudSpotter",
                CompanyName = "CloudsAreGrate",
                Price = 1200,
                TagSet = new HashSet<string> { "Prod", "1.0" },
                CurrentStatus = Status.Active,
                InternalId = "T1000",
                IsPublic = true,
                AlwaysN = true,
                Rating = 4,
                Components = new List<string> { "Code", "Coffee" },
                KeySizes = new List<byte> { 16, 64, 128 },
                CompanyInfo = new CompanyInfo
                {
                    Name = "MyCloud",
                    Founded = new DateTime(1994, 7, 6),
                    Revenue = 9001
                }
            };

            {
                var docV1 = context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV1 });
                var docV2 = context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);
            }

            {
                using (var contextV1 = new DynamoDBContext(Client, new 
                    
                    
                    
                    DynamoDBContextConfig { Conversion = conversionV1 }))
                using (var contextV2 = new DynamoDBContext(Client, new DynamoDBContextConfig { Conversion = conversionV2 }))
                {
                    var docV1 = contextV1.ToDocument(product);
                    var docV2 = contextV2.ToDocument(product);
                    VerifyConversions(docV1, docV2);
                }
            }

            {
                using (var contextV1 = new DynamoDBContext(Client, new DynamoDBContextConfig { Conversion = conversionV1 }))
                {
                    await contextV1.SaveAsync(product);
                    await contextV1.SaveAsync(product, new DynamoDBOperationConfig { Conversion = conversionV2 });
                }
            }

            // Introduce a circular reference and try to serialize
            {
                product.CompanyInfo = new CompanyInfo
                {
                    Name = "MyCloud",
                    Founded = new DateTime(1994, 7, 6),
                    Revenue = 9001,
                    MostPopularProduct = product
                };
                AssertExtensions.ExpectException<InvalidOperationException>(() => context.ToDocument(product));
                AssertExtensions.ExpectException<InvalidOperationException>(() => context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV1 }));
                AssertExtensions.ExpectException<InvalidOperationException>(() => context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV2 }));

                // Remove circular dependence
                product.CompanyInfo.MostPopularProduct = new Product
                {
                    Id = 3,
                    Name = "CloudDebugger",
                    CompanyName = "CloudsAreGrate",
                    Price = 9000,
                    TagSet = new HashSet<string> { "Test" },
                };

                var docV1 = context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV1 });
                var docV2 = context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);
            }

            // Introduce circular reference in a Document and try to deserialize
            {
                // Normal serialization
                var docV1 = context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV1 });
                var docV2 = context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);

                // Add circular references
                docV1["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV1;
                docV2["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV2;
                AssertExtensions.ExpectException(() => context.FromDocument<Product>(docV1, new DynamoDBOperationConfig { Conversion = conversionV1 }));
                AssertExtensions.ExpectException(() => context.FromDocument<Product>(docV2, new DynamoDBOperationConfig { Conversion = conversionV2 }));

                // Remove circular references
                docV1["CompanyInfo"].AsDocument()["MostPopularProduct"] = null;
                docV2["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV1;                
                var prod1 = context.FromDocument<Product>(docV1, new DynamoDBOperationConfig { Conversion = conversionV1 });
                var prod2 = context.FromDocument<Product>(docV2, new DynamoDBOperationConfig { Conversion = conversionV2 });
            }

        }

        private static void VerifyConversions(Document docV1, Document docV2)
        {
            Assert.Equal(1, docV1["Id"].AsInt());
            Assert.Equal("CloudSpotter", docV1["Product"].AsString());
            Assert.NotNull(docV1["Components"].AsPrimitiveList());
            Assert.NotNull(docV1["IsPublic"].AsPrimitive());
            Assert.NotNull(docV1["Tags"].AsPrimitiveList());
            Assert.NotNull(docV1["CompanyInfo"] as Document);
            Assert.NotNull(docV1["KeySizes"].AsPrimitiveList());

            Assert.Equal(1, docV2["Id"].AsInt());
            Assert.Equal("CloudSpotter", docV2["Product"].AsString());
            Assert.Null(docV2["Components"].AsPrimitiveList());
            Assert.NotNull(docV2["Components"].AsDynamoDBList());
            Assert.Null(docV2["IsPublic"].AsPrimitive());
            Assert.NotNull(docV2["IsPublic"].AsDynamoDBBool());
            Assert.NotNull(docV2["Tags"].AsPrimitiveList());
            Assert.NotNull(docV2["CompanyInfo"] as Document);
            Assert.NotNull(docV2["KeySizes"].AsPrimitiveList());
        }

        private async Task TestEmptyCollections(DynamoDBEntryConversion conversion, DynamoDBContext context)
        {
            // Check if the conversion being used is V1
            // In V1 conversion, lists are stored as sets, which cannot
            // be empty, so for V1 we are not testing empty lists
            var isV1 = (conversion == DynamoDBEntryConversion.V1);

            // Create and save item
            Product product = new Product
            {
                Id = 1,
                Map = new Dictionary<string, string>()
            };
            if (!isV1)
                product.Components = new List<string>();

            await context.SaveAsync(product);

            // Load and test the item
            var retrieved = await context.LoadAsync(product);
            if (!isV1)
            {
                Assert.NotNull(retrieved.Components);
                Assert.Equal(0, retrieved.Components.Count);
            }
            Assert.NotNull(retrieved.Map);
            Assert.Equal(0, retrieved.Map.Count);
        }
        private async Task TestHashObjects(DynamoDBContext context)
        {
            // Create and save item
            Product product = new Product
            {
                Id = 1,
                Name = "CloudSpotter",
                CompanyName = "CloudsAreGrate",
                Price = 1200,
                TagSet = new HashSet<string> { "Prod", "1.0" },
                CurrentStatus = Status.Active,
                InternalId = "T1000",
                IsPublic = true,
                AlwaysN = true,
                Rating = 4,
                Components = new List<string> { "Code", "Coffee" },
                KeySizes = new List<byte> { 16, 64, 128 },
                CompanyInfo = new CompanyInfo
                {
                    Name = "MyCloud",
                    Founded = new DateTime(1994, 7, 6),
                    Revenue = 9001,
                    AllProducts = new List<Product>
                    {
                        new Product { Id = 12, Name = "CloudDebugger" },
                        new Product { Id = 13, Name = "CloudDebuggerTester" }
                    },
                    CompetitorProducts = new Dictionary<string, List<Product>>
                    {
                        {
                            "CloudsAreOK",
                            new List<Product>
                            {
                                new Product { Id = 90, Name = "CloudSpotter RipOff" },
                                new Product { Id = 100, Name = "CloudDebugger RipOff" },
                            }
                        },
                        {
                            "CloudsAreBetter",
                            new List<Product>
                            {
                                new Product { Id = 92, Name = "CloudSpotter RipOff 2" },
                                new Product { Id = 102, Name = "CloudDebugger RipOff 3" },
                            }
                        },
                    }
                },
                Map = new Dictionary<string, string>
                {
                    { "a", "1" },
                    { "b", "2" }
                }
            };
            await context.SaveAsync(product);

            // Test conversion
            var doc = context.ToDocument(product);
            Assert.NotNull(doc["Tags"].AsPrimitiveList());
            //if (DynamoDBEntryConversion.Schema == DynamoDBEntryConversion.ConversionSchema.V1)
            //    Assert.NotNull(doc["Components"].AsPrimitiveList());
            //else
            //    Assert.NotNull(doc["Components"].AsDynamoDBList());
            Assert.True(
                doc["Components"].AsPrimitiveList() != null ||
                doc["Components"].AsDynamoDBList() != null);
            Assert.NotNull(doc["CompanyInfo"].AsDocument());

            // Load item
            Product retrieved = await context.LoadAsync<Product>(1);
            Assert.Equal(product.Id, retrieved.Id);
            Assert.Equal(product.TagSet.Count, retrieved.TagSet.Count);
            Assert.Equal(product.Components.Count, retrieved.Components.Count);
            Assert.Null(retrieved.InternalId);
            Assert.Equal(product.CurrentStatus, retrieved.CurrentStatus);
            Assert.Equal(product.IsPublic, retrieved.IsPublic);
            Assert.Equal(product.Rating, retrieved.Rating);
            Assert.Equal(product.KeySizes.Count, retrieved.KeySizes.Count);
            Assert.NotNull(retrieved.CompanyInfo);
            Assert.Equal(product.CompanyInfo.Name, retrieved.CompanyInfo.Name);
            Assert.Equal(product.CompanyInfo.Founded, retrieved.CompanyInfo.Founded);
            Assert.NotEqual(product.CompanyInfo.Revenue, retrieved.CompanyInfo.Revenue);
            Assert.Equal(product.CompanyInfo.AllProducts.Count, retrieved.CompanyInfo.AllProducts.Count);
            Assert.Equal(product.CompanyInfo.AllProducts[0].Id, retrieved.CompanyInfo.AllProducts[0].Id);
            Assert.Equal(product.CompanyInfo.AllProducts[1].Id, retrieved.CompanyInfo.AllProducts[1].Id);
            Assert.Equal(product.Map.Count, retrieved.Map.Count);
            Assert.Equal(product.CompanyInfo.CompetitorProducts.Count, retrieved.CompanyInfo.CompetitorProducts.Count);
            Assert.Equal(product.CompanyInfo.CompetitorProducts.ElementAt(0).Key, retrieved.CompanyInfo.CompetitorProducts.ElementAt(0).Key);
            Assert.Equal(product.CompanyInfo.CompetitorProducts.ElementAt(0).Value.Count, retrieved.CompanyInfo.CompetitorProducts.ElementAt(0).Value.Count);
            Assert.Equal(product.CompanyInfo.CompetitorProducts.ElementAt(1).Key, retrieved.CompanyInfo.CompetitorProducts.ElementAt(1).Key);
            Assert.Equal(product.CompanyInfo.CompetitorProducts.ElementAt(1).Value.Count, retrieved.CompanyInfo.CompetitorProducts.ElementAt(1).Value.Count);


            // Try saving circularly-referencing object
            product.CompanyInfo.AllProducts.Add(product);
            await AssertExtensions.ExpectExceptionAsync(context.SaveAsync(product));
            product.CompanyInfo.AllProducts.RemoveAt(2);

            // Create and save new item
            product.Id++;
            product.Price = 94;
            product.TagSet = null;
            product.Components = null;
            product.CurrentStatus = Status.Upcoming;
            product.IsPublic = false;
            product.AlwaysN = false;
            product.Rating = null;
            product.KeySizes = null;
            await context.SaveAsync(product);

            // Load new item
            retrieved = await context.LoadAsync<Product>(product);
            Assert.Equal(product.Id, retrieved.Id);
            Assert.Null(retrieved.TagSet);
            Assert.Null(retrieved.Components);
            Assert.Null(retrieved.InternalId);
            Assert.Equal(product.CurrentStatus, retrieved.CurrentStatus);
            Assert.Equal(product.IsPublic, retrieved.IsPublic);
            Assert.Equal(product.AlwaysN, retrieved.AlwaysN);
            Assert.Equal(product.Rating, retrieved.Rating);
            Assert.Null(retrieved.KeySizes);
            
            // Enumerate all products and save their Ids
            List<int> productIds = new List<int>();
            IEnumerable<Product> products = await context.ScanAsync<Product>(new ScanCondition[]{}).GetRemainingAsync();
            foreach(var p in products)
            {
                productIds.Add(p.Id);
            }
            Assert.Equal(2, productIds.Count);

            // Load first product
            var firstId = productIds[0];
            product = await context.LoadAsync<Product>(firstId);
            Assert.NotNull(product);
            Assert.Equal(firstId, product.Id);

            // Query GlobalIndex
            products = await context.QueryAsync<Product>(
                product.CompanyName,            // Hash-key for the index is Company
                QueryOperator.GreaterThan,      // Range-key for the index is Price, so the
                new object[] { 90 },            // condition is against a numerical value
                new DynamoDBOperationConfig     // Configure the index to use
                {
                    IndexName = "GlobalIndex",
                }).GetRemainingAsync();
            Assert.Equal(2, products.Count());

            // Query GlobalIndex with an additional non-key condition
            products = await context.QueryAsync<Product>(
                product.CompanyName,            // Hash-key for the index is Company
                QueryOperator.GreaterThan,      // Range-key for the index is Price, so the
                new object[] { 90 },            // condition is against a numerical value
                new DynamoDBOperationConfig     // Configure the index to use
                {
                    IndexName = "GlobalIndex",
                    QueryFilter = new List<ScanCondition> 
                    {
                        new ScanCondition("TagSet", ScanOperator.Contains, "1.0")
                    }
                }).GetRemainingAsync();
            Assert.Equal(1, products.Count());

            // Delete first product
            await context.DeleteAsync<Product>(firstId);
            product = await context.LoadAsync<Product>(product.Id);
            Assert.Null(product);

            // Scan the table
            products = await context.ScanAsync<Product>(new ScanCondition[] { }).GetRemainingAsync();
            Assert.Equal(1, products.Count());

            // Test a versioned product
            VersionedProduct vp = new VersionedProduct
            {
                Id = 3,
                Name = "CloudDebugger",
                CompanyName = "CloudsAreGrate",
                Price = 9000,
                TagSet = new HashSet<string> { "Test" },
            };
            await context.SaveAsync(vp);

            // Update and save
            vp.Price++;
            await context.SaveAsync(vp);

            // Alter the version and try to save
            vp.Version = 0;
            await AssertExtensions.ExpectExceptionAsync(context.SaveAsync(vp));

            // Load and save
            vp = await context.LoadAsync(vp);
            await context.SaveAsync(vp);
        }

        private async Task TestHashRangeObjects(DynamoDBContext context)
        {
            // Create and save item
            Employee employee = new Employee
            {
                Name = "Alan",
                Age = 31,
                CompanyName = "Big River",
                CurrentStatus = Status.Active,
                Score = 120,
                ManagerName = "Barbara",
                InternalId = "Alan@BigRiver",
                Aliases = new List<string> { "Al", "Steve" },
                Data = Encoding.UTF8.GetBytes("Some binary data"),
            };
            await context.SaveAsync(employee);

            // Load item
            Employee retrieved = await context.LoadAsync(employee);
            Assert.Equal(employee.Name, retrieved.Name);
            Assert.Equal(employee.Age, retrieved.Age);
            Assert.Equal(employee.CompanyName, retrieved.CompanyName);
            Assert.Equal(employee.CurrentStatus, retrieved.CurrentStatus);

            // Create and save new item
            employee.Name = "Chuck";
            employee.Age = 30;
            employee.CurrentStatus = Status.Inactive;
            employee.Aliases = new List<string> { "Charles" };
            employee.Data = Encoding.UTF8.GetBytes("Binary data");
            employee.Score = 94;
            await context.SaveAsync(employee);

            // Load item
            retrieved = await context.LoadAsync(employee);
            Assert.Equal(employee.Name, retrieved.Name);
            Assert.Equal(employee.Age, retrieved.Age);
            Assert.Equal(employee.CompanyName, retrieved.CompanyName);
            Assert.Equal(employee.CurrentStatus, retrieved.CurrentStatus);
            Assert.Equal(employee.Data.Length, retrieved.Data.Length);

            // Create more items
            Employee employee2 = new Employee
            {
                Name = "Diane",
                Age = 40,
                CompanyName = "Madeira",
                Score = 140,
                ManagerName = "Eva",
                Data = new byte[] { 1, 2, 3 },
                CurrentStatus = Status.Upcoming,
                InternalId = "Diane@Madeira",
            };
            await context.SaveAsync(employee2);
            employee2.Age = 24;
            employee2.Score = 101;
            await context.SaveAsync(employee2);

            retrieved = await context.LoadAsync<Employee>("Alan", 31);
            Assert.Equal(retrieved.Name, "Alan");
            retrieved = await context.LoadAsync(employee);
            Assert.Equal(retrieved.Name, "Chuck");
            retrieved = await context.LoadAsync(employee2, new DynamoDBOperationConfig { ConsistentRead = true });
            Assert.Equal(retrieved.Name, "Diane");
            Assert.Equal(retrieved.Age, 24);

            // Scan for all items
            var employees = await context.ScanAsync<Employee>(new ScanCondition[]{}).GetRemainingAsync();
            Assert.Equal(4, employees.Count);

            // Query for items with Hash-Key = "Diane"
            employees = await context.QueryAsync<Employee>("Diane").GetRemainingAsync();
            Assert.Equal(2, employees.Count);

            // Query for items with Hash-Key = "Diane" and Range-Key > 30
            employees = await context.QueryAsync<Employee>("Diane", QueryOperator.GreaterThan, new object[] { 30 }).GetRemainingAsync();
            Assert.Equal(1, employees.Count);

            
            // Index Query

            // Query local index for items with Hash-Key = "Diane"
            employees = await context.QueryAsync<Employee>("Diane", new DynamoDBOperationConfig { IndexName = "LocalIndex" }).GetRemainingAsync();
            Assert.Equal(2, employees.Count);

            // Query local index for items with Hash-Key = "Diane" and Range-Key = "Eva"
            employees = await context.QueryAsync<Employee>("Diane", QueryOperator.Equal, new object[] { "Eva" },
                new DynamoDBOperationConfig { IndexName = "LocalIndex" }).GetRemainingAsync();
            Assert.Equal(2, employees.Count);

            // Query global index for item with Hash-Key (Company) = "Big River"
            employees = await context.QueryAsync<Employee>("Big River", new DynamoDBOperationConfig { IndexName = "GlobalIndex" }).GetRemainingAsync();
            Assert.Equal(2, employees.Count);

            // Query global index for item with Hash-Key (Company) = "Big River", with QueryFilter for CurrentStatus = Status.Active
            employees = await context.QueryAsync<Employee>("Big River",
                new DynamoDBOperationConfig
                {
                    IndexName = "GlobalIndex",
                    QueryFilter = new List<ScanCondition>
                    {
                        new ScanCondition("CurrentStatus", ScanOperator.Equal, Status.Active)
                    }
                }).GetRemainingAsync();
            Assert.Equal(1, employees.Count);


            // Index Scan

            // Scan local index for items with Hash-Key = "Diane"
            employees = await context.ScanAsync<Employee>(
                new List<ScanCondition> { new ScanCondition("Name", ScanOperator.Equal, "Diane") },
                new DynamoDBOperationConfig { IndexName = "LocalIndex" }).GetRemainingAsync();
            Assert.Equal(2, employees.Count);

            // Scan local index for items with Hash-Key = "Diane" and Range-Key = "Eva"
            employees = await context.ScanAsync<Employee>(
                new List<ScanCondition>
                {
                    new ScanCondition("Name", ScanOperator.Equal, "Diane"),
                    new ScanCondition("ManagerName", ScanOperator.Equal, "Eva")
                },                
                new DynamoDBOperationConfig { IndexName = "LocalIndex" }).GetRemainingAsync();
            Assert.Equal(2, employees.Count);

            // Scan global index for item with Hash-Key (Company) = "Big River"
            employees = await context.ScanAsync<Employee>(
                new List<ScanCondition> { new ScanCondition("CompanyName", ScanOperator.Equal, "Big River") },
                new DynamoDBOperationConfig { IndexName = "GlobalIndex" }).GetRemainingAsync();
            Assert.Equal(2, employees.Count);

            // Scan global index for item with Hash-Key (Company) = "Big River", with QueryFilter for CurrentStatus = Status.Active
            employees = await context.ScanAsync<Employee>(
                new List<ScanCondition>
                {
                    new ScanCondition("CompanyName", ScanOperator.Equal, "Big River"),
                    new ScanCondition("CurrentStatus", ScanOperator.Equal, Status.Active)
                },
                new DynamoDBOperationConfig
                {
                    IndexName = "GlobalIndex"
                }).GetRemainingAsync();
            Assert.Equal(1, employees.Count);

        }

        private async Task TestBatchOperations(DynamoDBContext context)
        {
            int itemCount = 10;
            string employeePrefix = "Employee-";
            int employeeAgeStart = 20;
            int productIdStart = 90;
            string productPrefix = "Product-";

            var allEmployees = new List<Employee>();
            var batchWrite1 = context.CreateBatchWrite<Employee>();
            var batchWrite2 = context.CreateBatchWrite<Product>();
            for (int i = 0; i < itemCount; i++)
            {
                var employee = new Employee
                {
                    Name = employeePrefix + i,
                    Age = employeeAgeStart + i,
                    CompanyName = "Big River",
                    CurrentStatus = i % 2 == 0 ? Status.Active : Status.Inactive,
                    Score = 90 + i,
                    ManagerName = "Barbara",
                    InternalId = i + "@BigRiver",
                    Data = Encoding.UTF8.GetBytes(new string('@', i + 5))
                };
                allEmployees.Add(employee);
                batchWrite2.AddPutItem(new Product
                {
                    Id = productIdStart + i,
                    Name = productPrefix + i
                });
            }
            batchWrite1.AddPutItems(allEmployees);
            
            // Write both batches at once
            var multiTableWrite = context.CreateMultiTableBatchWrite(batchWrite1, batchWrite2);
            await multiTableWrite.ExecuteAsync();

            // Create BatchGets
            var batchGet1 = context.CreateBatchGet<Product>();
            var batchGet2 = context.CreateBatchGet<Employee>();
            for (int i = 0; i < itemCount;i++ )
                batchGet1.AddKey(productIdStart + i, productPrefix + i);
            foreach (var employee in allEmployees)
                batchGet2.AddKey(employee);

            // Execute BatchGets together
            await context.ExecuteBatchGetAsync(batchGet1, batchGet2);

            // Verify items are loaded
            Assert.Equal(itemCount, batchGet1.Results.Count);
            Assert.Equal(itemCount, batchGet2.Results.Count);
        }

        private async Task TestOtherContextOperations(DynamoDBContext context)
        {
            Employee employee1 = new Employee
            {
                Name = "Alan",
                Age = 31,
                CompanyName = "Big River",
                CurrentStatus = Status.Active,
                Score = 120,
                ManagerName = "Barbara",
                InternalId = "Alan@BigRiver",
                Aliases = new List<string> { "Al", "Steve" },
                Data = Encoding.UTF8.GetBytes("Some binary data")
            };

            Document doc = context.ToDocument(employee1);
            Assert.Equal(employee1.Name, doc["Name"].AsString());
            Assert.Equal(employee1.Data.Length, doc["Data"].AsByteArray().Length);
            // Ignored properties are not propagated to the Document
            Assert.False(doc.ContainsKey("InternalId"));

            Employee roundtrip = context.FromDocument<Employee>(doc);
            Assert.Equal(employee1.Name, roundtrip.Name);
            Assert.Equal(employee1.Data.Length, roundtrip.Data.Length);
            Assert.Null(roundtrip.InternalId);

            // Recreate the record
            await context.DeleteAsync(employee1);
            await context.SaveAsync(employee1);

            // Get record using Table instead of context.
            var table = context.GetTargetTable<Employee>();
            Document retrieved = await table.GetItemAsync(doc);
            Assert.Equal(employee1.Name, doc["Name"].AsString());
            Assert.Equal(employee1.Data.Length, doc["Data"].AsByteArray().Length);
        }


        #region OPM definitions

        public enum Status { Active, Inactive, Upcoming, Obsolete, Removed }

        public class StatusConverter : IPropertyConverter
        {
            public DynamoDBEntry ToEntry(object value)
            {
                Status status = (Status)value;
                return new Primitive(status.ToString());
            }

            public object FromEntry(DynamoDBEntry entry)
            {
                Primitive primitive = entry.AsPrimitive();
                string text = primitive.AsString();
                Status status = (Status)Enum.Parse(typeof(Status), text);
                return status;
            }
        }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashTable
        /// </summary>
        [DynamoDBTable("HashTable")]
        public class Product
        {
            [DynamoDBHashKey]
            public int Id { get; set; }

            [DynamoDBProperty("Product")]
            public string Name { get; set; }

            [DynamoDBGlobalSecondaryIndexHashKey("GlobalIndex", AttributeName = "Company")]
            public string CompanyName { get; set; }

            public CompanyInfo CompanyInfo { get; set; }

            [DynamoDBGlobalSecondaryIndexRangeKey("GlobalIndex")]
            public int Price { get; set; }

            [DynamoDBProperty("Tags")]
            public HashSet<string> TagSet { get; set; }

            public MemoryStream Data { get; set; }

            [DynamoDBProperty(Converter = typeof(StatusConverter))]
            public Status CurrentStatus { get; set; }

            [DynamoDBIgnore]
            public string InternalId { get; set; }

            public bool IsPublic { get; set; }

            //[DynamoDBProperty(Converter = typeof(BoolAsNConverter))]
            public bool AlwaysN { get; set; }

            public int? Rating { get; set; }

            public List<string> Components { get; set; }

            //[DynamoDBProperty(Converter = typeof(SetPropertyConverter<List<byte>,byte>))]
            [DynamoDBProperty(Converter = typeof(ListToSetPropertyConverter<byte>))]
            public List<byte> KeySizes { get; set; }

            public Dictionary<string, string> Map { get; set; }
        }

        public class CompanyInfo
        {
            public string Name { get; set; }
            public DateTime Founded { get; set; }
            public Product MostPopularProduct { get; set; }
            public List<Product> AllProducts { get; set; }
            public Dictionary<string, List<Product>> CompetitorProducts { get; set; }

            [DynamoDBIgnore]
            public decimal Revenue { get; set; }
        }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashTable
        /// This class uses optimistic locking via the Version field
        /// </summary>
        public class VersionedProduct : Product
        {
            [DynamoDBVersion]
            public int? Version { get; set; }
        }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashRangeTable
        /// 
        /// No DynamoDB attributes are defined on the type:
        /// -some attributes are inferred from the table
        /// -some attributes are defined in app.config
        /// </summary>
        public class Employee
        {
            // Hash key
            public string Name { get; set; }
            // Range key
            public int Age { get; set; }

            public string CompanyName { get; set; }
            public int Score { get; set; }
            public string ManagerName { get; set; }
            public byte[] Data { get; set; }
            public Status CurrentStatus { get; set; }
            public List<string> Aliases { get; set; }

            public string InternalId { get; set; }
        }

        /// <summary>
        /// Class with a property of a type that has no valid constructor
        /// </summary>
        public class Employee2 : Employee
        {
            public TimeSpan TimeWithCompany { get; set; }
        }

        /// <summary>
        /// Class with a property of an empty type
        /// </summary>
        public class Employee3 : Employee
        {
            public EmptyType EmptyProperty { get; set; }
        }

        /// <summary>
        /// Empty type
        /// </summary>
        public class EmptyType
        { }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashTable
        /// This class uses optimistic locking via the Version field
        /// </summary>
        public class VersionedEmployee : Employee
        {
            public int? Version { get; set; }
        }

        #endregion
    }
}
