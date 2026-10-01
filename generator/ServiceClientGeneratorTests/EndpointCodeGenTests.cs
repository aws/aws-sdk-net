using Json.LitJson;
using ServiceClientGenerator.Endpoints;
using Xunit;

namespace ServiceClientGeneratorTests
{
    [Trait("Category", "UnitTests")]
    public class EndpointCodeGenTests
    {
        private static string GenerateRulesForError(string error)
        {
            var errorJson = "\"" + error.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"";
            var json = @"{
                ""version"": ""1.0"",
                ""parameters"": {},
                ""rules"": [
                    { ""conditions"": [], ""error"": " + errorJson + @", ""type"": ""error"" }
                ]
            }";
            return CodeGen.GenerateRules(JsonMapper.ToObject<RuleSet>(json));
        }

        [Fact]
        public void ErrorWithQuotesAndNoTemplateEmitsEscapedString()
        {
            var code = GenerateRulesForError("Mode must be \"standard\" when ResourceId is set.");

            Assert.Contains(@"throw new AmazonClientException(""Mode must be \""standard\"" when ResourceId is set."");", code);
        }

        [Fact]
        public void ErrorWithBackslashAndNoTemplateEmitsEscapedString()
        {
            var code = GenerateRulesForError(@"Invalid path C:\temp");

            Assert.Contains(@"throw new AmazonClientException(""Invalid path C:\\temp"");", code);
        }

        [Fact]
        public void ErrorWithQuotesAndTemplateEmitsInterpolatedVerbatimString()
        {
            var code = GenerateRulesForError("Invalid \"{Region}\" value.");

            Assert.Contains(@"throw new AmazonClientException(Interpolate(@""Invalid """"{Region}"""" value."", refs));", code);
        }

        [Fact]
        public void ErrorWithoutQuotesEmitsPlainString()
        {
            var code = GenerateRulesForError("Invalid Configuration: Missing Region");

            Assert.Contains(@"throw new AmazonClientException(""Invalid Configuration: Missing Region"");", code);
        }
    }
}
