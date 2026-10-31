using Json.LitJson;
using ServiceClientGenerator;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace ServiceClientGeneratorTests
{
    /// <summary>
    /// Tests for the byte, short, bigInteger and bigDecimal shape types from the Full Numeric Type Support specification.
    /// </summary>
    [Trait("Category", "UnitTests")]
    public class NumericTypeGeneratorTests
    {
        private static ServiceModel CreateModel(string protocol)
        {
            var json = @"{
  ""version"": ""2.0"",
  ""metadata"": { ""protocol"": """ + protocol + @""", ""serviceId"": ""Numbers"", ""apiVersion"": ""2026-10-26"", ""endpointPrefix"": ""numbers"" },
  ""operations"": {},
  ""shapes"": {
    ""String"": { ""type"": ""string"" },
    ""Byte"": { ""type"": ""byte"" },
    ""Short"": { ""type"": ""short"" },
    ""BigInteger"": { ""type"": ""bigInteger"" },
    ""BigDecimal"": { ""type"": ""bigDecimal"" },
    ""ShortList"": { ""type"": ""list"", ""member"": { ""shape"": ""Short"" } },
    ""BigDecimalMap"": { ""type"": ""map"", ""key"": { ""shape"": ""String"" }, ""value"": { ""shape"": ""BigDecimal"" } },
    ""Numbers"": {
      ""type"": ""structure"",
      ""members"": {
        ""ByteValue"": { ""shape"": ""Byte"" },
        ""ShortValue"": { ""shape"": ""Short"" },
        ""BigIntegerValue"": { ""shape"": ""BigInteger"" },
        ""BigDecimalValue"": { ""shape"": ""BigDecimal"" },
        ""ShortList"": { ""shape"": ""ShortList"" },
        ""BigDecimalMap"": { ""shape"": ""BigDecimalMap"" }
      }
    }
  }
}";
            return new ServiceModel(new StringReader(json), null);
        }

        private static Member GetMember(ServiceModel model, string name)
        {
            return model.FindShape("Numbers").Members.Single(m => m.ModeledName == name);
        }

        [Theory]
        [InlineData("ByteValue", "sbyte?", "NullableSByteUnmarshaller.Instance", "StringUtils.FromSByte")]
        [InlineData("ShortValue", "short?", "NullableShortUnmarshaller.Instance", "StringUtils.FromShort")]
        [InlineData("BigIntegerValue", "System.Numerics.BigInteger?", "NullableBigIntegerUnmarshaller.Instance", "StringUtils.FromBigInteger")]
        [InlineData("BigDecimalValue", "Amazon.Extensions.Numerics.BigDecimal?", "NullableBigDecimalUnmarshaller.Instance", "StringUtils.FromBigDecimal")]
        public void ScalarMembers(string memberName, string expectedType, string expectedUnmarshaller, string expectedMarshaller)
        {
            var member = GetMember(CreateModel("json"), memberName);

            Assert.Equal(expectedType, member.DetermineType());
            Assert.Equal(expectedUnmarshaller, member.DetermineTypeUnmarshallerInstantiate());
            Assert.Equal(expectedMarshaller, member.PrimitiveMarshaller);
            Assert.True(member.IsNullable);
            Assert.True(member.Shape.IsExtendedNumericType);
        }

        [Theory]
        [InlineData("json", "new JsonListUnmarshaller<short, ShortUnmarshaller>(ShortUnmarshaller.Instance)")]
        [InlineData("rest-xml", "ShortUnmarshaller.Instance")]
        public void ListMember(string protocol, string expectedUnmarshaller)
        {
            var member = GetMember(CreateModel(protocol), "ShortList");

            Assert.Equal("List<short>", member.DetermineType());
            Assert.Equal(expectedUnmarshaller, member.DetermineTypeUnmarshallerInstantiate());
        }

        [Fact]
        public void MapMember()
        {
            var member = GetMember(CreateModel("json"), "BigDecimalMap");

            Assert.Equal("Dictionary<string, Amazon.Extensions.Numerics.BigDecimal>", member.DetermineType());
            Assert.Equal(
                "new JsonDictionaryUnmarshaller<string, Amazon.Extensions.Numerics.BigDecimal, StringUnmarshaller, BigDecimalUnmarshaller>(StringUnmarshaller.Instance, BigDecimalUnmarshaller.Instance)",
                member.DetermineTypeUnmarshallerInstantiate());
        }

        [Theory]
        [InlineData("ByteValue", "sbyte", "sbyte", false)]
        [InlineData("ShortValue", "short", "short", false)]
        [InlineData("BigIntegerValue", "System.Numerics.BigInteger", "System.Numerics.BigInteger", true)]
        [InlineData("BigDecimalValue", "Amazon.Extensions.Numerics.BigDecimal", "Amazon.Extensions.Numerics.BigDecimal", true)]
        public void ShapeHelpers(string memberName, string expectedCSharpType, string expectedParseType, bool arbitraryPrecision)
        {
            var shape = GetMember(CreateModel("rest-json"), memberName).Shape;

            Assert.Equal(expectedCSharpType, shape.PrimitiveCSharpTypeName);
            Assert.Equal(expectedParseType, shape.PrimitiveParseTypeName);
            Assert.Equal(expectedCSharpType, shape.QueryMapValueTypeName);
            Assert.Equal(arbitraryPrecision, shape.IsArbitraryPrecisionNumber);
            Assert.Equal($", s => {expectedParseType}.Parse(s, CultureInfo.InvariantCulture)", shape.HeaderListParseArgument);
            Assert.Equal($", StringUtils.From{shape.GetPrimitiveType()}", shape.HeaderListFormatArgument);
        }

        [Fact]
        public void ArbitraryPrecisionJsonWriteStatement()
        {
            var shape = GetMember(CreateModel("json"), "BigDecimalValue").Shape;
            Assert.Equal("StringUtils.WriteBigDecimalValue(context.Writer, x.Value);", shape.ArbitraryPrecisionJsonWriteStatement("x.Value"));
        }

        [Fact]
        public void ExistingTypesKeepTheirGeneratedNames()
        {
            // The helpers added for the new numeric types must not change what is generated for existing types.
            var model = CreateModel("rest-json");
            var stringShape = model.FindShape("String");
            Assert.Equal("string", stringShape.PrimitiveParseTypeName);
            Assert.Equal("String", stringShape.QueryMapValueTypeName);
            Assert.Equal(string.Empty, stringShape.HeaderListParseArgument);
            Assert.Equal(string.Empty, stringShape.HeaderListFormatArgument);
            Assert.False(stringShape.IsExtendedNumericType);
        }

        [Theory]
        [InlineData("ByteValue", 5, "5")]
        [InlineData("ShortValue", -300, "-300")]
        [InlineData("BigIntegerValue", 12345678901234L, "System.Numerics.BigInteger.Parse(\"12345678901234\", System.Globalization.CultureInfo.InvariantCulture)")]
        [InlineData("BigDecimalValue", 1.5, "Amazon.Extensions.Numerics.BigDecimal.Parse(\"1.5\", System.Globalization.CultureInfo.InvariantCulture)")]
        public void ExampleLiterals(string memberName, object value, string expected)
        {
            var model = CreateModel("json");
            var shape = GetMember(model, memberName).Shape;
            var sb = new StringBuilder();
            var example = new Example(model, "fake", null);

            var originalCulture = CultureInfo.CurrentCulture;
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR");
            try
            {
                example.GetSampleLiteral(shape, new JsonData(value), new CodeBuilder(sb, 0));
            }
            finally
            {
                CultureInfo.CurrentCulture = originalCulture;
            }

            Assert.Equal(expected, sb.ToString());
        }
    }
}
