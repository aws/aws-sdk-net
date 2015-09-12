using System;
using System.Collections.Generic;
using System.Threading;

using Amazon.ElasticTranscoder;
using Amazon.ElasticTranscoder.Model;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class ElasticTranscoder : TestBase<AmazonElasticTranscoderClient>
    {
        static string TrustPolicy =
          @"{
              ""Version"": ""2012-10-17"",
              ""Statement"": [
                {
                  ""Sid"": """",
                  ""Effect"": ""Allow"",
                  ""Principal"": {
                    ""Service"": ""elastictranscoder.amazonaws.com""
                  },
                  ""Action"": ""sts:AssumeRole""
                }
              ]
            }";

        static string AccessPolicy =
           @"{
              ""Version"": ""2012-10-17"",
              ""Statement"": [
                {
                  ""Sid"": ""1"",
                  ""Effect"": ""Allow"",
                  ""Action"": [
                    ""s3:ListBucket"",
                    ""s3:Put*"",
                    ""s3:Get*"",
                    ""s3:*MultipartUpload*""
                  ],
                  ""Resource"": [
                    ""*""
                  ]
                },
                {
                  ""Sid"": ""2"",
                  ""Effect"": ""Allow"",
                  ""Action"": [
                    ""sns:Publish""
                  ],
                  ""Resource"": [
                    ""*""
                  ]
                },
                {
                  ""Sid"": ""3"",
                  ""Effect"": ""Deny"",
                  ""Action"": [
                    ""s3:*Policy*"",
                    ""sns:*Permission*"",
                    ""sns:*Delete*"",
                    ""s3:*Delete*"",
                    ""sns:*Remove*""
                  ],
                  ""Resource"": [
                    ""*""
                  ]
                }
              ]
            }";

        // To test specifying KMS key, replace this value with a valid KMS Key Arn
        private string kmsKeyArn = null;
        static IAmazonS3 s3Client;
        static IAmazonIdentityManagementService iamClient;

        public ElasticTranscoder()
        {
            iamClient = CreateClient<AmazonIdentityManagementServiceClient>();
            s3Client = CreateClient<AmazonS3Client>();
        }
        
        protected override void Dispose(bool disposing)
        {
            if (iamClient != null)
            {
                iamClient.Dispose();
                iamClient = null;
            }
            if (s3Client != null)
            {
                s3Client.Dispose();
                s3Client = null;
            }
            base.Dispose(disposing);
        }
        
        [Fact]
        [Trait(CategoryAttribute,"ElasticTranscoder")]
        public void TestListPresets()
        {
            var presets = Client.ListPresetsAsync().Result.Presets;
            Assert.True(presets.Count > 0);
        }

        [Fact]
        [Trait(CategoryAttribute,"ElasticTranscoder")]
        public void TestPipelineOperations()
        {
            var inputBucket = UtilityMethods.CreateBucketAsync(s3Client, "TestPipelineOperations").Result;
            var outputBucket = UtilityMethods.CreateBucketAsync(s3Client, "TestPipelineOperations").Result;
            var pipelineName = "sdktest-pipeline" + DateTime.Now.Ticks;
            var roleName = "sdktest-ets-role" + DateTime.Now.Ticks;
            var policyName = "Access_Policy";

            try
            {
                // Create a role with trust policy
                var role = iamClient.CreateRoleAsync(new CreateRoleRequest
                {
                    RoleName = roleName,
                    AssumeRolePolicyDocument = TrustPolicy
                }).Result.Role;
                // Set access policy
                iamClient.PutRolePolicyAsync(new PutRolePolicyRequest
                {
                    RoleName = roleName,
                    PolicyDocument = AccessPolicy,
                    PolicyName = policyName
                }).Wait();

                Client.ListPipelinesAsync().Wait();

                // Create Pipeline
                var pipeline = Client.CreatePipelineAsync(
                    new CreatePipelineRequest
                    {
                        Name = pipelineName,
                        InputBucket = inputBucket,
                        OutputBucket = outputBucket,
                        Notifications = new Notifications
                        {
                            Completed = string.Empty,
                            Error = string.Empty,
                            Progressing = string.Empty,
                            Warning = string.Empty
                        },
                        Role = role.Arn,
                        AwsKmsKeyArn = kmsKeyArn
                    }).Result.Pipeline;
                Assert.NotNull(pipeline);
                Assert.Equal(pipeline.Name, pipelineName);
                UtilityMethods.Sleep(System.TimeSpan.FromSeconds(5));

                // List Pipelines
                var pipelines = Client.ListPipelinesAsync().Result.Pipelines;
                Assert.True(pipelines.Count > 0);
                pipelines.Contains(pipeline);

                // Get Pipeline
                var readPipelineResult = Client.ReadPipelineAsync(
                    new ReadPipelineRequest() { Id = pipeline.Id }).Result;
                Assert.Equal(readPipelineResult.Pipeline.Id, pipeline.Id);

                // Update pipeline
                Client.UpdatePipelineStatusAsync(
                    new UpdatePipelineStatusRequest
                    {
                        Id = pipeline.Id,
                        Status = "Paused"
                    }).Wait();

                // Get pipeline
                readPipelineResult = Client.ReadPipelineAsync(
                    new ReadPipelineRequest { Id = pipeline.Id }).Result;
                Assert.Equal("Paused".ToLower(), readPipelineResult.Pipeline.Status.ToLower());

                // List jobs
                var jobs = Client.ListJobsByPipelineAsync(
                    new ListJobsByPipelineRequest
                    {
                        PipelineId = pipeline.Id,
                        Ascending = "true"
                    }).Result.Jobs;

                // Remove pipeline
                Client.DeletePipelineAsync(
                    new DeletePipelineRequest { Id = pipeline.Id }).Wait();

                AssertExtensions.ExpectExceptionAsync < AmazonElasticTranscoderException>(Client.ReadPipelineAsync(
                        new ReadPipelineRequest() { Id = pipeline.Id })).Wait();
            }
            finally
            {
                s3Client.DeleteBucketAsync(new DeleteBucketRequest { BucketName = inputBucket }).Wait();
                s3Client.DeleteBucketAsync(new DeleteBucketRequest { BucketName = outputBucket }).Wait();

                iamClient.DeleteRolePolicyAsync(new DeleteRolePolicyRequest
                {
                    RoleName = roleName,
                    PolicyName = policyName
                }).Wait();

                iamClient.DeleteRoleAsync(new DeleteRoleRequest
                {
                    RoleName = roleName
                }).Wait();
            }
        }

    }
}
