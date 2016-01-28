using Amazon.KinesisFirehose;
using Amazon.KinesisFirehose.Model;
using NUnit.Framework;
using CommonTests.Framework;
using System.Collections.Generic;
using System.IO;
using System;
using Amazon.IdentityManagement;
using Amazon.S3;
using Amazon.IdentityManagement.Model;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class KinesisFirehose : TestBase<AmazonKinesisFirehoseClient>
    {

        private static string TestAccountId = UtilityMethods.AccountId;
        static IAmazonIdentityManagementService iamClient = CreateClient<AmazonIdentityManagementServiceClient>();
        static AmazonS3Client s3Client = CreateClient<AmazonS3Client>();

        private string BucketName = null;
        private string RoleName = null;
        private string PolicyName = null;
        private string DeliveryStreamName = null;

        public static readonly string FirehoseAssumeRolePolicyDocumentFormat =
@"{{
  ""Version"": ""2012-10-17"",
  ""Statement"": [
    {{
      ""Sid"": """",
      ""Effect"": ""Allow"",
      ""Principal"": {{
        ""Service"": ""firehose.amazonaws.com""
      }},
      ""Action"": ""sts:AssumeRole"",
      ""Condition"": {{
        ""StringEquals"": {{
          ""sts:ExternalId"": ""{0}""
        }}
      }}
    }}
  ]
}}
".Trim();

        private static string RolePolicyDocumentFormat =
@"{{
  ""Version"": ""2012-10-17"",
  ""Statement"": [
    {{
      ""Sid"": """",
      ""Effect"": ""Allow"",
      ""Action"": [
        ""s3:AbortMultipartUpload"",
        ""s3:GetBucketLocation"",
        ""s3:GetObject"",
        ""s3:ListBucket"",
        ""s3:ListBucketMultipartUploads"",
        ""s3:PutObject""
      ],
      ""Resource"": [
        ""arn:aws:s3:::{0}"",
        ""arn:aws:s3:::{0}/*""
      ]
    }}
  ]
}}";
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            // Create S3 Bucket
            BucketName = "sdk-dotnet-integ-test-bucket-firehose" + DateTime.Now.Ticks;
            s3Client.PutBucketAsync(BucketName).Wait();

            // Create IAM Role
            RoleName = "NetFirehoseTestRole" + DateTime.Now.Ticks;
            if (string.IsNullOrEmpty(TestAccountId))
                Assert.Fail("TestAccountId must be specified to run these tests");

            var iamCreateResponse = iamClient.CreateRoleAsync(new CreateRoleRequest
            {
                RoleName = RoleName,
                AssumeRolePolicyDocument = string.Format(FirehoseAssumeRolePolicyDocumentFormat, TestAccountId)
            }).Result;
            string roleArn = iamCreateResponse.Role.Arn;
            Assert.IsNotNull(roleArn);

            // Attach Policy to Role
            PolicyName = "NetFirehoseTestRolePolicy" + DateTime.Now.Ticks;
            iamClient.PutRolePolicyAsync(new PutRolePolicyRequest()
            {
                PolicyDocument = string.Format(RolePolicyDocumentFormat, BucketName),
                PolicyName = PolicyName,
                RoleName = RoleName
            }).Wait();

            // Wait for eventual consistency of role.
            UtilityMethods.Sleep(TimeSpan.FromSeconds(10));

            // Create Firehose Delivery Stream
            string bucketArn = "arn:aws:s3:::" + BucketName;
            DeliveryStreamName = "dotnet-test-delivery-stream" + DateTime.Now.Ticks;
            string deliveryStreamArn = Client.CreateDeliveryStreamAsync(new CreateDeliveryStreamRequest()
            {
                DeliveryStreamName = DeliveryStreamName,
                S3DestinationConfiguration = new S3DestinationConfiguration()
                {
                    BucketARN = bucketArn,
                    RoleARN = roleArn
                }
            }).Result.DeliveryStreamARN;
            if (string.IsNullOrEmpty(deliveryStreamArn))
            {
                Assert.Fail("Expected a deliveryStreamArn value");
            }

            // Wait for Delivery Stream to be active
            DeliveryStreamStatus streamStatus = DeliveryStreamStatus.CREATING;
            var timeout = DateTime.Now.AddSeconds(120);
            while (streamStatus != DeliveryStreamStatus.ACTIVE && DateTime.Now.Ticks < timeout.Ticks)
            {
                streamStatus = Client.DescribeDeliveryStreamAsync(new DescribeDeliveryStreamRequest()
                {
                    DeliveryStreamName = DeliveryStreamName
                }).Result.DeliveryStreamDescription.DeliveryStreamStatus;
                Assert.AreNotEqual(streamStatus, DeliveryStreamStatus.DELETING);
                UtilityMethods.Sleep(TimeSpan.FromSeconds(2));
            }
            Assert.AreNotEqual(streamStatus, DeliveryStreamStatus.CREATING, "Did not exit CREATING state within time limit.");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // Delete Delivery Stream
            Client.DeleteDeliveryStreamAsync(DeliveryStreamName).Wait();

            // Delete Role Policy
            iamClient.DeleteRolePolicyAsync(new DeleteRolePolicyRequest()
            {
                RoleName = RoleName,
                PolicyName = PolicyName
            }).Wait();

            // Delete Role
            iamClient.DeleteRoleAsync(new DeleteRoleRequest()
            {
                RoleName = RoleName
            }).Wait();

            // Delete Bucket
            UtilityMethods.DeleteBucketWithObjectsAsync(s3Client, BucketName).Wait();
        }

        [Test]
        [Category("KinesisFirehose")]
        public void TestListDeliveryStreams()
        {
            List<string> streamNames = Client.ListDeliveryStreamsAsync().Result.DeliveryStreamNames;
            Assert.IsNotNull(streamNames);
        }

        [Test]
        [Category("KinesisFirehose")]
        public void TestPutRecord()
        {
            using (var data = new MemoryStream())
            {
                using (var writer = new StreamWriter(data))
                {
                    writer.Write("DATAdataDATAdataDATAdata");
                    writer.Flush();
                    data.Position = 0;
                }
                string recordId = Client.PutRecordAsync(DeliveryStreamName, new Record() { Data = data }).Result.RecordId;
                if (string.IsNullOrEmpty(recordId))
                {
                    Assert.Fail("Expected recordId to have a value.");
                }
            }
        }

        [Test]
        [Category("KinesisFirehose")]
        public void TestPutRecordNonExistantStream()
        {
            using (var data = new MemoryStream())
            {
                using (var writer = new StreamWriter(data))
                {
                    writer.Write("DATAdataDATAdataDATAdata");
                    writer.Flush();
                    data.Position = 0;
                }

                var exception = AssertExtensions.ExpectExceptionAsync<ResourceNotFoundException>(Client.PutRecordAsync("NonExistantStream", new Record() { Data = data })).Result;
                Assert.NotNull(exception);
            }
        }

        [Test]
        [Category("KinesisFirehose")]
        public void TestPutRecordBatch()
        {
            int recordCount = 8;

            List<Record> records = new List<Record>();
            try
            {
                for (int i = 0; i < recordCount; i++)
                {
                    var data = new MemoryStream();
                    using (var writer = new StreamWriter(data))
                    {
                        writer.Write(string.Format("DATA{0}data{0}DATA{0}data{0}DATA{0}data{0}", i));
                        writer.Flush();
                        data.Position = 0;
                    }
                    records.Add(new Record { Data = data });
                }
                var response = Client.PutRecordBatchAsync(DeliveryStreamName, records).Result;

                HashSet<string> recordIds = new HashSet<string>();
                foreach (var individualResponse in response.RequestResponses)
                {
                    recordIds.Add(individualResponse.RecordId);
                }

                Assert.AreEqual(recordIds.Count, recordCount);
                Assert.AreEqual(response.FailedPutCount, 0, "Expected FailedPutCount == 0");
            }
            finally
            {
                foreach (var record in records)
                {
                    record.Data.Dispose();
                }
            }
        }
    }
}
