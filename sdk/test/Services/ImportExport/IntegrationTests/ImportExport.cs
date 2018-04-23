using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.ImportExport;
using Amazon.ImportExport.Model;
using Amazon.Runtime;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class ImportExport : TestBase<AmazonImportExportClient>
    {
        const string IMPORT_MANIFEST =
@"bucket: @BUCKET@
accessKeyId: @ACCESS_KEY_ID@
manifestVersion: 1.3
eraseDevice: true
deviceId: 123
notificationEmail: john.doe@example.com
returnAddress:
   name: Amazon.com ATTN:Joe Random
   street1: 5555555 5th Ave
   city: Seattle
   stateOrProvince: WA
   postalCode: 98104
   phoneNumber: 206-555-1000
   country: USA
";

        const string EXPORT_MANIFEST =
@"manifestVersion: 1.2
accessKeyId: @ACCESS_KEY_ID@
deviceId: 532404500021
logBucket: @BUCKET@
trueCryptPassword: apassword
logPrefix: logs/
fileSystem: NTFS
notificationEmail: john.doe@example.com
operations:
    - exportBucket: @BUCKET@
returnAddress:
    name: Amazon.com ATTN Joe Random
    street1: 1200 12th Ave S.
    city: Seattle
    stateOrProvince: WA
    postalCode: 98114
    phoneNumber: 206-266-0000
    country: USA
";

        static AmazonS3Client s3Client;

        static string bucketName;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            s3Client = new AmazonS3Client();

            // Add test data to export
            bucketName = "sdk-import-test" + DateTime.Now.Ticks;
            s3Client.PutBucket(new PutBucketRequest { BucketName = bucketName });
            s3Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = "data.txt",
                ContentBody = "import-export-data"
            });
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();

            if(s3Client != null)
            {
                AmazonS3Util.DeleteS3BucketWithObjects(s3Client, bucketName);
                s3Client.Dispose();
                s3Client = null;
            }
        }

        [TestMethod]
        [TestCategory("ImportExport")]
        public void TestImportExport()
        {
            // CreateJob
            CreateJobRequest createJobRequest = new CreateJobRequest
            {
                JobType = JobType.Import,
                Manifest = GetSampleManifestText(IMPORT_MANIFEST)
            };
            var createJobResponse = Client.CreateJob(createJobRequest);
            string createdJobId = createJobResponse.JobId;
            Assert.IsNotNull(createdJobId);
            Assert.AreEqual(JobType.Import, createJobResponse.JobType);
            Assert.IsNotNull(createJobResponse.Signature);
            Assert.IsNotNull(createJobResponse.SignatureFileContents);


            // UpdateJob
            UpdateJobRequest updateJobRequest = new UpdateJobRequest
            {
                JobId = createdJobId,
                JobType = JobType.Export,
                Manifest = GetSampleManifestText(EXPORT_MANIFEST)
            };
            Client.UpdateJob(updateJobRequest);


            // ListJobs
            var listJobsResponse = Client.ListJobs(new ListJobsRequest { MaxJobs = 100 });
            Assert.IsNotNull(listJobsResponse.IsTruncated);
            Job job = FindJob(createdJobId, listJobsResponse.Jobs);
            Assert.IsNotNull(job);
            Assert.IsTrue(job.CreationDate > DateTime.MinValue);
            Assert.IsFalse(job.IsCanceled);
            Assert.AreEqual(createdJobId, job.JobId);
            Assert.AreEqual(JobType.Export, job.JobType);
            Assert.IsFalse(job.IsCanceled);


            // GetStatus
            var getStatusResponse = Client.GetStatus(new GetStatusRequest { JobId = createdJobId });
            Assert.IsNotNull(getStatusResponse.CreationDate);
            Assert.IsNotNull(getStatusResponse.CurrentManifest);
            Assert.AreEqual(createdJobId, getStatusResponse.JobId);
            Assert.AreEqual(JobType.Export, getStatusResponse.JobType);
            Assert.IsNotNull(getStatusResponse.ProgressMessage);
            Assert.IsNotNull(getStatusResponse.LocationMessage);
            Assert.IsNotNull(getStatusResponse.LocationCode);
            Assert.IsNotNull(getStatusResponse.Signature);
            Assert.AreEqual(0, getStatusResponse.ErrorCount);
            Assert.IsNotNull(getStatusResponse.ProgressMessage);
            Assert.IsNotNull(getStatusResponse.SignatureFileContents);
            Assert.IsNull(getStatusResponse.Carrier);
            Assert.IsNull(getStatusResponse.TrackingNumber);
            Assert.IsNull(getStatusResponse.LogBucket);
            Assert.IsNull(getStatusResponse.LogKey);


            // Cancel our test job
            Client.CancelJob(new CancelJobRequest { JobId = createdJobId });
            AssertJobIsCancelled(createdJobId);
            createdJobId = null;
        }

        private Job FindJob(String jobId, List<Job> jobs)
        {
            var job = jobs.Find(item => item.JobId == jobId);

            if (job == null)
                Assert.Fail("Expected to find a job with ID '" + jobId + "', but didn't");
            return job;
        }

        private void AssertJobIsCancelled(string jobId)
        {
            Job job = FindJob(jobId, Client.ListJobs(new ListJobsRequest()).Jobs);
            Assert.IsTrue(job.IsCanceled);
        }



        private string GetSampleManifestText(string manifest)
        {
            manifest = manifest.Replace("@BUCKET@", bucketName);
            manifest = manifest.Replace("@ACCESS_KEY_ID@", "AAAEXAMPLE");

            return manifest;
        }

    }
}
