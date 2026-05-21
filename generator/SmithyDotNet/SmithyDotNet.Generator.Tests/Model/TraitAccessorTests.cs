using System.Text.Json;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Model;

[Collection(nameof(CloudTrailModelCollection))]
public class TraitAccessorTests(CloudTrailModelFixture fixture)
{
    #region Annotation traits

    [Fact]
    public void IsRequired_ReturnsTrueWhenPresent()
    {
        var shape = Assert.IsType<StructureShape>(fixture.DeserializeShape("com.amazonaws.cloudtraildata#AuditEvent"));
        Assert.True(shape.Members["id"].IsRequired());
    }

    [Fact]
    public void IsRequired_ReturnsFalseWhenAbsent()
    {
        var shape = Assert.IsType<StructureShape>(fixture.DeserializeShape("com.amazonaws.cloudtraildata#AuditEvent"));
        Assert.False(shape.Members["eventDataChecksum"].IsRequired());
    }

    #endregion

    #region Scalar traits

    [Fact]
    public void GetDocumentation_ReturnsValueWhenPresent()
    {
        var shape = fixture.DeserializeShape("com.amazonaws.cloudtraildata#AuditEvent");
        Assert.StartsWith("<p>An event from a source outside of Amazon Web Services", shape.GetDocumentation());
    }

    [Fact]
    public void GetDocumentation_ReturnsNullWhenAbsent()
    {
        var shape = fixture.DeserializeShape("com.amazonaws.cloudtraildata#Uuid");
        Assert.Null(shape.GetDocumentation());
    }

    [Fact]
    public void GetTitle_ReturnsValue()
    {
        var service = fixture.DeserializeShape("com.amazonaws.cloudtraildata#CloudTrailDataService");
        Assert.Equal("AWS CloudTrail Data Service", service.GetTitle());
    }

    [Fact]
    public void GetHttpQuery_ReturnsQueryParamName()
    {
        var shape = Assert.IsType<StructureShape>(fixture.DeserializeShape("com.amazonaws.cloudtraildata#PutAuditEventsRequest"));
        Assert.Equal("channelArn", shape.Members["channelArn"].GetHttpQuery());
    }

    [Fact]
    public void GetPattern_ReturnsRegex()
    {
        var shape = fixture.DeserializeShape("com.amazonaws.cloudtraildata#Uuid");
        Assert.Equal("^[-_A-Za-z0-9]+$", shape.GetPattern());
    }

    #endregion

    #region Structured traits

    [Fact]
    public void GetError_ReturnsClientError()
    {
        var shape = fixture.DeserializeShape("com.amazonaws.cloudtraildata#ChannelNotFound");
        var error = shape.GetError();
        Assert.NotNull(error);
        Assert.Equal("client", error.Value);
    }

    [Fact]
    public void GetError_ReturnsNullForNonErrorShape()
    {
        var shape = fixture.DeserializeShape("com.amazonaws.cloudtraildata#AuditEvent");
        Assert.Null(shape.GetError());
    }

    [Fact]
    public void GetHttp_ReturnsMethodAndUriWithDefaultCode()
    {
        var shape = fixture.DeserializeShape("com.amazonaws.cloudtraildata#PutAuditEvents");
        var http = shape.GetHttp();
        Assert.NotNull(http);
        Assert.Equal("POST", http.Method);
        Assert.Equal("/PutAuditEvents", http.Uri);
        Assert.Equal(200, http.Code);
    }

    [Fact]
    public void GetHttp_ReturnsCode()
    {
        var json = """
        {
            "type": "operation",
            "input": { "target": "smithy.api#Unit" },
            "output": { "target": "smithy.api#Unit" },
            "traits": { "smithy.api#http": { "method": "GET", "uri": "/health", "code": 204 } }
        }
        """;
        var shape = JsonSerializer.Deserialize<Shape>(json, CloudTrailModelFixture.Options);
        Assert.NotNull(shape);

        var http = shape.GetHttp();
        Assert.NotNull(http);
        Assert.Equal("GET", http.Method);
        Assert.Equal("/health", http.Uri);
        Assert.Equal(204, http.Code);
    }

    [Fact]
    public void GetLength_ReturnsMinAndMax()
    {
        var shape = fixture.DeserializeShape("com.amazonaws.cloudtraildata#Uuid");
        var length = shape.GetLength();
        Assert.NotNull(length);
        Assert.Equal(1, length.Min);
        Assert.Equal(128, length.Max);
    }

    [Fact]
    public void GetLength_ReturnsNullWhenAbsent()
    {
        var shape = fixture.DeserializeShape("com.amazonaws.cloudtraildata#AuditEvent");
        Assert.Null(shape.GetLength());
    }

    #endregion
}
