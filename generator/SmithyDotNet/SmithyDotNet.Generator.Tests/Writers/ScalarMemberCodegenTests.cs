using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

/// <summary>
/// Drives the JSON marshaller/unmarshaller writers against the shared codegen model, whose
/// DoScalars operation covers the supported scalars (bool/int/long/float/double/timestamp) in body, query,
/// header, and label positions. Complements <see cref="TypeMapperTests"/> (type mapping) by
/// asserting the generated marshalling code for each scalar.
/// </summary>
public class ScalarMemberCodegenTests
{
    private const string ModelFileName = "scalars.json";
    private const string Namespace = "com.example";

    private readonly GenerationContext _context;
    private readonly string _requestMarshaller;
    private readonly string _responseUnmarshaller;
    private readonly string _structureUnmarshaller;
    private readonly string _structureMarshaller;
    private readonly string _requestStructure;

    public ScalarMemberCodegenTests()
    {
        // DoScalars' input has a body member per scalar type, plus httpQuery(count), httpHeader(ratio),
        // and httpLabel(id) scalars; output scalars are carried on the response and on a nested
        // structure (Nested) so both the response unmarshaller and the structure unmarshaller see them.
        _context = TestModels.Context("Codegen/codegen-model.json");

        var operation = _context.Operations.Single(o => o.Name == "DoScalars");
        _requestMarshaller = new JsonRequestMarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);
        _responseUnmarshaller = new JsonResponseUnmarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);

        var nestedId = ShapeId.Parse($"{Namespace}#Nested");
        _structureUnmarshaller = new JsonStructureUnmarshallerWriter(_context, ModelFileName)
            .Write(_context.Structures[nestedId], nestedId, TestContext.Current.CancellationToken);

        var detailId = ShapeId.Parse($"{Namespace}#Detail");
        _structureMarshaller = new JsonStructureMarshallerWriter(_context, ModelFileName)
            .Write(_context.Structures[detailId], detailId, TestContext.Current.CancellationToken);

        var requestId = ShapeId.Parse($"{Namespace}#DoScalarsRequest");
        _requestStructure = new StructureWriter(_context, ModelFileName)
            .Write(_context.Structures[requestId], requestId, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void RequestMarshaller_BodyScalars_WriteGuardedScalarValues()
    {
        // Each body scalar is guarded by IsSet, then written with the matching Utf8JsonWriter call:
        // bool -> WriteBooleanValue, int/long -> WriteNumberValue, timestamp -> epoch seconds.
        Assert.Contains("if (publicRequest.IsSetFlag())", _requestMarshaller);
        Assert.Contains("""context.Writer.WritePropertyName("created");""", _requestMarshaller);
        Assert.Contains("context.Writer.WriteBooleanValue(publicRequest.Flag.Value);", _requestMarshaller);
        Assert.Contains("context.Writer.WriteNumberValue(publicRequest.Size.Value);", _requestMarshaller);
        Assert.Contains("context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.Created.Value)));", _requestMarshaller);

        // float/double branch through IsSpecial*Value: WriteNumberValue rejects NaN/±Infinity, which
        // JSON protocols send as strings.
        Assert.Contains("if (StringUtils.IsSpecialFloatValue(publicRequest.Fraction.Value))", _requestMarshaller);
        Assert.Contains("context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(publicRequest.Fraction.Value));", _requestMarshaller);
        Assert.Contains("context.Writer.WriteNumberValue(publicRequest.Amount.Value);", _requestMarshaller);
    }

    [Fact]
    public void RequestMarshaller_TimestampFormat_ResolvesPerBindingAndOverride()
    {
        // Body defaults to epoch seconds; member and target @timestampFormat override it.
        Assert.Contains("context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.Created.Value)));", _requestMarshaller);
        Assert.Contains("context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.Expiry));", _requestMarshaller);   // member @date-time
        Assert.Contains("context.Writer.WriteStringValue(StringUtils.FromDateTimeToRFC822(publicRequest.SealedAt));", _requestMarshaller);              // target @http-date

        // Header defaults to http-date, query/label to date-time; explicit formats override each.
        Assert.Contains("""request.Headers["x-stamp"] = StringUtils.FromDateTimeToRFC822(publicRequest.Stamp);""", _requestMarshaller);
        Assert.Contains("""request.Headers["x-until"] = StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.Until);""", _requestMarshaller);    // header @date-time
        Assert.Contains("""request.AddPathResource("{when}", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.When));""", _requestMarshaller);
        Assert.Contains("""request.Parameters.Add("since", StringUtils.FromDateTimeToUnixTimestamp(publicRequest.Since));""", _requestMarshaller);        // query @epoch-seconds
    }

    [Fact]
    public void RequestMarshaller_HttpBindingScalars_ConvertThroughStringUtils()
    {
        Assert.Contains("""request.Parameters.Add("count", StringUtils.FromInt(publicRequest.Count.Value));""", _requestMarshaller);
        Assert.Contains("""request.Headers["x-ratio"] = StringUtils.FromDouble(publicRequest.Ratio.Value);""", _requestMarshaller);
        Assert.Contains("""request.AddPathResource("{id}", StringUtils.FromString(publicRequest.Id));""", _requestMarshaller);
        Assert.Contains("""request.AddPathResource("{seq}", StringUtils.FromInt(publicRequest.Seq.Value));""", _requestMarshaller);

        // A required non-string query member is null-checked; IsSet alone would silently omit it.
        Assert.Contains("if (publicRequest.Token == null)", _requestMarshaller);
        Assert.Contains("""throw new AmazonExampleException("Request object does not have required field Token set");""", _requestMarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_Scalars_UseRuntimeUnmarshallers()
    {
        Assert.Contains("var unmarshaller = NullableBoolUnmarshaller.Instance;", _responseUnmarshaller);
        Assert.Contains("response.Enabled = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = NullableLongUnmarshaller.Instance;", _responseUnmarshaller);
        Assert.Contains("var unmarshaller = NullableDateTimeUnmarshaller.Instance;", _responseUnmarshaller);
        Assert.Contains("""if (context.TestExpression("updated", targetDepth, ref reader))""", _responseUnmarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_HeaderScalars_ReadFromResponseHeaders()
    {
        // @httpHeader output members are read from context.ResponseData, guarded by IsHeaderPresent —
        // not from the JSON body. string/enum take the value directly; bool parses without a culture
        // (its literals are culture-invariant); numeric scalars parse with the invariant culture.
        Assert.Contains("""if (context.ResponseData.IsHeaderPresent("x-string"))""", _responseUnmarshaller);
        Assert.Contains("""response.HeaderString = context.ResponseData.GetHeaderValue("x-string");""", _responseUnmarshaller);
        Assert.Contains("""response.HeaderEnum = context.ResponseData.GetHeaderValue("x-enum");""", _responseUnmarshaller);
        Assert.Contains("""response.HeaderBool = bool.Parse(context.ResponseData.GetHeaderValue("x-bool"));""", _responseUnmarshaller);
        Assert.Contains("""response.HeaderInt = int.Parse(context.ResponseData.GetHeaderValue("x-int"), CultureInfo.InvariantCulture);""", _responseUnmarshaller);
        Assert.Contains("""response.HeaderLong = long.Parse(context.ResponseData.GetHeaderValue("x-long"), CultureInfo.InvariantCulture);""", _responseUnmarshaller);
        Assert.Contains("""response.HeaderFloat = float.Parse(context.ResponseData.GetHeaderValue("x-float"), CultureInfo.InvariantCulture);""", _responseUnmarshaller);
        Assert.Contains("""response.HeaderDouble = double.Parse(context.ResponseData.GetHeaderValue("x-double"), CultureInfo.InvariantCulture);""", _responseUnmarshaller);

        // Body members still ride the JSON reader loop, so a mixed response emits both paths.
        Assert.Contains("while (context.ReadAtDepth(targetDepth, ref reader))", _responseUnmarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_HeaderTimestamps_ResolvePerFormatWithHttpDateDefault()
    {
        // Header timestamps default to http-date when unset; date-time and http-date both parse via
        // DateTime.Parse (only epoch-seconds differs).
        Assert.Contains("using System.Globalization;", _responseUnmarshaller);
        Assert.Contains("""response.HeaderHttpDate = DateTime.Parse(context.ResponseData.GetHeaderValue("x-httpdate"), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);""", _responseUnmarshaller);
        Assert.Contains("""response.HeaderDateTime = DateTime.Parse(context.ResponseData.GetHeaderValue("x-datetime"), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);""", _responseUnmarshaller);
        Assert.Contains("""response.HeaderEpoch = Amazon.Util.AWSSDKUtils.ConvertFromUnixEpochSeconds(int.Parse(context.ResponseData.GetHeaderValue("x-epoch"), CultureInfo.InvariantCulture));""", _responseUnmarshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_HeaderOnly_EmitsNoBodyReader()
    {
        var operation = _context.Operations.Single(o => o.Name == "DoHeaderOnly");
        var unmarshaller = new JsonResponseUnmarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);

        Assert.Contains("""if (context.ResponseData.IsHeaderPresent("x-token"))""", unmarshaller);
        Assert.Contains("""response.Token = context.ResponseData.GetHeaderValue("x-token");""", unmarshaller);

        Assert.DoesNotContain("while (context.ReadAtDepth", unmarshaller);
        Assert.DoesNotContain("context.TestExpression(", unmarshaller);
    }

    [Fact]
    public void StructureUnmarshaller_Scalars_UseRuntimeUnmarshallers()
    {
        Assert.Contains("public partial class NestedUnmarshaller", _structureUnmarshaller);
        Assert.Contains("var unmarshaller = NullableIntUnmarshaller.Instance;", _structureUnmarshaller);
        Assert.Contains("unmarshalledObject.Seq = unmarshaller.Unmarshall(context, ref reader);", _structureUnmarshaller);
        Assert.Contains("var unmarshaller = NullableDateTimeUnmarshaller.Instance;", _structureUnmarshaller);
        Assert.Contains("""if (context.TestExpression("when", targetDepth, ref reader))""", _structureUnmarshaller);
    }

    [Fact]
    public void Structure_ScalarIsSet_UsesHasValue_StringIsSet_UsesNullCheck()
    {
        // Nullable value types check .HasValue; the string label member keeps the != null form.
        Assert.Contains("internal bool IsSetFlag() => this.Flag.HasValue;", _requestStructure);
        Assert.Contains("internal bool IsSetCreated() => this.Created.HasValue;", _requestStructure);
        Assert.Contains("internal bool IsSetId() => this.Id != null;", _requestStructure);
    }

    [Fact]
    public void StructureMarshaller_Scalars_UseCorrectWriterCalls()
    {
        Assert.Contains("public partial class DetailMarshaller", _structureMarshaller);
        Assert.Contains("if (requestObject.IsSetLevel())", _structureMarshaller);
        Assert.Contains("""context.Writer.WritePropertyName("level");""", _structureMarshaller);
        Assert.Contains("context.Writer.WriteNumberValue(requestObject.Level.Value);", _structureMarshaller);
        Assert.Contains("context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.At.Value)));", _structureMarshaller);
    }

    [Fact]
    public void ScalarList_Throws()
    {
        var json = """{ "type": "list", "member": { "target": "smithy.api#Integer" } }""";
        var list = TestModels.DeserializeShape(json);
        var id = ShapeId.Parse($"{Namespace}#TestList");

        Assert.Throws<GeneratorException>(() => TypeMapper.MapType(id, list, _context));
    }
}
