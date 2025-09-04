﻿using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class PropertyStorageTests
    {
        private class TestClass
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int? Counter { get; set; }
            public int? Version { get; set; }
            public DateTime? Timestamp { get; set; }
        }

        private PropertyStorage CreatePropertyStorage(string propertyName = "Id")
        {
            var member = typeof(TestClass).GetProperty(propertyName);
            return new PropertyStorage(member);
        }

        private class DummyContext : DynamoDBContext
        {

            public DummyContext(IAmazonDynamoDB client) : base(client, false, null)
            {
            }

        }

        private class FakePropertyConverter : IPropertyConverter
        {
            public object FromEntry(DynamoDBEntry entry) => null;
            public DynamoDBEntry ToEntry(object value) => null;
        }


        [TestMethod]
        public void AddIndex_AddsIndexToIndexesList()
        {
            var storage = CreatePropertyStorage();
            var gsi = new PropertyStorage.GSI(true, "Attr", "Index1");
            storage.AddIndex(gsi);

            Assert.AreEqual(1, storage.Indexes.Count);
            Assert.AreSame(gsi, storage.Indexes[0]);
        }

        [TestMethod]
        public void AddGsiIndex_AddsGSIIndex()
        {
            var storage = CreatePropertyStorage();
            storage.AddGsiIndex(true, "Attr", "Index1", "Index2");

            Assert.AreEqual(1, storage.Indexes.Count);
            var gsi = storage.Indexes[0] as PropertyStorage.GSI;
            Assert.IsNotNull(gsi);
            Assert.IsTrue(gsi.IsHashKey);
            CollectionAssert.AreEquivalent(new List<string> { "Index1", "Index2" }, gsi.IndexNames);
        }

        [TestMethod]
        public void AddLsiIndex_AddsLSIIndex()
        {
            var storage = CreatePropertyStorage();
            storage.AddLsiIndex("Attr", "Index1");

            Assert.AreEqual(1, storage.Indexes.Count);
            var lsi = storage.Indexes[0] as PropertyStorage.LSI;
            Assert.IsNotNull(lsi);
            Assert.AreEqual("Attr", lsi.AttributeName);
            CollectionAssert.AreEquivalent(new List<string> { "Index1" }, lsi.IndexNames);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Validate_ThrowsIfBothHashAndRangeKey()
        {
            var storage = CreatePropertyStorage("Name");
            storage.IsHashKey = true;
            storage.IsRangeKey = true;
            storage.IndexNames = new List<string>();
            storage.FlattenProperties = new List<PropertyStorage>();

            storage.Validate(null);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Validate_ThrowsIfStoreAsEpochAndStoreAsEpochLong()
        {
            var storage = CreatePropertyStorage("Timestamp");
            storage.StoreAsEpoch = true;
            storage.StoreAsEpochLong = true;
            storage.IndexNames = new List<string>();
            storage.FlattenProperties = new List<PropertyStorage>();

            storage.Validate(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Validate_ThrowsIfConverterTypeAndPolymorphicProperty()
        {
            var storage = CreatePropertyStorage("Name");
            storage.ConverterType = typeof(object); // Not a real converter, but triggers the check
            storage.PolymorphicProperty = true;
            storage.IndexNames = new List<string>();
            storage.FlattenProperties = new List<PropertyStorage>();

            storage.Validate(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Validate_ThrowsIfConverterTypeAndShouldFlattenChildProperties()
        {
            var storage = CreatePropertyStorage("Name");
            storage.ConverterType = typeof(object);
            storage.ShouldFlattenChildProperties = true;
            storage.IndexNames = new List<string>();
            storage.FlattenProperties = new List<PropertyStorage>();

            storage.Validate(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Validate_ThrowsIfConverterTypeAndStoreAsEpoch()
        {
            var storage = CreatePropertyStorage("Timestamp");
            storage.ConverterType = typeof(object);
            storage.StoreAsEpoch = true;
            storage.IndexNames = new List<string>();
            storage.FlattenProperties = new List<PropertyStorage>();

            storage.Validate(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Validate_ThrowsIfConverterTypeAndIsAutoGeneratedTimestamp()
        {
            var storage = CreatePropertyStorage("Timestamp");
            storage.ConverterType = typeof(object);
            storage.IsAutoGeneratedTimestamp = true;
            storage.IndexNames = new List<string>();
            storage.FlattenProperties = new List<PropertyStorage>();

            storage.Validate(null);
        }
        [TestMethod]
        public void Validate_AllowsIsVersionOnNumericType()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var context = new DummyContext(mockClient.Object);

            var storage = CreatePropertyStorage("Version");
            storage.IsVersion = true;
            storage.IndexNames = new List<string>();
            storage.FlattenProperties = new List<PropertyStorage>();

            // Should not throw for int property
            storage.Validate(context);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Validate_ThrowsIsVersionOnNonNumericType()
        {
            var storage = CreatePropertyStorage("Name");
            storage.IsVersion = true;
            storage.IndexNames = new List<string>();
            storage.FlattenProperties = new List<PropertyStorage>();

            // Should throw for string property
            storage.Validate(null);
        }

        [TestMethod]
        public void Validate_AllowsIsCounterOnNumericType()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var context = new DummyContext(mockClient.Object);

            var storage = CreatePropertyStorage("Counter");
            storage.IsCounter = true;
            storage.IndexNames = new List<string>();
            storage.FlattenProperties = new List<PropertyStorage>();

            // Should not throw for int property
            storage.Validate(context);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Validate_ThrowsIsCounterOnNonNumericType()
        {
            var storage = CreatePropertyStorage("Name");
            storage.IsCounter = true;
            storage.IndexNames = new List<string>();
            storage.FlattenProperties = new List<PropertyStorage>();

            // Should throw for string property
            storage.Validate(null);
        }


        [TestMethod]
        public void Validate_AllowsIsAutoGeneratedTimestampOnDateTime()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var context = new DummyContext(mockClient.Object);

            var storage = CreatePropertyStorage("Timestamp");
            storage.IsAutoGeneratedTimestamp = true;
            storage.IndexNames = new List<string>();
            storage.FlattenProperties = new List<PropertyStorage>();

            // Should not throw for DateTime property
            storage.Validate(context);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Validate_ThrowsIsAutoGeneratedTimestampOnNonDateTime()
        {
            var storage = CreatePropertyStorage("Id");
            storage.IsAutoGeneratedTimestamp = true;
            storage.IndexNames = new List<string>();
            storage.FlattenProperties = new List<PropertyStorage>();

            // Should throw for int property
            storage.Validate(null);
        }

        [TestMethod]
        public void Validate_UsesConverterFromContextCache()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var context = new DummyContext(mockClient.Object);

            var storage = CreatePropertyStorage("Id");
            storage.IndexNames = new List<string>();
            storage.FlattenProperties = new List<PropertyStorage>();

            var fakeConverter = new FakePropertyConverter();
            context.ConverterCache[typeof(int)] = fakeConverter;

            storage.Validate(context);

            Assert.AreSame(fakeConverter, storage.Converter);
        }

        [TestMethod]
        public void Validate_PopulatesIndexNamesFromIndexes()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var context = new DummyContext(mockClient.Object);

            var storage = CreatePropertyStorage("Id");
            storage.IndexNames = new List<string>();
            storage.FlattenProperties = new List<PropertyStorage>();
            storage.AddGsiIndex(true, "Attr", "IndexA", "IndexB");

            storage.Validate(context);

            CollectionAssert.Contains(storage.IndexNames, "IndexA");
            CollectionAssert.Contains(storage.IndexNames, "IndexB");
        }
    }
}