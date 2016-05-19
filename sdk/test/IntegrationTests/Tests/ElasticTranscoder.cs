using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.ElasticTranscoder;
using Amazon.ElasticTranscoder.Model;
using AWSSDK_DotNet.IntegrationTests.Tests;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

using AWSSDK_DotNet.IntegrationTests.Tests.S3;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
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

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            iamClient = new AmazonIdentityManagementServiceClient();
            s3Client = new AmazonS3Client();
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
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
        }

        [TestMethod]
        [TestCategory("ElasticTranscoder")]
        public void TestListPresets()
        {
            var presets = Client.ListPresets().Presets;
            Assert.IsTrue(presets.Count > 0);
        }

        [TestMethod]
        [TestCategory("ElasticTranscoder")]
        public void TestPipelineOperations()
        {
            var inputBucket = S3TestUtils.CreateBucket(s3Client);
            var outputBucket = S3TestUtils.CreateBucket(s3Client);
            var pipelineName = "sdktest-pipeline" + DateTime.Now.Ticks;
            var roleName = "sdktest-ets-role" + DateTime.Now.Ticks;
            var policyName = "Access_Policy";
            var pipelineId = string.Empty;
            var pipelineExists = false;

            try
            {
                // Create a role with trust policy
                var role = iamClient.CreateRole(new CreateRoleRequest
                {
                    RoleName = roleName,
                    AssumeRolePolicyDocument = TrustPolicy
                }).Role;
                // Set access policy
                iamClient.PutRolePolicy(new PutRolePolicyRequest
                {
                    RoleName = roleName,
                    PolicyDocument = AccessPolicy,
                    PolicyName = policyName
                });

                Client.ListPipelines();

                // Create Pipeline
                var pipeline = Client.CreatePipeline(
                    new CreatePipelineRequest
                    {
                        Name = pipelineName,
                        InputBucket = inputBucket,
                        OutputBucket = outputBucket,
                        Notifications = new Notifications
                        {
                        },
                        Role = role.Arn,
                        AwsKmsKeyArn = kmsKeyArn
                    }).Pipeline;
                pipelineExists = true;
                Assert.IsNotNull(pipeline);
                Assert.AreEqual(pipeline.Name, pipelineName);
                Thread.Sleep(1000 * 5);
                pipelineId = pipeline.Id;

                // List Pipelines
                var pipelines = Client.ListPipelines().Pipelines;
                Assert.IsTrue(pipelines.Count > 0);
                pipelines.Contains(pipeline);

                // Get Pipeline
                var readPipelineResult = Client.ReadPipeline(
                    new ReadPipelineRequest() { Id = pipelineId });
                Assert.AreEqual(readPipelineResult.Pipeline.Id, pipelineId);

                // Update pipeline
                Client.UpdatePipelineStatus(
                    new UpdatePipelineStatusRequest
                    {
                        Id = pipelineId,
                        Status = "Paused"
                    });

                // Get pipeline
                readPipelineResult = Client.ReadPipeline(
                    new ReadPipelineRequest { Id = pipelineId });
                Assert.AreEqual("Paused".ToLower(), readPipelineResult.Pipeline.Status.ToLower());

                // List jobs
                var jobs = Client.ListJobsByPipeline(
                    new ListJobsByPipelineRequest
                    {
                        PipelineId = pipelineId,
                        Ascending = "true"
                    }).Jobs;

                // Remove pipeline
                Client.DeletePipeline(
                    new DeletePipelineRequest { Id = pipelineId });
                pipelineExists = false;

                AssertExtensions.ExpectException(() =>
                {
                    readPipelineResult = Client.ReadPipeline(
                        new ReadPipelineRequest() { Id = pipelineId });
                }, typeof(ResourceNotFoundException));
            }
            finally
            {
                s3Client.DeleteBucket(new DeleteBucketRequest { BucketName = inputBucket });
                s3Client.DeleteBucket(new DeleteBucketRequest { BucketName = outputBucket });

                iamClient.DeleteRolePolicy(new DeleteRolePolicyRequest
                {
                    RoleName = roleName,
                    PolicyName = policyName
                });

                iamClient.DeleteRole(new DeleteRoleRequest
                {
                    RoleName = roleName
                });

                if (pipelineExists)
                {
                    // Remove pipeline
                    Client.DeletePipeline(new DeletePipelineRequest { Id = pipelineId });
                }
            }
        }

        /// <summary>
        /// This test validates that the Notifications shape contains specific members.
        /// This test will fail anytime a new member is added, the new member needs to be reviewed 
        /// w.r.t the customization for CreatePipelineRequest in AmazonElasticTranscoderPreMarshallHandler
        /// and this test should be updated.
        /// </summary>
        [TestMethod]
        [TestCategory("ElasticTranscoder")]        
        public void ValidateNotificationsShapeMembers()
        {
            var members = new HashSet<string> { "Completed", "Error", "Progressing", "Warning" };
            var properties = typeof(Notifications).GetProperties();

            Assert.AreEqual(members.Count, properties.Length);

            foreach (var item in properties)
            {
                Assert.IsTrue(members.Contains(item.Name));
            }
        }
    }
}
