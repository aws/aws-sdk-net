using Amazon.DynamoDBv2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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

            var tryGetConverterInfo = conversion.GetType().GetMethod("TryGetConverter", BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var converter in converters)
            {
                var getTargetTypeInfo = converter.GetType().GetMethod("GetTargetTypes");
                IEnumerable<Type> targetTypes = (IEnumerable<Type>)getTargetTypeInfo.Invoke(converter, new object[0]);
                foreach (var type in targetTypes)
                {
                    var tryGetConverterParams = new object[] { type, null };
                    tryGetConverterInfo.Invoke(conversion, tryGetConverterParams);
                    var registeredConverter = tryGetConverterParams[1];

                    Assert.IsNotNull(registeredConverter);
                    Assert.AreEqual(converter.GetType(), registeredConverter.GetType());
                }
            }
        }

        private IEnumerable<object> GetConverters(string suffix)
        {
            const string converterTypeName = "Amazon.DynamoDBv2.Converter";
            var assembly = typeof(DynamoDBEntryConversion).Assembly;

            var allTypes = assembly.GetTypes();
            var typedConverterType = allTypes.FirstOrDefault(x => string.Equals(converterTypeName, x.FullName));

            foreach (var type in allTypes)
            {
                if (type.IsAbstract)
                    continue;

                if (!type.Name.EndsWith(suffix, StringComparison.Ordinal))
                    continue;

                if (!typedConverterType.IsAssignableFrom(type))
                    continue;

                var constructor = type.GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[0], null);
                yield return constructor.Invoke(new object[0]);
            }
        }
    }
}