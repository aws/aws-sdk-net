using Amazon.IdentityManagement;
using Amazon.KinesisFirehose;
using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using AWSSDK.Tests.Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace AWSSDK.IntegrationTests.KinesisFirehose
{
    [TestFixture(TestOf = typeof(KinesisFirehoseTests))]
    [Category("KinesisFirehose")]
    [Category("Integration")]
    public class KinesisFirehoseTests : TestBase<AmazonKinesisFirehoseClient>
    {

        IAmazonIdentityManagementService iamClient = TestBase.CreateClient<AmazonIdentityManagementServiceClient>();

        private string BucketName = null;
        private string RoleName = null;
        private string PolicyName = null;
        private string DeliveryStreamName = null;

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
            BucketName = "unity-test-bucket-firehose" + DateTime.Now.Ticks;
            MissingAPILambdaFunctions.CreateBucket(BucketName, TestRunner.RegionEndpoint);

            Exception responseException = new Exception();
            AutoResetEvent ars = new AutoResetEvent(false);

            // Create IAM Role
            RoleName = "UnityFirehoseTestRole" + DateTime.Now.Ticks;
            Utils.AssertFalse(string.IsNullOrEmpty(TestRunner.TestAccountId), "Kinesis Firehose tests require Account ID (set in 'Resources/settings.txt') in order to create an AssumeRolePolicy.");
            string roleArn = UtilityMethods.CreateRoleIfNotExists(iamClient, RoleName, string.Format(UtilityMethods.FirehoseAssumeRolePolicyDocumentFormat, TestRunner.TestAccountId));
            Assert.IsNotNull(roleArn);

            // Attach Policy to Role
            PolicyName = "UnityFirehoseTestRolePolicy" + DateTime.Now.Ticks;
            iamClient.PutRolePolicyAsync(new Amazon.IdentityManagement.Model.PutRolePolicyRequest()
            {
                PolicyDocument = string.Format(RolePolicyDocumentFormat, BucketName),
                PolicyName = PolicyName,
                RoleName = RoleName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Utils.AssertExceptionIsNull(responseException);

            // Create Firehose Delivery Stream
            string bucketArn = "arn:aws:s3:::" + BucketName;
            DeliveryStreamName = "unity-test-delivery-stream" + DateTime.Now.Ticks;
            string deliveryStreamArn = null;
            Client.CreateDeliveryStreamAsync(new CreateDeliveryStreamRequest()
            {
                DeliveryStreamName = DeliveryStreamName,
                S3DestinationConfiguration = new S3DestinationConfiguration()
                {
                    BucketARN = bucketArn,
                    RoleARN = roleArn
                }
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    deliveryStreamArn = response.Response.DeliveryStreamARN;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Utils.AssertExceptionIsNull(responseException);
            Utils.AssertStringIsNotNullOrEmpty(deliveryStreamArn);

            // Wait for Delivery Stream to be active
            DeliveryStreamStatus streamStatus = DeliveryStreamStatus.CREATING;
            var timeout = DateTime.Now.AddSeconds(120);
            while (streamStatus != DeliveryStreamStatus.ACTIVE && DateTime.Now.Ticks < timeout.Ticks)
            {
                Client.DescribeDeliveryStreamAsync(new DescribeDeliveryStreamRequest()
                {
                    DeliveryStreamName = DeliveryStreamName
                }, (response) =>
                {
                    responseException = response.Exception;
                    if (responseException == null)
                    {
                        streamStatus = response.Response.DeliveryStreamDescription.DeliveryStreamStatus;
                    }
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Utils.AssertExceptionIsNull(responseException);
                Utils.AssertFalse(streamStatus == DeliveryStreamStatus.DELETING, "Delivery stream entered DELETING state unexpectedly.");
                Thread.Sleep(TimeSpan.FromSeconds(2));
            }
            Utils.AssertFalse(streamStatus == DeliveryStreamStatus.CREATING, "Did not exit CREATING state within time limit.");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Exception responseException = new Exception();
            AutoResetEvent ars = new AutoResetEvent(false);

            // Delete Delivery Stream
            Client.DeleteDeliveryStreamAsync(DeliveryStreamName, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Utils.AssertExceptionIsNull(responseException);

            // Delete Role Policy
            iamClient.DeleteRolePolicyAsync(new Amazon.IdentityManagement.Model.DeleteRolePolicyRequest()
            {
                RoleName = RoleName,
                PolicyName = PolicyName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Utils.AssertExceptionIsNull(responseException);

            // Delete Role
            iamClient.DeleteRoleAsync(new Amazon.IdentityManagement.Model.DeleteRoleRequest()
            {
                RoleName = RoleName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Utils.AssertExceptionIsNull(responseException);

            // Delete Bucket
            S3.S3TestUtils.CleanBucket(TestBase.CreateClient<Amazon.S3.AmazonS3Client>(), BucketName);
            MissingAPILambdaFunctions.DeleteBucket(BucketName, TestRunner.RegionEndpoint);
        }

        // Tests disabled as Account Id cannot be retrieved for device-farm tests
        //[Test]
        public void TestListDeliveryStreams()
        {
            List<string> streamNames = null;

            Exception responseException = new Exception();
            AutoResetEvent ars = new AutoResetEvent(false);
            Client.ListDeliveryStreamsAsync((response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    streamNames = response.Response.DeliveryStreamNames;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Utils.AssertExceptionIsNull(responseException);
        }

        // Tests disabled as Account Id cannot be retrieved for device-farm tests
        //[Test]
        public void TestPutRecord()
        {
            Exception responseException = new Exception();
            AutoResetEvent ars = new AutoResetEvent(false);
            using (var data = new MemoryStream())
            {
                using (var writer = new StreamWriter(data))
                {
                    writer.Write("DATAdataDATAdataDATAdata");
                    writer.Flush();
                    data.Position = 0;
                }
                string recordId = null;

                Client.PutRecordAsync(DeliveryStreamName, new Record() { Data = data }, (response) =>
                {
                    responseException = response.Exception;
                    if (responseException == null)
                    {
                        recordId = response.Response.RecordId;
                    }
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Utils.AssertExceptionIsNull(responseException);
                Utils.AssertStringIsNotNullOrEmpty(recordId);
            }
        }

        // Tests disabled as Account Id cannot be retrieved for device-farm tests
        //[Test]
        public void TestPutRecordNonExistantStream()
        {
            Exception responseException = new Exception();
            AutoResetEvent ars = new AutoResetEvent(false);
            using (var data = new MemoryStream())
            {
                using (var writer = new StreamWriter(data))
                {
                    writer.Write("DATAdataDATAdataDATAdata");
                    writer.Flush();
                    data.Position = 0;
                }

                Client.PutRecordAsync("NonExistantStream", new Record() { Data = data }, (response) =>
                {
                    responseException = response.Exception;
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();

                Utils.AssertTrue(responseException != null, "expected responseException != null");
                Utils.AssertTrue(responseException is ResourceNotFoundException, "expected responseException is ResourceNotFoundException");
            }
        }

        // Tests disabled as Account Id cannot be retrieved for device-farm tests
        //[Test]
        public void TestPutRecordBatch()
        {
            Exception responseException = new Exception();
            AutoResetEvent ars = new AutoResetEvent(false);

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
                HashSet<string> recordIds = new HashSet<string>();
                int failedPutCount = 1;

                Client.PutRecordBatchAsync(DeliveryStreamName, records, (response) =>
                {
                    responseException = response.Exception;
                    if (responseException == null)
                    {
                        failedPutCount = response.Response.FailedPutCount;
                        foreach (var individualResponse in response.Response.RequestResponses)
                        {
                            recordIds.Add(individualResponse.RecordId);
                        }
                    }
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Utils.AssertExceptionIsNull(responseException);
                Utils.AssertTrue(recordIds.Count == recordCount, "Expected " + recordCount + " Unique RecordIds");
                Utils.AssertTrue(failedPutCount == 0, "Expected FailedPutCount == 0");
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
