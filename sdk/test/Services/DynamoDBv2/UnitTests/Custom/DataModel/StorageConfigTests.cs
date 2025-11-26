using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.DynamoDBv2.DataModel;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class StorageConfigTests
    {
        // Small sample type used for reflection/MemberInfo
        private class SampleType
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private class EmptyType
        {
            // intentionally no public members to trigger the "no supported members" behavior
        }

        [TestMethod]
        public void Constructor_ThrowsWhenTypeHasNoSupportedMembers()
        {
            // StorageConfig should throw when target type has no supported members
            Assert.ThrowsException<InvalidOperationException>(() => new StorageConfig(typeof(EmptyType)));
        }

        [TestMethod]
        public void AddPropertyStorage_ThrowsWhenDuplicateAttributeNamesAdded()
        {
            var config = new StorageConfig(typeof(SampleType));

            var prop1 = new PropertyStorage(typeof(SampleType).GetProperty(nameof(SampleType.Id)))
            {
                AttributeName = "Attr"
            };
            prop1.IndexNames ??= new List<string>();
            prop1.FlattenProperties ??= new List<PropertyStorage>();

            var prop2 = new PropertyStorage(typeof(SampleType).GetProperty(nameof(SampleType.Name)))
            {
                AttributeName = "Attr" // same attribute name as prop1 -> should cause error
            };
            prop2.IndexNames ??= new List<string>();
            prop2.FlattenProperties ??= new List<PropertyStorage>();

            // first add should succeed
            config.AddPropertyStorage("Id", prop1);

            // second add with same attribute name should throw
            Assert.ThrowsException<InvalidOperationException>(() => config.AddPropertyStorage("Name", prop2));
        }

        [TestMethod]
        public void GetPropertyStorage_ReturnsAddedProperty_AndThrowsWhenMissing()
        {
            var config = new StorageConfig(typeof(SampleType));

            var prop = new PropertyStorage(typeof(SampleType).GetProperty(nameof(SampleType.Id)))
            {
                AttributeName = "Id"
            };
            prop.IndexNames ??= new List<string>();
            prop.FlattenProperties ??= new List<PropertyStorage>();

            config.AddPropertyStorage("Id", prop);

            var retrieved = config.GetPropertyStorage("Id");
            Assert.AreSame(prop, retrieved);

            // missing property should throw
            Assert.ThrowsException<InvalidOperationException>(() => config.GetPropertyStorage("DoesNotExist"));
        }

        [TestMethod]
        public void FindSinglePropertyByAttributeName_IgnoresIgnoredAndThrowsOnMultiple()
        {
            var config = new StorageConfig(typeof(SampleType));

            var p1 = new PropertyStorage(typeof(SampleType).GetProperty(nameof(SampleType.Id)))
            {
                AttributeName = "DupAttr",
                IsIgnored = true
            };
            p1.IndexNames ??= new List<string>();
            p1.FlattenProperties ??= new List<PropertyStorage>();

            var p2 = new PropertyStorage(typeof(SampleType).GetProperty(nameof(SampleType.Name)))
            {
                AttributeName = "DupAttr",
                IsIgnored = false
            };
            p2.IndexNames ??= new List<string>();
            p2.FlattenProperties ??= new List<PropertyStorage>();

            // Add both to Properties list. AddPropertyStorage isn't used here because we want to test FindSingleProperty behavior.
            config.Properties.Add(p1);
            config.Properties.Add(p2);

            // Should find the non-ignored property
            PropertyStorage found;
            bool exists = config.FindSinglePropertyByAttributeName("DupAttr", out found);
            Assert.IsTrue(exists);
            Assert.AreSame(p2, found);

            // Now add another non-ignored property with same attribute to force multiple-match error
            var p3 = new PropertyStorage(typeof(SampleType).GetProperty(nameof(SampleType.Id)))
            {
                AttributeName = "DupAttr",
                IsIgnored = false
            };
            p3.IndexNames ??= new List<string>();
            p3.FlattenProperties ??= new List<PropertyStorage>();

            config.Properties.Add(p3);

            Assert.ThrowsException<InvalidOperationException>(() => config.FindSinglePropertyByAttributeName("DupAttr", out found));
        }
    }
}