using Xunit;
using SmithyDotNet.Generator.Writers.CodeAnalysis;

namespace SmithyDotNet.Generator.Tests.Writers.CodeAnalysis;

[Collection(nameof(CloudTrailModelCollection))]
public class PropertyValueRulesWriterTests
{
    private readonly string _propertyValueRules;

    public PropertyValueRulesWriterTests(CloudTrailModelFixture fixture)
    {
        _propertyValueRules = new PropertyValueRulesWriter(fixture.Context).Write(TestContext.Current.CancellationToken);
    }

    // Rules are pinned against sdk/code-analysis/ServiceAnalysis/CloudTrailData/Generated/PropertyValueRules.xml.
    // Operation input/output structures are named after the generated {Operation}Request/{Operation}Response
    // classes; response and error shapes carry no constrained scalars, so they contribute no rules.
    [Fact]
    public void PatternOnlyRuleCorrect()
    {
        AssertHelper("<property>Amazon.CloudTrailData.Model.PutAuditEventsRequest.ChannelArn</property>");
        AssertHelper("<pattern>^arn:.*$</pattern>");
    }

    [Fact]
    public void MinMaxPatternRuleCorrect()
    {
        AssertHelper("<property>Amazon.CloudTrailData.Model.PutAuditEventsRequest.ExternalId</property>");
        AssertHelper("<min>2</min>");
        AssertHelper("<max>1224</max>");
        AssertHelper("<pattern>^[\\w+=,.@:\\/-]*$</pattern>");
    }

    [Fact]
    public void UuidRulesCorrect()
    {
        AssertHelper("<property>Amazon.CloudTrailData.Model.AuditEvent.Id</property>");
        AssertHelper("<property>Amazon.CloudTrailData.Model.AuditEventResultEntry.EventID</property>");
        AssertHelper("<property>Amazon.CloudTrailData.Model.AuditEventResultEntry.Id</property>");
        AssertHelper("<property>Amazon.CloudTrailData.Model.ResultErrorEntry.Id</property>");
        AssertHelper("<min>1</min>");
        AssertHelper("<max>128</max>");
        AssertHelper("<pattern>^[-_A-Za-z0-9]+$</pattern>");
    }

    // The analyzer requires a rule's regex match to cover the whole value, so an unanchored pattern
    // must be padded with .* to keep Smithy's match-anywhere semantics; anchored ends stay verbatim.
    [Theory]
    [InlineData("\\S", ".*\\S.*")]
    [InlineData("^\\S+$", "^\\S+$")]
    [InlineData("^arn:aws:.*", "^arn:aws:.*")]
    [InlineData("^abc", "^abc.*")]
    [InlineData("arn:.*", ".*arn:.*")]
    [InlineData(".*\\S.*", ".*\\S.*")]
    [InlineData("([1-9][0-9]{0,4})|([a-zA-Z][a-zA-Z0-9_]{0,47})", ".*([1-9][0-9]{0,4})|([a-zA-Z][a-zA-Z0-9_]{0,47}).*")]
    [InlineData("^$", "^$")]
    [InlineData("^", "^")]
    [InlineData("$", "$")]
    public void PadsUnanchoredPatterns(string smithyPattern, string expected)
    {
        Assert.Equal(expected, PropertyValueRulesWriter.ConvertSmithyPattern(smithyPattern));
    }

    [Fact]
    public void MinMaxOnlyRulesCorrect()
    {
        AssertHelper("<property>Amazon.CloudTrailData.Model.ResultErrorEntry.ErrorCode</property>");
        AssertHelper("<property>Amazon.CloudTrailData.Model.ResultErrorEntry.ErrorMessage</property>");
        AssertHelper("<max>1024</max>");
    }

    private void AssertHelper(string expected)
    {
        Assert.Contains(expected, _propertyValueRules);
    }
}
