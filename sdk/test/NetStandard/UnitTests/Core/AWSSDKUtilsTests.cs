using System.Collections.Generic;
using Amazon.Util;
using System.Text;
using Amazon.Runtime.Internal;
using Xunit;

namespace UnitTests.NetStandard.Core
{
    [Trait("Category", "Core")]
    public class AWSSDKUtilsTests
    {
        [Fact]
        public void GetParametersAsString()
        {
            var parameters = new ParameterCollection
            {
                { "key1", "value1" },
                { "key2", "value2" },
                { "key3", new List<string> { "value3", "value4" } },
                { "key4", new List<double> { 1.1, 2.1 } }
            };

            var parametersString = AWSSDKUtils.GetParametersAsString(parameters);

            Assert.Equal("key1=value1&key2=value2&key3=value3&key3=value4&key4=1.1&key4=2.1", parametersString);
        }

        [Fact]
        public void ToHexUppercase()
        {
            var bytes = Encoding.UTF8.GetBytes("Hello World");
            var hexString = AWSSDKUtils.ToHex(bytes, false);

            Assert.Equal("48656C6C6F20576F726C64", hexString);
        }

        [Fact]
        public void ToHexLowercase()
        {
            var bytes = Encoding.UTF8.GetBytes("Hello World");
            var hexString = AWSSDKUtils.ToHex(bytes, true);

            Assert.Equal("48656c6c6f20576f726c64", hexString);
        }

        [Fact]
        public void CompressSpaces()
        {
            var data = "Hello,   World!";
            var compressed = AWSSDKUtils.CompressSpaces(data);
            Assert.Equal("Hello, World!", compressed);
        }

        [Theory]
        [InlineData("https://s3.amazonaws.com", "s3")]
        [InlineData("sqs.us-west-2.amazonaws.com", "sqs")]
        [InlineData("queue.amazonaws.com", "sqs")]
        [InlineData("https://sns.us-west-2.amazonaws.com", "sns")]
        [InlineData("https://s3-external-1.amazonaws.com", "s3")]
        public void DetermineService(string url, string expectedService)
        {
            var service = AWSSDKUtils.DetermineService(url);

            Assert.Equal(expectedService, service);
        }

        [Theory]
        [InlineData("value, with special chars!", "value%2C%20with%20special%20chars%21")]
        [InlineData("value, with special chars and path {/+:}", "value%2C%20with%20special%20chars%20and%20path%20%7B%2F%2B%3A%7D")]
        [InlineData(TemplateText, "%7B%0A%09%22AWSTemplateFormatVersion%22%20%3A%20%222010-09-09%22%2C%0A%0A%09%22Description%22%20%3A%20%22This%20is%20a%20sample%20template%22%2C%0A%0A%09%22Parameters%22%20%3A%20%7B%0A%09%09%22TopicName%22%20%3A%20%7B%0A%09%09%20%20%20%20%22Type%22%20%3A%20%22String%22%2C%0A%20%20%20%20%20%20%20%20%20%20%20%20%22Default%22%20%3A%20%22TheTopic%22%2C%0A%20%20%20%20%20%20%20%20%20%20%20%20%22Description%22%20%3A%20%22A%20topic.%22%0A%09%09%7D%2C%0A%20%20%20%20%20%20%20%20%22QueueName%22%20%3A%20%7B%0A%20%20%20%20%20%20%20%20%20%20%20%20%22Type%22%20%3A%20%22String%22%2C%0A%20%20%20%20%20%20%20%20%20%20%20%20%22Default%22%20%3A%20%22TheQueue%22%2C%0A%20%20%20%20%20%20%20%20%20%20%20%20%22Description%22%20%3A%20%22A%20queue.%22%0A%20%20%20%20%20%20%20%20%7D%0A%09%7D%2C%0A%0A%09%22Resources%22%20%3A%20%7B%0A%0A%09%09%22TheQueue%22%20%3A%20%7B%0A%09%09%20%20%20%20%22Type%22%20%3A%20%22AWS%3A%3ASQS%3A%3AQueue%22%2C%0A%09%09%20%20%20%20%22Properties%22%20%3A%20%7B%0A%09%09%09%09%22QueueName%22%20%3A%20%7B%20%22Ref%22%20%3A%20%22QueueName%22%20%7D%0A%09%09%20%20%20%20%7D%0A%09%09%7D%2C%0A%0A%20%20%20%20%20%20%20%20%22TheTopic%22%20%3A%20%7B%0A%20%20%20%20%20%20%20%20%20%20%20%20%22Type%22%20%3A%20%22AWS%3A%3ASNS%3A%3ATopic%22%2C%0A%20%20%20%20%20%20%20%20%20%20%20%20%22Properties%22%20%3A%20%7B%0A%09%09%09%09%22TopicName%22%20%3A%20%7B%20%22Ref%22%20%3A%20%22TopicName%22%20%7D%2C%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%20%20%22Subscription%22%20%3A%20%5B%0A%09%09%09%09%09%7B%22Protocol%22%20%3A%20%22sqs%22%2C%20%22Endpoint%22%20%3A%20%7B%22Fn%3A%3AGetAtt%22%20%3A%20%5B%20%22TheQueue%22%2C%20%22Arn%22%5D%7D%7D%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%20%20%5D%0A%20%20%20%20%20%20%20%20%20%20%20%20%7D%0A%20%20%20%20%20%20%20%20%7D%0A%09%7D%2C%0A%0A%09%22Outputs%22%20%3A%20%7B%0A%09%09%22TopicARN%22%20%3A%20%7B%0A%09%09%20%20%20%20%22Value%22%20%3A%20%7B%20%22Ref%22%20%3A%20%22TheTopic%22%20%7D%0A%09%09%7D%2C%0A%20%20%20%20%20%20%20%20%22QueueURL%22%20%3A%20%7B%0A%20%20%20%20%20%20%20%20%20%20%20%20%22Value%22%20%3A%20%7B%20%22Ref%22%20%3A%20%22TheQueue%22%20%7D%0A%20%20%20%20%20%20%20%20%7D%0A%09%7D%0A%7D%0A")]
        public void UrlEncodeWithoutPath(string input, string expected)
        {
            var encoded = AWSSDKUtils.UrlEncode(input, path: false);

            Assert.Equal(expected, encoded);
        }

        const string TemplateText = @"{
	""AWSTemplateFormatVersion"" : ""2010-09-09"",

	""Description"" : ""This is a sample template"",

	""Parameters"" : {
		""TopicName"" : {
		    ""Type"" : ""String"",
            ""Default"" : ""TheTopic"",
            ""Description"" : ""A topic.""
		},
        ""QueueName"" : {
            ""Type"" : ""String"",
            ""Default"" : ""TheQueue"",
            ""Description"" : ""A queue.""
        }
	},

	""Resources"" : {

		""TheQueue"" : {
		    ""Type"" : ""AWS::SQS::Queue"",
		    ""Properties"" : {
				""QueueName"" : { ""Ref"" : ""QueueName"" }
		    }
		},

        ""TheTopic"" : {
            ""Type"" : ""AWS::SNS::Topic"",
            ""Properties"" : {
				""TopicName"" : { ""Ref"" : ""TopicName"" },
                ""Subscription"" : [
					{""Protocol"" : ""sqs"", ""Endpoint"" : {""Fn::GetAtt"" : [ ""TheQueue"", ""Arn""]}}
                ]
            }
        }
	},

	""Outputs"" : {
		""TopicARN"" : {
		    ""Value"" : { ""Ref"" : ""TheTopic"" }
		},
        ""QueueURL"" : {
            ""Value"" : { ""Ref"" : ""TheQueue"" }
        }
	}
}
";

        [Theory]
        [InlineData("\ud83d\ude02 value, with special chars!", "%F0%9F%98%82%20value%2C%20with%20special%20chars!")]
        [InlineData("value, with special chars!", "value%2C%20with%20special%20chars!")]
        [InlineData("value, with special chars and path {/+:}", "value%2C%20with%20special%20chars%20and%20path%20%7B/%2B:%7D")]
        public void UrlEncodeWithPath(string input, string expected)
        {
            var encoded = AWSSDKUtils.UrlEncode(input, path: true);

            Assert.Equal(expected, encoded);
        }
    }
}
