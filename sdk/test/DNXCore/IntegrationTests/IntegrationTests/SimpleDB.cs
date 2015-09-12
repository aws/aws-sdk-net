using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;




using Amazon.SimpleDB;
using Amazon.SimpleDB.Model;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    /// <summary>
    /// Integration tests for SimpleDB client.
    /// </summary>
    
    public class SimpleDB : TestBase<AmazonSimpleDBClient>
    {        
        // Name of the domain used for all the integration tests.        
        private static string domainName = "aws-net-sdk-domain-" + DateTime.Now.Ticks;

        // All test data used in these integration tests.        
        private static List<ReplaceableItem> ALL_TEST_DATA = new List<ReplaceableItem>{
                new ReplaceableItem{
                    Name= "foo", 
                    Attributes= new List<ReplaceableAttribute>
                    {
                        new ReplaceableAttribute{Name="1",Value= "2"},                        
                        new ReplaceableAttribute{Name="3",Value= "4"},
                        new ReplaceableAttribute{Name="5",Value= "6"}
                    }
                },
                new ReplaceableItem{
                    Name="boo",
                    Attributes= new List<ReplaceableAttribute>
                    {
                        new ReplaceableAttribute{Name="X",Value= "Y"},
                        new ReplaceableAttribute{Name="Z",Value= "Q"}
                    }
                },
                new ReplaceableItem{
                    Name= "baa",
                    Attributes= new List<ReplaceableAttribute>
                    {
                        new ReplaceableAttribute{Name="A'",Value= "B'"},
                        new ReplaceableAttribute{Name="(C)", Value = "(D)"},
                        new ReplaceableAttribute{Name="E",Value= "F"}}
                }};

        private ReplaceableItem FOO_ITEM = ALL_TEST_DATA[0];

        private List<ReplaceableItem> ITEM_LIST =
            new List<ReplaceableItem> { ALL_TEST_DATA[1], ALL_TEST_DATA[2] };

        //[TearDown]
        void TearDown()
        {
            try
            {
                DeleteDomain(domainName);
            }
            catch (AmazonSimpleDBException) { }
        }


        [Fact]
        [Trait(CategoryAttribute,"SimpleDB")]
        public void TestSimpleDBOperations()
        {
            TestCreateDomain();
            try
            {
                UtilityMethods.Sleep(TimeSpan.FromSeconds(5));

                TestPutAttributes();
                TestPutAttributesWithCondition();
                TestBatchPutAttributes();

                TestGetAttributes();
                TestListDomains();
                TestDomainMetadata();

                TestSelect();
                TestDeleteAttributes();
            }
            finally
            {
                TestDeleteDomain();
                TearDown();
            }
        }

        private void TestCreateDomain()
        {
            Assert.False(DoesDomainExist(domainName));
            CreateDomain(domainName);

            bool found = false;
            for (int retries = 0; retries < 5 && !found; retries++)
            {
                UtilityMethods.Sleep(TimeSpan.FromSeconds(retries));
                found = DoesDomainExist(domainName);
            }
            Assert.True(found);
        }

        private void TestDeleteDomain()
        {
            DeleteDomain(domainName);
            Assert.False(DoesDomainExist(domainName));
        }

        private void TestListDomains()
        {
            var listDomainsResult = Client.ListDomainsAsync(new ListDomainsRequest()).Result;
            List<string> domainNames = listDomainsResult.DomainNames;
            Assert.True(domainNames.Contains(domainName));
        }

        private void TestPutAttributes()
        {
            PutAttributesRequest request = new PutAttributesRequest()
            {
                DomainName = domainName,
                ItemName = FOO_ITEM.Name,
                Attributes = FOO_ITEM.Attributes
            };
            Client.PutAttributesAsync(request).Wait();
            assertItemsStoredInDomain(Client, new List<ReplaceableItem> { FOO_ITEM }, domainName);
        }

        private void TestPutAttributesWithCondition()
        {
            PutAttributesRequest request = new PutAttributesRequest()
            {
                DomainName = domainName,
                ItemName = FOO_ITEM.Name,
                Attributes = new List<ReplaceableAttribute>() { FOO_ITEM.Attributes[0] },
                Expected = new UpdateCondition()
                {
                    Name = FOO_ITEM.Attributes[0].Name,
                    Exists = true,
                    Value = FOO_ITEM.Attributes[0].Value
                }
            };

            request.Attributes[0].Replace = true;
            request.Attributes[0].Value = "11";
            FOO_ITEM.Attributes[0].Value = "11";

            Client.PutAttributesAsync(request).Wait();

            assertItemsStoredInDomain(Client, new List<ReplaceableItem> { FOO_ITEM }, domainName);
        }

        private void TestBatchPutAttributes()
        {
            BatchPutAttributesRequest request = new BatchPutAttributesRequest()
            {
                DomainName = domainName,
                Items = ITEM_LIST
            };
            Client.BatchPutAttributesAsync(request).Wait();
            assertItemsStoredInDomain(Client, ITEM_LIST, domainName);
        }

        private void TestSelect()
        {
            SelectRequest request = new SelectRequest()
            {
                SelectExpression = "select * from `" + domainName + "`",
                ConsistentRead = true
            };
            var selectResult = Client.SelectAsync(request).Result;

            AssertItemsPresent(ITEM_LIST, selectResult.Items);
            AssertItemsPresent(new List<ReplaceableItem> { FOO_ITEM }, selectResult.Items);
        }

        private void TestDomainMetadata()
        {
            UtilityMethods.Sleep(TimeSpan.FromSeconds(5));
            DomainMetadataRequest request = new DomainMetadataRequest() { DomainName = domainName };
            var domainMetadataResult = Client.DomainMetadataAsync(request).Result;

            int expectedItemCount = 0;
            int expectedAttributeValueCount = 0;
            int expectedAttributeNameCount = 0;

            foreach (ReplaceableItem item in ALL_TEST_DATA)
            {
                expectedItemCount++;
                expectedAttributeNameCount += item.Attributes.Count;
                expectedAttributeValueCount += item.Attributes.Count;
            }

            Assert.Equal(expectedItemCount, domainMetadataResult.ItemCount);
            Assert.Equal(expectedAttributeNameCount, domainMetadataResult.AttributeNameCount);
            Assert.Equal(expectedAttributeValueCount, domainMetadataResult.AttributeValueCount);
            Assert.NotNull(domainMetadataResult.Timestamp);
        }

        private void TestGetAttributes()
        {
            GetAttributesRequest request = new GetAttributesRequest()
            {
                DomainName = domainName,
                ItemName = FOO_ITEM.Name,
                AttributeNames = new List<string>() { FOO_ITEM.Attributes[0].Name, FOO_ITEM.Attributes[1].Name },
                ConsistentRead = true
            };

            var getAttributesResult = Client.GetAttributesAsync(request).Result;
            List<Amazon.SimpleDB.Model.Attribute> attributes = getAttributesResult.Attributes;
            Dictionary<string, string> attributeValuesByName = ConvertAttributesToMap(attributes);

            Assert.Equal(2, attributeValuesByName.Count);

            List<ReplaceableAttribute> attrs = new List<ReplaceableAttribute>();
            attrs.Add(FOO_ITEM.Attributes[0]);
            attrs.Add(FOO_ITEM.Attributes[1]);

            foreach (ReplaceableAttribute expectedAttribute in attrs)
            {
                string expectedAttributeName = expectedAttribute.Name;
                Assert.True(attributeValuesByName.ContainsKey(expectedAttributeName));
                Assert.Equal(expectedAttribute.Value, attributeValuesByName[expectedAttributeName]);
            }
        }

        private void TestDeleteAttributes()
        {
            List<string> attributeNames = new List<string>();
            attributeNames.Add(FOO_ITEM.Attributes[0].Name);
            attributeNames.Add(FOO_ITEM.Attributes[1].Name);

            List<Amazon.SimpleDB.Model.Attribute> attributeList = new List<Amazon.SimpleDB.Model.Attribute>();

            foreach (string attributeName in attributeNames)
            {
                attributeList.Add(new Amazon.SimpleDB.Model.Attribute() { Name = attributeName });
            }

            Assert.True(DoAttributesExistForItem(Client, FOO_ITEM.Name, domainName, attributeNames));

            DeleteAttributesRequest request = new DeleteAttributesRequest()
            {
                DomainName = domainName,
                ItemName = FOO_ITEM.Name,
                Attributes = attributeList
            };

            Client.DeleteAttributesAsync(request).Wait();
            Assert.False(DoAttributesExistForItem(Client, FOO_ITEM.Name, domainName, attributeNames));
        }

        bool DoesDomainExist(String domainName)
        {
            try
            {
                DomainMetadataRequest request = new DomainMetadataRequest() { DomainName = domainName };
                Client.DomainMetadataAsync(request).Wait();
                return true;
            }
            catch(AggregateException ae)
            {
                if (ae.InnerExceptions != null &&
                    ae.InnerExceptions.Count == 1 &&
                    ae.InnerExceptions.First() is AmazonSimpleDBException)
                    return false;

                throw;
            }
        }

        void CreateDomain(String domainName)
        {
            CreateDomainRequest request = new CreateDomainRequest() { DomainName = domainName };
            Client.CreateDomainAsync(request).Wait();
        }

        bool DoAttributesExistForItem(IAmazonSimpleDB sdb, String itemName, String domainName, List<String> attributeNames)
        {
            GetAttributesRequest request = new GetAttributesRequest()
            {
                DomainName = domainName,
                AttributeNames = attributeNames,
                ItemName = itemName,
                ConsistentRead = true
            };

            var result = sdb.GetAttributesAsync(request).Result;
            Dictionary<string, string> attributeValuesByName = ConvertAttributesToMap(result.Attributes);

            foreach (string expectedAttributeName in attributeNames)
            {
                if (!attributeValuesByName.ContainsKey(expectedAttributeName))
                {
                    return false;
                }
            }
            return true;
        }

        Dictionary<string, string> ConvertAttributesToMap(List<Amazon.SimpleDB.Model.Attribute> attributeList)
        {
            Dictionary<string, string> attributeValuesByName = new Dictionary<string, string>();

            foreach (Amazon.SimpleDB.Model.Attribute attribute in attributeList)
            {
                attributeValuesByName.Add(attribute.Name, attribute.Value);
            }
            return attributeValuesByName;
        }

        void DeleteDomain(String domainName)
        {
            DeleteDomainRequest request = new DeleteDomainRequest()
            {
                DomainName = domainName,
            };
            Client.DeleteDomainAsync(request).Wait();
        }

        void assertItemsStoredInDomain(IAmazonSimpleDB sdb, List<ReplaceableItem> expectedItems, String domainName)
        {
            SelectRequest request = new SelectRequest()
            {
                SelectExpression = "select * from `" + domainName + "`",
                ConsistentRead = true
            };
            var selectResult = Client.SelectAsync(request).Result;
            AssertItemsPresent(expectedItems, selectResult.Items);
        }

        void AssertItemsPresent(List<ReplaceableItem> expectedItems, List<Item> items)
        {
            Dictionary<string, Dictionary<string, string>> expectedAttributesByItemName = ConvertReplaceableItemListToMap(expectedItems);
            Dictionary<string, Dictionary<string, string>> retrievedAttributesByItemName = ConvertItemListToMap(items);

            foreach (string expectedItemName in expectedAttributesByItemName.Keys)
            {
                Assert.True(retrievedAttributesByItemName.ContainsKey(expectedItemName));
                Dictionary<string, string> expectedAttributes = expectedAttributesByItemName[expectedItemName];
                Dictionary<string, string> retrievedAttributes = retrievedAttributesByItemName[expectedItemName];

                foreach (string expectedAttributeName in expectedAttributes.Keys)
                {
                    string expectedAttributeValue = expectedAttributes[expectedAttributeName];
                    Assert.True(retrievedAttributes.ContainsKey(expectedAttributeName));
                    Assert.Equal(expectedAttributeValue, retrievedAttributes[expectedAttributeName]);
                }

            }
        }

        private Dictionary<string, Dictionary<string, string>> ConvertReplaceableItemListToMap(List<ReplaceableItem> items)
        {
            Dictionary<string, Dictionary<string, string>> attributesByItemName = new Dictionary<string, Dictionary<string, string>>();

            foreach (ReplaceableItem item in items)
            {
                Dictionary<string, string> attributeValuesByName = new Dictionary<string, string>();
                foreach (ReplaceableAttribute attribute in item.Attributes)
                {
                    attributeValuesByName.Add(attribute.Name, attribute.Value);
                }
                attributesByItemName.Add(item.Name, attributeValuesByName);
            }
            return attributesByItemName;
        }

        private Dictionary<string, Dictionary<string, string>> ConvertItemListToMap(List<Item> items)
        {
            Dictionary<string, Dictionary<string, string>> attributesByItemName = new Dictionary<string, Dictionary<string, string>>();
            foreach (Item item in items)
            {
                attributesByItemName.Add(item.Name, ConvertAttributesToMap(item.Attributes));
            }

            return attributesByItemName;
        }
    }
}
