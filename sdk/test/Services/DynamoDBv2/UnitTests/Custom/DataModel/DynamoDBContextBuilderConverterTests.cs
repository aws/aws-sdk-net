using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace AWSSDK_DotNet.UnitTests
{
    /// <summary>
    /// Tests for <see cref="IDynamoDBContextBuilder.AddDefaultConverter(Type, IPropertyConverter)"/> and its
    /// generic overload, which register an <see cref="IPropertyConverter"/> that is applied by default to every
    /// property of a given .NET type on the constructed <see cref="DynamoDBContext"/>.
    /// </summary>
    [TestClass]
    public class DynamoDBContextBuilderConverterTests
    {
        private sealed class CustomType
        {
            public string Value { get; set; }
        }

        private sealed class AnotherCustomType
        {
            public string Value { get; set; }
        }

        private sealed class CustomTypeConverter : IPropertyConverter
        {
            public DynamoDBEntry ToEntry(object value) => new Primitive(((CustomType)value)?.Value);
            public object FromEntry(DynamoDBEntry entry) => new CustomType { Value = entry?.AsString() };
        }

        private sealed class ModelWithCustomType
        {
            public string Id { get; set; }
            public CustomType Custom { get; set; }
        }

        private static IDynamoDBContextBuilder CreateBuilder()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            return new DynamoDBContextBuilder().WithDynamoDBClient(() => mockClient.Object);
        }

        [TestMethod]
        public void AddDefaultConverter_ByType_SeedsConverterCache()
        {
            var converter = new CustomTypeConverter();

            using var context = CreateBuilder()
                .AddDefaultConverter(typeof(CustomType), converter)
                .Build();

            Assert.IsTrue(context.ConverterCache.TryGetValue(typeof(CustomType), out var registered));
            Assert.AreSame(converter, registered);
        }

        [TestMethod]
        public void AddDefaultConverter_Generic_SeedsConverterCache()
        {
            var converter = new CustomTypeConverter();

            using var context = CreateBuilder()
                .AddDefaultConverter<CustomType>(converter)
                .Build();

            Assert.IsTrue(context.ConverterCache.TryGetValue(typeof(CustomType), out var registered));
            Assert.AreSame(converter, registered);
        }

        [TestMethod]
        public void AddDefaultConverter_ReturnsSameBuilderForChaining()
        {
            var builder = CreateBuilder();

            var returned = builder.AddDefaultConverter<CustomType>(new CustomTypeConverter());

            Assert.AreSame(builder, returned);
        }

        [TestMethod]
        public void AddDefaultConverter_PreservesBuiltInS3LinkConverter()
        {
            using var context = CreateBuilder()
                .AddDefaultConverter<CustomType>(new CustomTypeConverter())
                .Build();

            // The built-in S3Link default converter must still be present alongside the custom registration.
            Assert.IsTrue(context.ConverterCache.ContainsKey(typeof(S3Link)));
            Assert.IsTrue(context.ConverterCache.ContainsKey(typeof(CustomType)));
        }

        [TestMethod]
        public void AddDefaultConverter_DuplicateType_Throws()
        {
            var builder = CreateBuilder()
                .AddDefaultConverter(typeof(CustomType), new CustomTypeConverter());

            Assert.ThrowsExactly<InvalidOperationException>(
                () => builder.AddDefaultConverter(typeof(CustomType), new CustomTypeConverter()));
        }

        [TestMethod]
        public void AddDefaultConverter_DuplicateTypeAcrossGenericAndNonGeneric_Throws()
        {
            var builder = CreateBuilder()
                .AddDefaultConverter<CustomType>(new CustomTypeConverter());

            Assert.ThrowsExactly<InvalidOperationException>(
                () => builder.AddDefaultConverter(typeof(CustomType), new CustomTypeConverter()));
        }

        [TestMethod]
        public void AddDefaultConverter_NullType_Throws()
        {
            var builder = CreateBuilder();

            Assert.ThrowsExactly<ArgumentNullException>(
                () => builder.AddDefaultConverter(null, new CustomTypeConverter()));
        }

        [TestMethod]
        public void AddDefaultConverter_NullConverter_Throws()
        {
            var builder = CreateBuilder();

            Assert.ThrowsExactly<ArgumentNullException>(
                () => builder.AddDefaultConverter(typeof(CustomType), null));
        }

        [TestMethod]
        public void AddDefaultConverter_DifferentTypes_AreIndependentlyRegistered()
        {
            var first = new CustomTypeConverter();

            using var context = CreateBuilder()
                .AddDefaultConverter<CustomType>(first)
                .Build();

            Assert.IsTrue(context.ConverterCache.ContainsKey(typeof(CustomType)));
            Assert.IsFalse(context.ConverterCache.ContainsKey(typeof(AnotherCustomType)));
        }

        [TestMethod]
        public void AddDefaultConverter_AppliesConverterToPropertyOfRegisteredType()
        {
            var converter = new CustomTypeConverter();

            using var context = CreateBuilder()
                .AddDefaultConverter<CustomType>(converter)
                .Build();

            // Verify the seeded converter is resolved for a property whose .NET type matches the registration,
            // without any per-property [DynamoDBProperty(Converter=...)] declaration.
            var member = typeof(ModelWithCustomType).GetProperty(nameof(ModelWithCustomType.Custom));
            var storage = new PropertyStorage(member)
            {
                IndexNames = new List<string>(),
                FlattenProperties = new List<PropertyStorage>()
            };

            storage.Validate(context);

            Assert.AreSame(converter, storage.Converter);
        }
    }
}
