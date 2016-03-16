using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Runtime;
using AWSSDK.Tests.Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace AWSSDK.IntegrationTests.DynamoDB
{
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        [Test]
        [Category("DynamoDB")]
        [Category("Integration")]
        [Category("WWW")]
        public void TestContext()
        {
            Client.BeforeRequestEvent += ClientBeforeRequestEvent;
            try
            {
                foreach (var conversion in new DynamoDBEntryConversion[] { DynamoDBEntryConversion.V1, DynamoDBEntryConversion.V2 })
                {
                    TableCache.Clear();

                    // Cleanup existing data
                    CleanupTables();
                    // Recreate context
                    CreateContext(conversion);

                    TestEmptyCollections(conversion);

                    TestContextConversions();
                    TestUnsupportedTypes();

                    TestHashObjects();
                    TestHashRangeObjects();
                    TestOtherContextOperations();
                    TestBatchOperations();
                }
            }
            finally
            {
                Client.BeforeRequestEvent -= ClientBeforeRequestEvent;
            }
        }

        private static void TestUnsupportedTypes()
        {
            // Verify that saving objects with invalid properties result in exceptions
            var employee2 = new Employee2
            {
                Name = "Alan",
                Age = 31,
                TimeWithCompany = TimeSpan.FromDays(300)
            };

            AutoResetEvent ars = new AutoResetEvent(false);
            Context.SaveAsync<Employee2>(employee2, (result) =>
            {
                var exception = result.Exception;
                Assert.AreEqual(typeof(InvalidOperationException), exception.GetType());
                ars.Set();
            }, options);
            ars.WaitOne();


            var employee3 = new Employee3
            {
                Name = "Alan",
                Age = 31,
                EmptyProperty = new EmptyType()
            };


            Context.SaveAsync<Employee3>(employee3, (result) =>
            {
                var exception = result.Exception;
                Assert.AreEqual(typeof(InvalidOperationException), exception.GetType());
                ars.Set();
            }, options);
            ars.WaitOne();

            // Verify that objects that are invalid result in exceptions
            ExpectException<InvalidOperationException>(() => Context.ScanAsync<TimeSpan>(new ScanCondition[] { }));
            ExpectException<InvalidOperationException>(() => Context.ScanAsync<EmptyType>(new ScanCondition[] { }));
        }

        private void TestContextConversions()
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
                var docV1 = Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV1 });
                var docV2 = Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);
            }

            {
                using (var contextV1 = new DynamoDBContext(Client, new DynamoDBContextConfig { Conversion = conversionV1 }))
                using (var contextV2 = new DynamoDBContext(Client, new DynamoDBContextConfig { Conversion = conversionV2 }))
                {
                    var docV1 = contextV1.ToDocument(product);
                    var docV2 = contextV2.ToDocument(product);
                    VerifyConversions(docV1, docV2);
                }
            }

            {

                AutoResetEvent ars = new AutoResetEvent(false);
                using (var contextV1 = new DynamoDBContext(Client, new DynamoDBContextConfig { Conversion = conversionV1 }))
                {
                    var ex = new Exception();
                    contextV1.SaveAsync(product, (result) =>
                    {
                        ex = result.Exception;
                        ars.Set();
                    }, options);
                    ars.WaitOne();

                    Assert.IsNull(ex);
                    ex = new Exception();

                    contextV1.SaveAsync(product, new DynamoDBOperationConfig { Conversion = conversionV2 }, (result) =>
                    {
                        ex = result.Exception;
                        ars.Set();
                    });
                    ars.WaitOne();
                    Assert.IsNull(ex);

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

                ExpectException<InvalidOperationException>(() => Context.ToDocument(product));
                ExpectException<InvalidOperationException>(() => Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV1 }));
                ExpectException<InvalidOperationException>(() => Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV2 }));

                // Remove circular dependence
                product.CompanyInfo.MostPopularProduct = new Product
                {
                    Id = 3,
                    Name = "CloudDebugger",
                    CompanyName = "CloudsAreGrate",
                    Price = 9000,
                    TagSet = new HashSet<string> { "Test" },
                };

                var docV1 = Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV1 });
                var docV2 = Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);
            }

            // Introduce circular reference in a Document and try to deserialize
            {
                // Normal serialization
                var docV1 = Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV1 });
                var docV2 = Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);

                // Add circular references
                docV1["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV1;
                docV2["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV2;

                ExpectException<InvalidOperationException>(() => Context.FromDocument<Product>(docV1, new DynamoDBOperationConfig { Conversion = conversionV1 }));
                ExpectException<InvalidOperationException>(() => Context.FromDocument<Product>(docV2, new DynamoDBOperationConfig { Conversion = conversionV2 }));

                // Remove circular references
                docV1["CompanyInfo"].AsDocument()["MostPopularProduct"] = null;
                docV2["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV1;
                var prod1 = Context.FromDocument<Product>(docV1, new DynamoDBOperationConfig { Conversion = conversionV1 });
                var prod2 = Context.FromDocument<Product>(docV2, new DynamoDBOperationConfig { Conversion = conversionV2 });
            }

        }

        private static void VerifyConversions(Document docV1, Document docV2)
        {
            Assert.AreEqual(1, docV1["Id"].AsInt());
            Assert.AreEqual("CloudSpotter", docV1["Product"].AsString());
            Assert.IsNotNull(docV1["Components"].AsPrimitiveList());
            Assert.IsNotNull(docV1["IsPublic"].AsPrimitive());
            Assert.IsNotNull(docV1["Tags"].AsPrimitiveList());
            Assert.IsNotNull(docV1["CompanyInfo"] as Document);
            Assert.IsNotNull(docV1["KeySizes"].AsPrimitiveList());

            Assert.AreEqual(1, docV2["Id"].AsInt());
            Assert.AreEqual("CloudSpotter", docV2["Product"].AsString());
            Assert.IsNull(docV2["Components"].AsPrimitiveList());
            Assert.IsNotNull(docV2["Components"].AsDynamoDBList());
            Assert.IsNull(docV2["IsPublic"].AsPrimitive());
            Assert.IsNotNull(docV2["IsPublic"].AsDynamoDBBool());
            Assert.IsNotNull(docV2["Tags"].AsPrimitiveList());
            Assert.IsNotNull(docV2["CompanyInfo"] as Document);
            Assert.IsNotNull(docV2["KeySizes"].AsPrimitiveList());
        }

        private void TestEmptyCollections(DynamoDBEntryConversion conversion)
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
            var ex = new Exception();
            AutoResetEvent ars = new AutoResetEvent(false);
            Context.SaveAsync(product, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            ex = new Exception();
            // Load and test the item
            Product retrieved = null;
            Context.LoadAsync<Product>(product, (result) =>
            {
                ex = result.Exception;
                retrieved = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();

            Assert.IsNull(ex);
            Assert.IsNotNull(retrieved);

            if (!isV1)
            {
                Assert.IsNotNull(retrieved.Components);
                Assert.AreEqual(0, retrieved.Components.Count);
            }
            Assert.IsNotNull(retrieved.Map);
            Assert.AreEqual(0, retrieved.Map.Count);
        }


        private void TestHashObjects()
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

            AutoResetEvent ars = new AutoResetEvent(false);
            var ex = new Exception();
            Context.SaveAsync(product, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            // Test conversion
            var doc = Context.ToDocument(product);
            Assert.IsNotNull(doc["Tags"].AsPrimitiveList());
            //if (DynamoDBEntryConversion.Schema == DynamoDBEntryConversion.ConversionSchema.V1)
            //    Assert.IsNotNull(doc["Components"].AsPrimitiveList());
            //else
            //    Assert.IsNotNull(doc["Components"].AsDynamoDBList());
            Utils.AssertTrue(
                doc["Components"].AsPrimitiveList() != null ||
                doc["Components"].AsDynamoDBList() != null);
            Assert.IsNotNull(doc["CompanyInfo"].AsDocument());

            // Load item
            Product retrieved = null;
            ex = new Exception();
            Context.LoadAsync<Product>(1, (result) =>
            {
                ex = result.Exception;
                retrieved = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();

            Assert.IsNull(ex);
            Assert.AreEqual(product.Id, retrieved.Id);
            Assert.AreEqual(product.TagSet.Count, retrieved.TagSet.Count);
            Assert.AreEqual(product.Components.Count, retrieved.Components.Count);
            Assert.IsNull(retrieved.InternalId);
            Assert.AreEqual(product.CurrentStatus, retrieved.CurrentStatus);
            Assert.AreEqual(product.IsPublic, retrieved.IsPublic);
            Assert.AreEqual(product.Rating, retrieved.Rating);
            Assert.AreEqual(product.KeySizes.Count, retrieved.KeySizes.Count);
            Assert.IsNotNull(retrieved.CompanyInfo);
            Assert.AreEqual(product.CompanyInfo.Name, retrieved.CompanyInfo.Name);
            Assert.AreEqual(product.CompanyInfo.Founded, retrieved.CompanyInfo.Founded);
            Assert.AreNotEqual(product.CompanyInfo.Revenue, retrieved.CompanyInfo.Revenue);
            Assert.AreEqual(product.CompanyInfo.AllProducts.Count, retrieved.CompanyInfo.AllProducts.Count);
            Assert.AreEqual(product.CompanyInfo.AllProducts[0].Id, retrieved.CompanyInfo.AllProducts[0].Id);
            Assert.AreEqual(product.CompanyInfo.AllProducts[1].Id, retrieved.CompanyInfo.AllProducts[1].Id);
            Assert.AreEqual(product.Map.Count, retrieved.Map.Count);
            Assert.AreEqual(product.CompanyInfo.CompetitorProducts.Count, retrieved.CompanyInfo.CompetitorProducts.Count);
            Assert.AreEqual(product.CompanyInfo.CompetitorProducts.ElementAt(0).Key, retrieved.CompanyInfo.CompetitorProducts.ElementAt(0).Key);
            Assert.AreEqual(product.CompanyInfo.CompetitorProducts.ElementAt(0).Value.Count, retrieved.CompanyInfo.CompetitorProducts.ElementAt(0).Value.Count);
            Assert.AreEqual(product.CompanyInfo.CompetitorProducts.ElementAt(1).Key, retrieved.CompanyInfo.CompetitorProducts.ElementAt(1).Key);
            Assert.AreEqual(product.CompanyInfo.CompetitorProducts.ElementAt(1).Value.Count, retrieved.CompanyInfo.CompetitorProducts.ElementAt(1).Value.Count);


            // Try saving circularly-referencing object
            product.CompanyInfo.AllProducts.Add(product);
            ex = null;
            Context.SaveAsync(product, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNotNull(ex);

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

            Context.SaveAsync(product, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            // Load new item
            retrieved = null;
            ex = new Exception();
            Context.LoadAsync<Product>(product, (result) =>
            {
                ex = result.Exception;
                retrieved = result.Result;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.IsNotNull(retrieved);
            Assert.AreEqual(product.Id, retrieved.Id);
            Assert.IsNull(retrieved.TagSet);
            Assert.IsNull(retrieved.Components);
            Assert.IsNull(retrieved.InternalId);
            Assert.AreEqual(product.CurrentStatus, retrieved.CurrentStatus);
            Assert.AreEqual(product.IsPublic, retrieved.IsPublic);
            Assert.AreEqual(product.AlwaysN, retrieved.AlwaysN);
            Assert.AreEqual(product.Rating, retrieved.Rating);
            Assert.IsNull(retrieved.KeySizes);

            // Enumerate all products and save their Ids
            List<int> productIds = new List<int>();
            var asyncSearch = Context.ScanAsync<Product>(new ScanCondition[] { });
            IEnumerable<Product> products = null;

            ex = null;
            asyncSearch.GetRemainingAsync((result) =>
            {
                ex = result.Exception;
                products = result.Result;
                ars.Set();
            });
            ars.WaitOne();

            Assert.IsNull(ex);

            foreach (var p in products)
            {
                productIds.Add(p.Id);
            }
            Assert.AreEqual(2, productIds.Count);

            // Load first product
            var firstId = productIds[0];
            Context.LoadAsync<Product>(firstId, (result) =>
            {
                product = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();

            Assert.IsNotNull(product);
            Assert.AreEqual(firstId, product.Id);

            // Query GlobalIndex
            Context.QueryAsync<Product>(
               product.CompanyName,            // Hash-key for the index is Company
               QueryOperator.GreaterThan,      // Range-key for the index is Price, so the
               new object[] { 90 },            // condition is against a numerical value
               new DynamoDBOperationConfig     // Configure the index to use
               {
                   IndexName = "GlobalIndex",
               }, (result) =>
               {
                   asyncSearch = result.Result;
                   ars.Set();
               }, options);
            ars.WaitOne();

            asyncSearch.GetRemainingAsync((result) =>
            {
                products = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.AreEqual(2, products.Count());

            // Query GlobalIndex with an additional non-key condition
            Context.QueryAsync<Product>(
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
                }, (result) =>
                {
                    asyncSearch = result.Result;
                    ars.Set();
                }, options);

            ars.WaitOne();
            asyncSearch.GetRemainingAsync((result) =>
            {

                products = result.Result;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.AreEqual(1, products.Count());

            // Delete first product
            ex = new Exception();
            Context.DeleteAsync<Product>(firstId, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();

            Assert.IsNull(ex);
            Context.LoadAsync<Product>(product.Id, (result) =>
            {
                product = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(product);

            // Scan the table
            Context.ScanAsync<Product>(new ScanCondition[] { }, null, (result) => { asyncSearch = result.Result; ars.Set(); }, options);
            ars.WaitOne();
            asyncSearch.GetRemainingAsync((result) =>
        {
            products = result.Result;
            ars.Set();
        }, options);
            ars.WaitOne();
            Assert.AreEqual(1, products.Count());

            // Test a versioned product
            VersionedProduct vp = new VersionedProduct
            {
                Id = 3,
                Name = "CloudDebugger",
                CompanyName = "CloudsAreGrate",
                Price = 9000,
                TagSet = new HashSet<string> { "Test" },
            };

            ex = new Exception();
            Context.SaveAsync(vp, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(ex);

            // Update and save
            vp.Price++;
            ex = new Exception();
            Context.SaveAsync(vp, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(ex);

            // Alter the version and try to save
            vp.Version = 0;
            ex = null;
            Context.SaveAsync(vp, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNotNull(ex);

            // Load and save
            ex = new Exception();
            Context.LoadAsync<VersionedProduct>(vp, (result) =>
            {
                ex = result.Exception;
                vp = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            ex = new Exception();
            Context.SaveAsync<VersionedProduct>(vp, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(ex);
        }

        private void TestHashRangeObjects()
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

            var ex = new Exception();
            AutoResetEvent ars = new AutoResetEvent(false);
            Context.SaveAsync(employee, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(ex);

            // Load item
            Employee retrieved = null;
            ex = new Exception();
            Context.LoadAsync<Employee>(employee, (result) =>
            {
                ex = result.Exception;
                retrieved = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.IsNotNull(retrieved);
            Assert.AreEqual(employee.Name, retrieved.Name);
            Assert.AreEqual(employee.Age, retrieved.Age);
            Assert.AreEqual(employee.CompanyName, retrieved.CompanyName);
            Assert.AreEqual(employee.CurrentStatus, retrieved.CurrentStatus);

            // Create and save new item
            employee.Name = "Chuck";
            employee.Age = 30;
            employee.CurrentStatus = Status.Inactive;
            employee.Aliases = new List<string> { "Charles" };
            employee.Data = Encoding.UTF8.GetBytes("Binary data");
            employee.Score = 94;
            ex = new Exception();
            Context.SaveAsync(employee, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(ex);

            // Load item
            ex = new Exception();
            Context.LoadAsync<Employee>(employee, (result) =>
            {
                ex = result.Exception;
                retrieved = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
            Assert.AreEqual(employee.Name, retrieved.Name);
            Assert.AreEqual(employee.Age, retrieved.Age);
            Assert.AreEqual(employee.CompanyName, retrieved.CompanyName);
            Assert.AreEqual(employee.CurrentStatus, retrieved.CurrentStatus);
            Assert.AreEqual(employee.Data.Length, retrieved.Data.Length);

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
            ex = new Exception();
            Context.SaveAsync(employee2, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(ex);

            employee2.Age = 24;
            employee2.Score = 101;

            ex = new Exception();
            Context.SaveAsync(employee2, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.IsNull(ex);

            Context.LoadAsync<Employee>("Alan", 31, (result) =>
            {
                retrieved = result.Result;
                ars.Set();
            }, options);

            ars.WaitOne();
            Assert.AreEqual(retrieved.Name, "Alan");

            Context.LoadAsync(employee, (result) =>
            {
                retrieved = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();

            Assert.AreEqual(retrieved.Name, "Chuck");


            Context.LoadAsync(employee2, new DynamoDBOperationConfig { ConsistentRead = true }, (result) =>
            {
                retrieved = result.Result;
                ars.Set();
            }, options);

            ars.WaitOne();


            Assert.AreEqual(retrieved.Name, "Diane");
            Assert.AreEqual(retrieved.Age, 24);

            // Scan for all items
            List<Employee> employees = null;

            Context.ScanAsync<Employee>(new ScanCondition[] { }).GetRemainingAsync((result) =>
            {
                employees = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();

            Assert.AreEqual(4, employees.Count);
            AsyncSearch<Employee> asyncSearch = null;

            // Query for items with Hash-Key = "Diane"
            Context.QueryAsync<Employee>("Diane", (result) =>
            {
                asyncSearch = result.Result;
                ars.Set();
            }, options);

            ars.WaitOne();
            asyncSearch.GetRemainingAsync((result) =>
            {
                employees = result.Result; ars.Set();

            }, options);
            ars.WaitOne();
            Assert.AreEqual(2, employees.Count);

            // Query for items with Hash-Key = "Diane" and Range-Key > 30
            Context.QueryAsync<Employee>("Diane", QueryOperator.GreaterThan, (result) =>
            {
                asyncSearch = result.Result;
                ars.Set();
            }, options, new object[] { 30 });

            ars.WaitOne();
            asyncSearch.GetRemainingAsync((result) =>
            {
                employees = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.AreEqual(1, employees.Count);


            // Index Query

            // Query local index for items with Hash-Key = "Diane"
            Context.QueryAsync<Employee>("Diane", new DynamoDBOperationConfig { IndexName = "LocalIndex" }, (result) =>
            {
                asyncSearch = result.Result;
                ars.Set();
            }, options);

            ars.WaitOne();
            asyncSearch.GetRemainingAsync((result) =>
            {
                employees = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.AreEqual(2, employees.Count);

            // Query local index for items with Hash-Key = "Diane" and Range-Key = "Eva"
            Context.QueryAsync<Employee>("Diane", QueryOperator.Equal, new object[] { "Eva" },
                 new DynamoDBOperationConfig { IndexName = "LocalIndex" },(result) =>
            {
                asyncSearch = result.Result;
                ars.Set();
            }, options);

            ars.WaitOne();
            asyncSearch.GetRemainingAsync((result) =>
                 {
                     employees = result.Result;
                     ars.Set();
                 }, options);
            ars.WaitOne();
            Assert.AreEqual(2, employees.Count);

            // Query global index for item with Hash-Key (Company) = "Big River"
            Context.QueryAsync<Employee>("Big River", new DynamoDBOperationConfig { IndexName = "GlobalIndex" }, (result) =>
            {
                asyncSearch = result.Result;
                ars.Set();
            }, options);

            ars.WaitOne();
            asyncSearch.GetRemainingAsync((result) =>
            {
                employees = result.Result;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.AreEqual(2, employees.Count);

            // Query global index for item with Hash-Key (Company) = "Big River", with QueryFilter for CurrentStatus = Status.Active
            Context.QueryAsync<Employee>("Big River",
                new DynamoDBOperationConfig
                {
                    IndexName = "GlobalIndex",
                    QueryFilter = new List<ScanCondition>
                    {
                        new ScanCondition("CurrentStatus", ScanOperator.Equal, Status.Active)
                    }
                }, (result) =>
                {
                    asyncSearch = result.Result;
                    ars.Set();
                }, options);

            ars.WaitOne();
            asyncSearch.GetRemainingAsync((result) =>
                {
                    employees = result.Result;
                    ars.Set();
                }, options);
            ars.WaitOne();
            Assert.AreEqual(1, employees.Count);


            // Index Scan

            // Scan local index for items with Hash-Key = "Diane"
            Context.ScanAsync<Employee>(
                new List<ScanCondition> { new ScanCondition("Name", ScanOperator.Equal, "Diane") },
                new DynamoDBOperationConfig { IndexName = "LocalIndex" }, (result) =>
                {
                    asyncSearch = result.Result;
                    ars.Set();
                }, options);

            ars.WaitOne();
            asyncSearch.GetRemainingAsync((result) =>
                {
                    employees = result.Result;
                    ars.Set();
                }, options);
            ars.WaitOne();
            Assert.AreEqual(2, employees.Count);

            // Scan local index for items with Hash-Key = "Diane" and Range-Key = "Eva"
            Context.ScanAsync<Employee>(
                new List<ScanCondition>
                {
                    new ScanCondition("Name", ScanOperator.Equal, "Diane"),
                    new ScanCondition("ManagerName", ScanOperator.Equal, "Eva")
                },
                new DynamoDBOperationConfig { IndexName = "LocalIndex" }, (result) =>
                {
                    asyncSearch = result.Result;
                    ars.Set();
                }, options);

            ars.WaitOne();
            asyncSearch.GetRemainingAsync((result) =>
                {
                    employees = result.Result;
                    ars.Set();
                }, options);
            ars.WaitOne();
            Assert.AreEqual(2, employees.Count);

            // Scan global index for item with Hash-Key (Company) = "Big River"
            Context.ScanAsync<Employee>(
                new List<ScanCondition> { new ScanCondition("CompanyName", ScanOperator.Equal, "Big River") },
                new DynamoDBOperationConfig { IndexName = "GlobalIndex" }, (result) =>
                {
                    asyncSearch = result.Result;
                    ars.Set();
                }, options);

            ars.WaitOne();
            asyncSearch.GetRemainingAsync((result) =>
                {
                    employees = result.Result;
                    ars.Set();
                }, options);
            ars.WaitOne();
            Assert.AreEqual(2, employees.Count);

            // Scan global index for item with Hash-Key (Company) = "Big River", with QueryFilter for CurrentStatus = Status.Active
            Context.ScanAsync<Employee>(
                new List<ScanCondition>
                {
                    new ScanCondition("CompanyName", ScanOperator.Equal, "Big River"),
                    new ScanCondition("CurrentStatus", ScanOperator.Equal, Status.Active)
                },
                new DynamoDBOperationConfig
                {
                    IndexName = "GlobalIndex"
                }, (result) =>
                {
                    asyncSearch = result.Result;
                    ars.Set();
                }, options);

            ars.WaitOne();
            asyncSearch.GetRemainingAsync((result) =>
                {
                    employees = result.Result;
                    ars.Set();
                }, options);
            ars.WaitOne();
            Assert.AreEqual(1, employees.Count);

        }

        private void TestBatchOperations()
        {
            int itemCount = 10;
            string employeePrefix = "Employee-";
            int employeeAgeStart = 20;
            int productIdStart = 90;
            string productPrefix = "Product-";

            var allEmployees = new List<Employee>();
            var batchWrite1 = Context.CreateBatchWrite<Employee>();
            var batchWrite2 = Context.CreateBatchWrite<Product>();
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
            var multiTableWrite = Context.CreateMultiTableBatchWrite(batchWrite1, batchWrite2);
            var ex = new Exception();
            AutoResetEvent ars = new AutoResetEvent(false);
            multiTableWrite.ExecuteAsync((result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();

            Assert.IsNull(ex);
            // Create BatchGets
            var batchGet1 = Context.CreateBatchGet<Product>();
            var batchGet2 = Context.CreateBatchGet<Employee>();
            for (int i = 0; i < itemCount; i++)
                batchGet1.AddKey(productIdStart + i, productPrefix + i);
            foreach (var employee in allEmployees)
                batchGet2.AddKey(employee);

            // Execute BatchGets together
            ex = new Exception();
            Context.ExecuteBatchGetAsync<Product>(new BatchGet[] { batchGet1, batchGet2 }, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            // Verify items are loaded
            Assert.AreEqual(itemCount, batchGet1.Results.Count);
            Assert.AreEqual(itemCount, batchGet2.Results.Count);
        }

        private void TestOtherContextOperations()
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

            Document doc = Context.ToDocument(employee1);
            Assert.AreEqual(employee1.Name, doc["Name"].AsString());
            Assert.AreEqual(employee1.Data.Length, doc["Data"].AsByteArray().Length);
            // Ignored properties are not propagated to the Document
            Utils.AssertFalse(doc.ContainsKey("InternalId"));

            Employee roundtrip = Context.FromDocument<Employee>(doc);
            Assert.AreEqual(employee1.Name, roundtrip.Name);
            Assert.AreEqual(employee1.Data.Length, roundtrip.Data.Length);
            Assert.IsNull(roundtrip.InternalId);

            // Recreate the record
            var ex = new Exception();
            AutoResetEvent ars = new AutoResetEvent(false);
            Context.DeleteAsync(employee1, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);

            Context.SaveAsync(employee1, (result) =>
            {
                ex = result.Exception;
                ars.Set();
            }, options);
            ars.WaitOne();
            Assert.IsNull(ex);
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
