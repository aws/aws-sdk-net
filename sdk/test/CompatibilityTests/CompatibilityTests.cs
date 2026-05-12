using Amazon.S3;
using Amazon.DynamoDBv2;
using Amazon.SQS;
using Amazon.BedrockRuntime;
using Amazon.SimpleSystemsManagement;
using Xunit;

namespace CompatibilityTests
{
    /// <summary>
    /// Compatibility tests for testing newer .NET Core versions with older AWS SDK service DLLs
    /// This directly instantiates service clients to trigger CLR type checking, which will
    /// catch compatibility issues like missing methods (e.g., get_ServiceFullName) when
    /// mixing old service packages with newer Core versions.
    /// </summary>
    public class CompatibilityTests
    {
        [Fact]
        public void TestS3ClientCreation()
        {
            // Act & Assert
            // This will trigger CLR type loading and method resolution
            var exception = Record.Exception(() =>
            {
                var s3Client = new AmazonS3Client();
                Assert.NotNull(s3Client);
            });

            if (exception != null)
            {
                Console.WriteLine($"S3 client creation failed with: {exception.GetType().Name}: {exception.Message}");
                throw exception;
            }
        }

        [Fact]
        public void TestDynamoDBClientCreation()
        {
            // Act & Assert
            var exception = Record.Exception(() =>
            {
                var dynamoDbClient = new AmazonDynamoDBClient();
                Assert.NotNull(dynamoDbClient);
            });

            if (exception != null)
            {
                Console.WriteLine($"DynamoDB client creation failed with: {exception.GetType().Name}: {exception.Message}");
                throw exception;
            }
        }

        [Fact]
        public void TestSQSClientCreation()
        {
            // Act & Assert
            var exception = Record.Exception(() =>
            {
                var sqsClient = new AmazonSQSClient();
                Assert.NotNull(sqsClient);
            });

            if (exception != null)
            {
                Console.WriteLine($"SQS client creation failed with: {exception.GetType().Name}: {exception.Message}");
                throw exception;
            }
        }

        [Fact]
        public void TestBedrockRuntimeClientCreation()
        {
            // Act & Assert
            var exception = Record.Exception(() =>
            {
                var bedrockClient = new AmazonBedrockRuntimeClient();
                Assert.NotNull(bedrockClient);
            });

            if (exception != null)
            {
                Console.WriteLine($"BedrockRuntime client creation failed with: {exception.GetType().Name}: {exception.Message}");
                throw exception;
            }
        }

        [Fact]
        public void TestSimpleSystemsManagementClientCreation()
        {
            // Act & Assert
            // This is the service mentioned in the GitHub issue - SSM
            var exception = Record.Exception(() =>
            {
                var ssmClient = new AmazonSimpleSystemsManagementClient();
                Assert.NotNull(ssmClient);
            });

            if (exception != null)
            {
                Console.WriteLine($"SSM client creation failed with: {exception.GetType().Name}: {exception.Message}");
                throw exception;
            }
        }
    }
}
