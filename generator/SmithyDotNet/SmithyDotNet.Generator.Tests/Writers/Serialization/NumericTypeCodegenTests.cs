using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Serialization;
using SmithyDotNet.Generator.Writers.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

/// <summary>
/// The byte, short, bigInteger and bigDecimal shapes from the Full Numeric Type Support SEP, in body, collection,
/// query, header and label positions on restJson1.
/// </summary>
public class NumericTypeCodegenTests
{
    private const string ModelFileName = "numeric-types-model.json";

    private readonly string _requestMarshaller;
    private readonly string _responseUnmarshaller;
    private readonly string _requestStructure;

    public NumericTypeCodegenTests()
    {
        var context = TestModels.Context("Codegen/numeric-types-model.json");
        var operation = context.Operations.Single(o => o.Name == "DoNumbers");
        _requestMarshaller = new JsonRequestMarshallerWriter(context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);
        _responseUnmarshaller = new JsonResponseUnmarshallerWriter(context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);
        _requestStructure = new StructureWriter(context, ModelFileName)
            .Write(context.Structures[ShapeId.Parse("com.example.numerics#DoNumbersRequest")], TestContext.Current.CancellationToken);
    }

    [Fact]
    public void Structure_MapsSignedByteAndArbitraryPrecisionTypes()
    {
        Assert.Contains("public sbyte? ByteValue", _requestStructure);
        Assert.Contains("public short? ShortValue", _requestStructure);
        Assert.Contains("public System.Numerics.BigInteger? BigIntegerValue", _requestStructure);
        Assert.Contains("public Amazon.Extensions.Numerics.BigDecimal? BigDecimalValue", _requestStructure);
        Assert.Contains("List<Amazon.Extensions.Numerics.BigDecimal>", _requestStructure);
    }

    [Fact]
    public void RequestMarshaller_Body_WritesNumbersWithoutLosingDigits()
    {
        // byte and short are plain JSON numbers; bigInteger and bigDecimal have no Utf8JsonWriter overload and
        // go through the runtime helper, which writes every digit.
        Assert.Contains("context.Writer.WriteNumberValue(publicRequest.ByteValue.Value);", _requestMarshaller);
        Assert.Contains("context.Writer.WriteNumberValue(publicRequest.ShortValue.Value);", _requestMarshaller);
        Assert.Contains("StringUtils.WriteBigIntegerValue(context.Writer, publicRequest.BigIntegerValue.Value);", _requestMarshaller);
        Assert.Contains("StringUtils.WriteBigDecimalValue(context.Writer, publicRequest.BigDecimalValue.Value);", _requestMarshaller);
        Assert.Contains("StringUtils.WriteBigDecimalValue(context.Writer, publicRequestBigDecimalListListValue);", _requestMarshaller);
        Assert.Contains("StringUtils.WriteBigIntegerValue(context.Writer, publicRequestBigIntegerMapValue);", _requestMarshaller);
        Assert.Contains("context.Writer.WriteNumberValue(publicRequestShortMapValue);", _requestMarshaller);
        Assert.Contains("StringUtils.WriteBigIntegerValue(context.Writer, publicRequestSparseBigIntegerListListValue.Value);", _requestMarshaller);
    }

    [Fact]
    public void RequestMarshaller_HttpBindings_UseInvariantStringConversions()
    {
        Assert.Contains("""request.Parameters.Add("byte", StringUtils.FromSByte(publicRequest.QueryByte.Value));""", _requestMarshaller);
        Assert.Contains("""request.ParameterCollection.Add("bigDecimals", publicRequest.QueryBigDecimalList.ConvertAll<string>(item => StringUtils.FromBigDecimal(item)));""", _requestMarshaller);
        Assert.Contains("""request.Headers["x-big-integer"] = StringUtils.FromBigInteger(publicRequest.HeaderBigInteger.Value);""", _requestMarshaller);
        Assert.Contains("""request.Headers["x-shorts"] = StringUtils.FromValueTypeList(publicRequest.HeaderShortList, StringUtils.FromShort);""", _requestMarshaller);
        Assert.Contains("""request.AddPathResource("{labelShort}", StringUtils.FromShort(publicRequest.LabelShort.Value));""", _requestMarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_Body_UsesNumericUnmarshallers()
    {
        Assert.Contains("var unmarshaller = NullableSByteUnmarshaller.Instance;", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = NullableShortUnmarshaller.Instance;", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = NullableBigIntegerUnmarshaller.Instance;", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = NullableBigDecimalUnmarshaller.Instance;", _responseUnmarshaller);
        Assert.Contains("new JsonListUnmarshaller<Amazon.Extensions.Numerics.BigDecimal, BigDecimalUnmarshaller>(BigDecimalUnmarshaller.Instance)", _responseUnmarshaller);
        Assert.Contains("new JsonDictionaryUnmarshaller<string, sbyte, StringUnmarshaller, SByteUnmarshaller>(StringUnmarshaller.Instance, SByteUnmarshaller.Instance)", _responseUnmarshaller);
        Assert.Contains("new JsonListUnmarshaller<System.Numerics.BigInteger?, NullableBigIntegerUnmarshaller>(NullableBigIntegerUnmarshaller.Instance)", _responseUnmarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_Headers_ParseWithInvariantCulture()
    {
        Assert.Contains("""unmarshalledObject.HeaderByte = sbyte.Parse(context.ResponseData.GetHeaderValue("x-byte"), CultureInfo.InvariantCulture);""", _responseUnmarshaller);
        Assert.Contains("""unmarshalledObject.HeaderBigDecimal = Amazon.Extensions.Numerics.BigDecimal.Parse(context.ResponseData.GetHeaderValue("x-big-decimal"), CultureInfo.InvariantCulture);""", _responseUnmarshaller);
        Assert.Contains("""unmarshalledObject.HeaderBigIntegerList = MultiValueHeaderParser.ToValueTypeList<System.Numerics.BigInteger>(context.ResponseData.GetHeaderValue("x-big-integers"), s => System.Numerics.BigInteger.Parse(s, CultureInfo.InvariantCulture));""", _responseUnmarshaller);
    }
}
