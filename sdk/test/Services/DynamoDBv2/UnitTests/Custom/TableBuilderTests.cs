using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AWSSDK_DotNet.UnitTests
{
    /// <summary>
    /// Tests for <see cref="TableBuilder"/>
    /// </summary>
    [TestClass]
    public class TableBuilderTests
    {
        private IAmazonDynamoDB _amazonDynamoDBClient = new AmazonDynamoDBClient();

        /// <summary>
        /// Asserts that the table requires a hash key definition
        /// </summary>
        [TestMethod]
        public void MissingPrimaryKey_ThrowsException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => builder.Build());
        }

        /// <summary>
        /// Asserts that the hash key requires a non-null attribute
        /// </summary>
        [TestMethod]
        public void NullPrimaryKey_ThrowsException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");

            Assert.ThrowsException<ArgumentNullException>(() => builder.AddHashKey("", DynamoDBEntryType.String));
        }

        /// <summary>
        /// Asserts that the builder throws an exception when more that one hash key is defined
        /// </summary>
        [TestMethod]
        public void MoreThanOnePrimaryKey_ThrowsException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");
            builder.AddHashKey("Id", DynamoDBEntryType.String);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => builder.AddHashKey("Id2", DynamoDBEntryType.String));
        }

        /// <summary>
        /// Asserts that the hash key requires a non-null attribute
        /// </summary>
        [TestMethod]
        public void NullRangeKey_ThrowsException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");

            Assert.ThrowsException<ArgumentNullException>(() => builder.AddRangeKey("", DynamoDBEntryType.String));
        }

        /// <summary>
        /// Asserts that the builder throws an exception when more that one range key is defined
        /// </summary>
        [TestMethod]
        public void MoreThanOneRangeKey_ThrowsException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");
            builder.AddRangeKey("Date", DynamoDBEntryType.String);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => builder.AddRangeKey("Date2", DynamoDBEntryType.String));
        }

        /// <summary>
        /// Asserts that the builder throws an exception when a LSI is defined before the hash key is,
        /// since the LSI reuses the hash key
        /// </summary>
        [TestMethod]
        public void LSIWithoutPrimaryKey_ThrowsException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");

            Assert.ThrowsException<ArgumentException>(() => builder.AddLocalSecondaryIndex("LSI", "Date", DynamoDBEntryType.String));
        }

        /// <summary>
        /// Asserts that the builder throws an exception when a LSI is defined without an index name
        /// </summary>
        [TestMethod]
        public void MissingLSIIndexName_ThrowsException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");
            builder.AddHashKey("Id", DynamoDBEntryType.String);

            Assert.ThrowsException<ArgumentNullException>(() => builder.AddLocalSecondaryIndex("", "Date", DynamoDBEntryType.String));
        }

        /// <summary>
        /// Asserts that the builder throws an exception when a LSI is defined without an attribute name
        /// </summary>
        [TestMethod]
        public void MissingLSIAttribute_ThrowsException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");
            builder.AddHashKey("Id", DynamoDBEntryType.String);

            Assert.ThrowsException<ArgumentNullException>(() => builder.AddLocalSecondaryIndex("LSI", "", DynamoDBEntryType.String));
        }

        /// <summary>
        /// Asserts that the builder throws an exception when a duplicate LSI is defined
        /// </summary>
        [TestMethod]
        public void DuplicateLSIName_ThrowsException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");
            builder.AddHashKey("Id", DynamoDBEntryType.String);
            builder.AddLocalSecondaryIndex("LSI", "Date", DynamoDBEntryType.String);

            Assert.ThrowsException<ArgumentException>(() => builder.AddLocalSecondaryIndex("LSI", "Date2", DynamoDBEntryType.String));
        }

        /// <summary>
        /// Asserts that the builder only stores key attributes once when reused in an LSI
        /// </summary>
        [TestMethod]
        public void AttributeReusedViaLSI_OnlyStoredOnce()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");
            builder.AddHashKey("Id", DynamoDBEntryType.String);

            // Add a GSI with two new attributes
            builder.AddGlobalSecondaryIndex("GSI", "Date", DynamoDBEntryType.String, "OrderNumber", DynamoDBEntryType.Numeric);

            // Add a LSI that reuses one of those, which shouldn't be stored in table.Attributes again
            builder.AddLocalSecondaryIndex("LSI", "OrderNumber", DynamoDBEntryType.Numeric);

            var table = builder.Build();

            Assert.AreEqual(3, table.Attributes.Count);
        }

        /// <summary>
        /// Asserts that the builder throws an exception when any of the required GSI identifiers are null
        /// </summary>
        public void GSINullNames_ThrowException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");

            // Null GSI index name
            Assert.ThrowsException<ArgumentNullException>(() => builder.AddGlobalSecondaryIndex("", "Id", DynamoDBEntryType.String));
            Assert.ThrowsException<ArgumentNullException>(() => builder.AddGlobalSecondaryIndex("", "Id", DynamoDBEntryType.String, "Date", DynamoDBEntryType.String));

            // Null hash key
            Assert.ThrowsException<ArgumentException>(() => builder.AddGlobalSecondaryIndex("GSI", "", DynamoDBEntryType.String));
            Assert.ThrowsException<ArgumentException>(() => builder.AddGlobalSecondaryIndex("GSI", "", DynamoDBEntryType.String, "Date", DynamoDBEntryType.String));

            // Null range key
            Assert.ThrowsException<ArgumentException>(() => builder.AddGlobalSecondaryIndex("GSI", "Id", DynamoDBEntryType.String, "", DynamoDBEntryType.String));
        }

        /// <summary>
        /// Asserts that the builder throws an exception when a duplicate GSI is defined
        /// </summary>
        [TestMethod]
        public void DuplicateGSIName_ThrowsException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");
            builder.AddGlobalSecondaryIndex("GSI", "Id", DynamoDBEntryType.String, "Date", DynamoDBEntryType.String);

            Assert.ThrowsException<ArgumentException>(() => builder.AddGlobalSecondaryIndex("GSI", "Id", DynamoDBEntryType.String));
            Assert.ThrowsException<ArgumentException>(() => builder.AddGlobalSecondaryIndex("GSI", "Id", DynamoDBEntryType.String, "Date", DynamoDBEntryType.String));
        }

        /// <summary>
        /// Asserts that the builder only stores key attributes once when they are reused in a GSI
        /// </summary>
        [TestMethod]
        public void AttributesResuedViaGSI_OnlyStoredOnce()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");
            builder.AddHashKey("Id", DynamoDBEntryType.String);
            builder.AddRangeKey("Date", DynamoDBEntryType.String);

            // Add a GSI that uses those same two attributes
            builder.AddGlobalSecondaryIndex("GSI-1", "Date", DynamoDBEntryType.String);
            builder.AddGlobalSecondaryIndex("GSI-2", "Date", DynamoDBEntryType.String, "Id", DynamoDBEntryType.String);

            var table = builder.Build();

            Assert.AreEqual(2, table.Attributes.Count);
        }

        [TestMethod]
        public void AddGlobalSecondaryIndex_Dictionary_NullOrEmptyIndexName_ThrowsArgumentNullException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");

            var hash = new List<KeyValuePair<string, DynamoDBEntryType>> { new KeyValuePair<string, DynamoDBEntryType>("Id", DynamoDBEntryType.String) };

            Assert.ThrowsException<ArgumentNullException>(() => builder.AddGlobalSecondaryIndex("", hash, null));
        }

        [TestMethod]
        public void AddGlobalSecondaryIndex_Dictionary_NullHashkeyAttributes_ThrowsArgumentNullException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");

            Assert.ThrowsException<ArgumentNullException>(() => builder.AddGlobalSecondaryIndex("GSI", null, null));
        }

        [TestMethod]
        public void AddGlobalSecondaryIndex_Dictionary_EmptyHashAttributeName_ThrowsArgumentNullException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");

            var hash = new List<KeyValuePair<string, DynamoDBEntryType>> { new KeyValuePair<string, DynamoDBEntryType>("", DynamoDBEntryType.String) };

            Assert.ThrowsException<ArgumentNullException>(() => builder.AddGlobalSecondaryIndex("GSI", hash, null));
        }

        [TestMethod]
        public void AddGlobalSecondaryIndex_Dictionary_HashKeyCountExceeded_ThrowsArgumentException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");

            var hash = new List<KeyValuePair<string, DynamoDBEntryType>>
            {
                new KeyValuePair < string, DynamoDBEntryType >("H1", DynamoDBEntryType.String),
                new KeyValuePair < string, DynamoDBEntryType >("H2", DynamoDBEntryType.String),
                new KeyValuePair < string, DynamoDBEntryType >("H3", DynamoDBEntryType.String),
                new KeyValuePair < string, DynamoDBEntryType >("H4", DynamoDBEntryType.String),
                new KeyValuePair < string, DynamoDBEntryType >("H5", DynamoDBEntryType.String)
            };

            Assert.ThrowsException<ArgumentException>(() => builder.AddGlobalSecondaryIndex("GSI", hash, null));
        }

        [TestMethod]
        public void AddGlobalSecondaryIndex_Dictionary_RangeKeyCountExceeded_ThrowsArgumentException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");

            var hash = new List<KeyValuePair<string, DynamoDBEntryType>> { new KeyValuePair<string, DynamoDBEntryType>("HashK", DynamoDBEntryType.String) };
            var range = new List<KeyValuePair<string, DynamoDBEntryType>>
            {
                new KeyValuePair < string, DynamoDBEntryType >("R1", DynamoDBEntryType.String),
                new KeyValuePair < string, DynamoDBEntryType >("R2", DynamoDBEntryType.String),
                new KeyValuePair < string, DynamoDBEntryType >("R3", DynamoDBEntryType.String),
                new KeyValuePair < string, DynamoDBEntryType >("R4", DynamoDBEntryType.String),
                new KeyValuePair < string, DynamoDBEntryType >("R5", DynamoDBEntryType.String)
            };

            Assert.ThrowsException<ArgumentException>(() => builder.AddGlobalSecondaryIndex("GSI", hash, range));
        }

        [TestMethod]
        public void AddGlobalSecondaryIndex_Dictionary_DuplicateName_ThrowsArgumentException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");

            var hashA = new List<KeyValuePair<string, DynamoDBEntryType>> { new KeyValuePair<string, DynamoDBEntryType>("Id", DynamoDBEntryType.String) };
            var rangeA = new List<KeyValuePair<string, DynamoDBEntryType>> { new KeyValuePair<string, DynamoDBEntryType>("Date", DynamoDBEntryType.String) };

            builder.AddGlobalSecondaryIndex("GSI", hashA, rangeA);

            var hashB = new List<KeyValuePair<string, DynamoDBEntryType>> { new KeyValuePair<string, DynamoDBEntryType>("Id", DynamoDBEntryType.String) };

            Assert.ThrowsException<ArgumentException>(() => builder.AddGlobalSecondaryIndex("GSI", hashB, null));
        }

        [TestMethod]
        public void AddGlobalSecondaryIndex_Dictionary_AttributeReuseWithLSI_OnlyStoredOnce()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");
            builder.AddHashKey("Id", DynamoDBEntryType.String);

            // Add GSI via dictionary with two new attributes
            var gsiHash = new List<KeyValuePair<string, DynamoDBEntryType>> { new KeyValuePair<string, DynamoDBEntryType>("Date", DynamoDBEntryType.String) };
            builder.AddGlobalSecondaryIndex("GSI", gsiHash, null);

            // Add a LSI that reuses OrderNumber
            builder.AddLocalSecondaryIndex("LSI", "OrderNumber", DynamoDBEntryType.Numeric);

            var table = builder.Build();

            Assert.AreEqual(3, table.Attributes.Count);
        }

        [TestMethod]
        public void AddGlobalSecondaryIndex_Dictionary_AttributesReusedAcrossGSIs_OnlyStoredOnce()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");
            builder.AddHashKey("Id", DynamoDBEntryType.String);
            builder.AddRangeKey("Date", DynamoDBEntryType.String);

            // GSI-1 uses Date (already used as table range key)
            var gsi1 = new List<KeyValuePair<string, DynamoDBEntryType>> { new KeyValuePair<string, DynamoDBEntryType>("Date", DynamoDBEntryType.String) };
            builder.AddGlobalSecondaryIndex("GSI-1", gsi1, null);

            // GSI-2 uses Date and Id (both already known)
            var gsi2Hash = new List<KeyValuePair<string, DynamoDBEntryType>> { new KeyValuePair<string, DynamoDBEntryType>("Date", DynamoDBEntryType.String) };
            var gsi2Range = new List<KeyValuePair<string, DynamoDBEntryType>> { new KeyValuePair<string, DynamoDBEntryType>("Id", DynamoDBEntryType.String) };
            builder.AddGlobalSecondaryIndex("GSI-2", gsi2Hash, gsi2Range);

            var table = builder.Build();

            Assert.AreEqual(2, table.Attributes.Count);
        }

        [TestMethod]
        public void AddGlobalSecondaryIndex_DuplicateHashKey_ThrowsArgumentException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");
            
            var hash = new List<KeyValuePair<string, DynamoDBEntryType>> 
            { 
                new KeyValuePair<string, DynamoDBEntryType>("Id", DynamoDBEntryType.String),
                new KeyValuePair<string, DynamoDBEntryType>("Id", DynamoDBEntryType.String)
            };

            Assert.ThrowsException<ArgumentException>(() => builder.AddGlobalSecondaryIndex("GSI", hash, null));
        }

        [TestMethod]
        public void AddGlobalSecondaryIndex_DuplicateRangeKey_ThrowsArgumentException()
        {
            var builder = new TableBuilder(_amazonDynamoDBClient, "TestTable");
            
            var hash = new List<KeyValuePair<string, DynamoDBEntryType>> { new KeyValuePair<string, DynamoDBEntryType>("Id", DynamoDBEntryType.String) };
            var range = new List<KeyValuePair<string, DynamoDBEntryType>> 
            { 
                new KeyValuePair<string, DynamoDBEntryType>("Date", DynamoDBEntryType.String),
                new KeyValuePair<string, DynamoDBEntryType>("Date", DynamoDBEntryType.String)
            };

            Assert.ThrowsException<ArgumentException>(() => builder.AddGlobalSecondaryIndex("GSI", hash, range));
        }


    }
}
