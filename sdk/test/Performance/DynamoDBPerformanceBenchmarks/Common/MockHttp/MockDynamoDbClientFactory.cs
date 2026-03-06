using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Runtime;
using System;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

public static class MockDynamoDbClientFactory
{
    public static AmazonDynamoDBClient Create(DynamoDBResponseProvider responseProvider)
    {
        var config = new AmazonDynamoDBConfig
        {
            RegionEndpoint = RegionEndpoint.USEast1,
            HttpClientFactory = new MockHttpClientFactory(responseProvider)
        };

        var accessKey = Environment.GetEnvironmentVariable("DEV_AWS_PUBLIC_KEY") ?? "mock-access-key";
        var secretKey = Environment.GetEnvironmentVariable("DEV_AWS_PRIVATE_KEY") ?? "mock-secret-key";
        var credentials = new BasicAWSCredentials(accessKey, secretKey);

        return new AmazonDynamoDBClient(credentials, config);
    }
}
