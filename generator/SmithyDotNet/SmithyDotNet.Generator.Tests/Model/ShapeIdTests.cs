using SmithyDotNet.Generator.Model;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Model;

public class ShapeIdTests
{
    [Fact]
    public void Parse_AbsoluteShapeId()
    {
        var id = ShapeId.Parse("com.amazonaws.cloudtraildata#AuditEvent");
        Assert.Equal("com.amazonaws.cloudtraildata", id.Namespace);
        Assert.Equal("AuditEvent", id.Name);
        Assert.Null(id.Member);
        Assert.Equal("com.amazonaws.cloudtraildata#AuditEvent", id.AbsoluteName);
    }

    [Fact]
    public void Parse_AbsoluteShapeIdWithMember()
    {
        var id = ShapeId.Parse("com.amazonaws.cloudtraildata#AuditEvent$id");
        Assert.Equal("com.amazonaws.cloudtraildata", id.Namespace);
        Assert.Equal("AuditEvent", id.Name);
        Assert.Equal("id", id.Member);
    }

    [Fact]
    public void Parse_PreludeShape()
    {
        var id = ShapeId.Parse("smithy.api#String");
        Assert.True(id.IsPrelude);
        Assert.Equal("smithy.api", id.Namespace);
        Assert.Equal("String", id.Name);
    }

    [Theory]
    [InlineData("Name$member")]
    [InlineData("name.space#")]
    [InlineData("ns.foo#bar#Name")]
    [InlineData("ns.foo#name$")]
    [InlineData("ns.foo#name$foo$bar")]
    [InlineData("ns.foo#name$$")]
    public void Parse_InvalidShapeId_Throws(string input)
    {
        Assert.Throws<ArgumentException>(() => ShapeId.Parse(input));
    }

    [Fact]
    public void ToString_WithoutMember()
    {
        var id = new ShapeId("com.example", "Foo");
        Assert.Equal("com.example#Foo", id.ToString());
    }

    [Fact]
    public void ToString_WithMember()
    {
        var id = new ShapeId("com.example", "Foo", "bar");
        Assert.Equal("com.example#Foo$bar", id.ToString());
    }

    [Fact]
    public void ImplicitStringConversion_ReturnsFullId()
    {
        ShapeId id = ShapeId.Parse("com.example#Foo$bar");
        string s = id;
        Assert.Equal("com.example#Foo$bar", s);
    }
}
