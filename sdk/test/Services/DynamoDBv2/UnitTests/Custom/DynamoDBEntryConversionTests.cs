using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests
{
    [TestClass]
    public class DynamoDBEntryConversionTests
    {
        [TestMethod]
        public void ValidateAllConvertersAreRegisteredForConversionV1()
        {
            AssertAllConvertersAreRegistered(DynamoDBEntryConversion.V1, "ConverterV1");
        }

        [TestMethod]
        public void ValidateAllConvertersAreRegisteredForConversionV2()
        {
            AssertAllConvertersAreRegistered(DynamoDBEntryConversion.V2, "ConverterV2");
        }

        private void AssertAllConvertersAreRegistered(DynamoDBEntryConversion conversion, string suffix)
        {
            var converters = GetConverters(suffix);

            foreach (var converter in converters)
            {
                conversion.IsConverterRegistered(converter);
            }
        }

        private IEnumerable<Type> GetConverters(string suffix)
        {
            var typedConverterType = typeof(Converter);
            var assembly = typeof(DynamoDBEntryConversion).Assembly;

            var allTypes = assembly.GetTypes();

            foreach (var type in allTypes)
            {
                if (type.IsAbstract)
                    continue;

                if (!type.Name.EndsWith(suffix, StringComparison.Ordinal))
                    continue;

                if (!typedConverterType.IsAssignableFrom(type))
                    continue;

                yield return type;
            }
        }
    }
}
